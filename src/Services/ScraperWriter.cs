using SchemaScraper.Models;
using SchemaScraper.Sql;

namespace SchemaScraper.Services;
public class ScraperWriter(string root, Connector connector)
{
    readonly DirectoryInfo root = new(root);
    readonly ScraperQuery query = new(connector);

    #region Tables

    public async Task GenerateTables(Func<string, Task>? action)
    {
        ConsoleColor foreground = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Generating schema metadata for {connector} in directory {root.FullName}");
        Console.ForegroundColor = ConsoleColor.Gray;

        try
        {
            InitializeRoot();
            List<ScraperTable> tables = await query.QueryTables();

            using StreamWriter writer = InitializeDocument("tables.md");
            await InitializeTables(writer);

            foreach (ScraperTable table in tables)
            {
                await writer.WriteLineAsync(
                    $"{FormatLink(table.Table, "./tables/")} | {table.RecordCount}"
                );

                if (action is not null)
                    await action(table.Table);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Schema metadata generation complete");

        }
        finally
        {
            Console.ForegroundColor = foreground;
        }
    }

    static async Task InitializeTables(StreamWriter writer)
    {
        await writer.WriteLineAsync("# Tables");
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("Table | RecordCount");
        await writer.WriteLineAsync("------|------------");
    }

    #endregion

    #region Table

    public async Task GenerateTable(string table)
    {
        Console.WriteLine($"Generating table metadata for {table}");

        using StreamWriter writer = InitializeDocument($"{table}.md", "tables");
        await InitializeTable(writer, table);
        await GenerateColumns(writer, table);
        await GenerateRelationships(writer, table);
        await GenerateMaps(writer, table);
    }

    static async Task InitializeTable(StreamWriter writer, string table)
    {
        await writer.WriteLineAsync($"# {table}");
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("* [Columns](#columns)");
        await writer.WriteLineAsync("* [Relationships](#relationships)");
        await writer.WriteLineAsync("* [Dependency Map](#dependency-map)");
        await writer.WriteLineAsync();
    }

    #endregion

    #region Columns

    async Task GenerateColumns(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating column metadata for {table}");

        List<ScraperColumn> columns = await query.QueryColumns(table);
        await InitializeColumns(writer, columns, table);

        foreach (ScraperColumn column in columns)
            await writer.WriteLineAsync(
                $"**{column.Column}** | `{column.Type}` | {column.IsNullable}"
            );

        await writer.WriteLineAsync();
    }

    static async Task InitializeColumns(StreamWriter writer, List<ScraperColumn> columns, string table)
    {
        await FormatHeader(writer, "Columns", table);

        if (columns.Count > 0)
        {
            await writer.WriteLineAsync(
                "Column | Type | Is Nullable"
            );

            await writer.WriteLineAsync(
                "-------|------|------------"
            );
        }
        else
            await writer.WriteLineAsync(
                "No columns defined"
            );
    }

    #endregion

    #region Relationships

    async Task GenerateRelationships(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating relationship metadata for {table}");
        await InitializeRelationships(writer, table);
        await GenerateDependencies(writer, table);
        await GenerateDependents(writer, table);
    }

    static async Task InitializeRelationships(StreamWriter writer, string table)
    {
        await FormatHeader(writer, "Relationships", table);
        await writer.WriteLineAsync();
        await writer.WriteLineAsync(
            "The sections that follow define:"
        );
        await writer.WriteLineAsync(
            $"* **Dependencies** - foreign key relationships defined by `{table}`."
        );
        await writer.WriteLineAsync(
            $"* **Dependents** - foreign key relationships defined by other tables that reference `{table}`."
        );
        await writer.WriteLineAsync();

    }

    #region Dependencies

    async Task GenerateDependencies(StreamWriter writer, string table)
    {
        List<ScraperDependency> deps = await query.QueryDependencies(table);
        await InitializeDependencies(writer, deps, table);

        foreach (ScraperDependency dep in deps)
            await writer.WriteLineAsync(
                WriteDependency(dep, table)
            );

        await writer.WriteLineAsync();
    }

    static async Task InitializeDependencies(StreamWriter writer, List<ScraperDependency> deps, string table)
    {
        await FormatHeader(writer, "Dependencies", table, "###");

        await writer.WriteLineAsync(
            $"**Dependency Table** refers to the table that the foreign key defined by `{table}` maps to."
        );

        await writer.WriteLineAsync();
        
        await writer.WriteLineAsync(
            $"**Foreign Key Column** is the column in `{table}` that maps to **Dependency Key Column** in **Dependency Table**."
        );

        await writer.WriteLineAsync();

        if (deps.Count > 0)
        {
            await writer.WriteLineAsync(
                "Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column"
            );

            await writer.WriteLineAsync(
                "-----------------|--------------------|------------------|----------------------"
            );
        }
        else
            await writer.WriteLineAsync(
                "No dependencies defined"
            );
    }

    static string WriteDependency(ScraperDependency dep, string table) =>
        $"**{dep.ForeignKeyName}** | `{dep.ForeignKeyColumn}` | {FormatTableLink(dep.DependencyTable, table)} | `{dep.DependencyKey}`";

    #endregion

    #region Dependents

    async Task GenerateDependents(StreamWriter writer, string table)
    {
        List<ScraperDependent> deps = await query.QueryDependents(table);
        await InitializeDependents(writer, deps, table);

        foreach (ScraperDependent dep in deps)
            await writer.WriteLineAsync(
                WriteDependent(dep, table)
            );
        
        await writer.WriteLineAsync();
    }

    static async Task InitializeDependents(StreamWriter writer, List<ScraperDependent> deps, string table)
    {
        await FormatHeader(writer, "Dependents", table, "###");

        await writer.WriteLineAsync(
            $"**Dependent Table** refers to the table that defines a foreign key mapping to {table}."
        );
        
        await writer.WriteLineAsync();

        await writer.WriteLineAsync(
            $"**Dependency Key Column** is the column in {table} that maps to **Foreign Key Column** in **Dependent Table**."
        );

        await writer.WriteLineAsync();

        if (deps.Count > 0)
        {
            await writer.WriteLineAsync(
                "Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column"
            );

            await writer.WriteLineAsync(
                "----------------|------------------|--------------------|----------------------"
            );
        }
        else
            await writer.WriteLineAsync(
                "No dependencies defined"
            );
    }

    static string WriteDependent(ScraperDependent dep, string table) =>
        $"{FormatTableLink(dep.DependentTable, table)} | **{dep.ForeignKeyName}** | `{dep.ForeignKeyColumn}` | `{dep.DependencyKey}`";

    #endregion

    #endregion

    #region Maps

    async Task GenerateMaps(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating dependency map metadata {table}");
        bool hasMaps = (await query.MapDependencies(table)).Count != 0;
        await InitializeMaps(writer, table, hasMaps);

        if (hasMaps)
            await GenerateDistinctMap(writer, table, [ table ]);
    }

    static async Task InitializeMaps(StreamWriter writer, string table, bool hasMaps)
    {
        await FormatHeader(writer, "Dependency Map", table);

        if (hasMaps)
        {
            await writer.WriteLineAsync(
                $"> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table {table}."
            );
            await writer.WriteLineAsync();
        }
        else
        {
            await writer.WriteLineAsync(
                $"{table} has no dependencies."
            );
        }
    }

    async Task GenerateDistinctMap(StreamWriter writer, string table, IEnumerable<string> tables)
    {
        List<string> maps = await query.MapDependencies(table);
        maps = maps.Where(x => !tables.Contains(x)).ToList();
        tables = tables.Concat(maps);

        foreach (string map in maps)
        {
            await writer.WriteLineAsync($"* {FormatLink(map)}");

            await GenerateDistinctMap(
                writer,
                map,
                tables
            );
        }
    }

    #endregion

    #region Utility
    
    static async Task FormatHeader(StreamWriter writer, string header, string table, string level = "##")
    {
        await writer.WriteLineAsync($"{level} {header}");
        await writer.WriteLineAsync($"[Back to Top](#{table.ToLower()})");
        await writer.WriteLineAsync();
    }

    static string FormatLink(string table, string prefix = "./") =>
        $"[{table}]({prefix}{table}.md)";

    static string FormatTableLink(string reference, string table) =>
        reference.Equals(table, StringComparison.CurrentCultureIgnoreCase)
            ? reference
            : FormatLink(reference);

    StreamWriter InitializeDocument(string name, string? subdir = null)
    {
        string path = subdir is null
            ? root.FullName
            : Path.Join(root.FullName, subdir);

        DirectoryInfo dir = new(path);

        if (!dir.Exists)
            Directory.CreateDirectory(dir.FullName);

        string md = Path.Join(path, name);

        return File.CreateText(md);
    }

    void InitializeRoot()
    {
        if (root.Exists)
        {
            foreach (FileInfo file in root.EnumerateFiles())
                file.Delete();

            foreach (DirectoryInfo dir in root.EnumerateDirectories())
                dir.Delete(true);
        }
        else
            Directory.CreateDirectory(root.FullName);
    }

    #endregion
}