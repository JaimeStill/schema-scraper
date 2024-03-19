using SchemaScraper.Models;
using SchemaScraper.Sql;

namespace SchemaScraper.Services;
public class ScraperWriter(string root, Connector connector)
{
    readonly DirectoryInfo root = new(root);
    readonly ScraperQuery query = new(connector);

    #region Tables

    public async Task GenerateTables(Func<ScraperTable, Task>? action)
    {
        ConsoleColor foreground = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Generating schema metadata for {connector} in directory {root.FullName}");
        Console.ForegroundColor = ConsoleColor.Gray;

        try
        {
            InitializeRoot();
            List<ScraperTable> tables = await query.QueryTables();

            using StreamWriter writer = InitializeDocument("readme.md");
            InitializeTables(writer);

            foreach (ScraperTable table in tables)
            {
                writer.WriteLine(
                    $"{FormatLink(table)} | {table.RecordCount}"
                );

                if (action is not null)
                    await action(table);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Schema metadata generation complete");

        }
        finally
        {
            Console.ForegroundColor = foreground;
        }
    }

    static void InitializeTables(StreamWriter writer)
    {
        writer.WriteLine("# Tables");
        writer.WriteLine();
        writer.WriteLine("Table | RecordCount");
        writer.WriteLine("------|------------");
    }

    #endregion

    #region Table

    public async Task GenerateTable(ScraperTable table)
    {
        Console.WriteLine($"Generating table metadata for {table}");

        using StreamWriter writer = InitializeDocument($"{table.Table}.md", table.Schema);
        InitializeTable(writer, table);
        await GenerateColumns(writer, table);
        await GenerateRelationships(writer, table);
        await GenerateMaps(writer, table);
    }

    static void InitializeTable(StreamWriter writer, ScraperTable table)
    {
        writer.WriteLine($"# {table}");
        writer.WriteLine();
        writer.WriteLine("* [Columns](#columns)");
        writer.WriteLine("* [Relationships](#relationships)");
        writer.WriteLine("    * [Dependencies](#dependencies)");
        writer.WriteLine("    * [Dependents](#dependents)");
        writer.WriteLine("* [Maps](#maps)");
        writer.WriteLine("    * [Dependency Map](#dependency-map)");
        writer.WriteLine("    * [Dependent Map](#dependent-map)");
        writer.WriteLine();
    }

    #endregion

    #region Columns

    async Task GenerateColumns(StreamWriter writer, ScraperTable table)
    {
        Console.WriteLine($"Generating column metadata for {table}");

        List<ScraperColumn> columns = await query.QueryColumns(table.Table);
        InitializeColumns(writer, table, columns);

        foreach (ScraperColumn column in columns)
            writer.WriteLine(
                $"**{column.Column}** | `{column.Type}` | {column.IsNullable}"
            );

        writer.WriteLine();
    }

    static void InitializeColumns(StreamWriter writer, ScraperTable table, List<ScraperColumn> columns)
    {
        FormatHeader(writer, "Columns", table);

        if (columns.Count > 0)
        {
            writer.WriteLine(
                "Column | Type | Is Nullable"
            );

            writer.WriteLine(
                "-------|------|------------"
            );
        }
        else
            writer.WriteLine(
                "No columns defined"
            );
    }

    #endregion

    #region Relationships

    async Task GenerateRelationships(StreamWriter writer, ScraperTable table)
    {
        Console.WriteLine($"Generating relationship metadata for {table}");
        InitializeRelationships(writer, table);
        await GenerateDependencies(writer, table);
        await GenerateDependents(writer, table);
    }

    static void InitializeRelationships(StreamWriter writer, ScraperTable table)
    {
        FormatHeader(writer, "Relationships", table);
        writer.WriteLine();
        writer.WriteLine(
            "The sections that follow define:"
        );
        writer.WriteLine(
            $"* **Dependencies** - foreign key relationships defined by `{table}`."
        );
        writer.WriteLine(
            $"* **Dependents** - foreign key relationships defined by other tables that reference `{table}`."
        );
        writer.WriteLine();

    }

    static string WriteRow(ScraperRelationship dep, ScraperTable table) =>
        $"{FormatRow(dep, table)} | `{dep.PrimaryKey}` | `{dep.ForeignKey}` | **{dep.ForeignKeyName}**";

    #region Dependencies

    async Task GenerateDependencies(StreamWriter writer, ScraperTable table)
    {
        List<ScraperRelationship> deps = await query.QueryDependencies(table.Table);
        InitializeDependencies(writer, table, deps);

        foreach (ScraperRelationship dep in deps)
            writer.WriteLine(
                WriteRow(dep, table)
            );

        writer.WriteLine();
    }

    static void InitializeDependencies(StreamWriter writer, ScraperTable table, List<ScraperRelationship> deps)
    {
        FormatHeader(writer, "Dependencies", table, "###");

        writer.WriteLine();

        if (deps.Count > 0)
        {
            writer.WriteLine(
                $"**Table** refers to the table that the foreign key defined by `{table}` maps to."
            );

            writer.WriteLine();

            writer.WriteLine(
                $"**Foreign Key** is the column in `{table}` that maps to **Primary Key** in **Table**."
            );

            writer.WriteLine(
                "Table | Primary Key | Foreign Key | Foreign Key Name"
            );

            writer.WriteLine(
                "------|-------------|-------------|-----------------"
            );
        }
        else
            writer.WriteLine(
                "No dependencies defined"
            );
    }

    #endregion

    #region Dependents

    async Task GenerateDependents(StreamWriter writer, ScraperTable table)
    {
        List<ScraperRelationship> deps = await query.QueryDependents(table.Table);
        InitializeDependents(writer, table, deps);

        foreach (ScraperRelationship dep in deps)
            writer.WriteLine(
                WriteRow(dep, table)
            );

        writer.WriteLine();
    }

    static void InitializeDependents(StreamWriter writer, ScraperTable table, List<ScraperRelationship> deps)
    {
        FormatHeader(writer, "Dependents", table, "###");

        if (deps.Count > 0)
        {
            writer.WriteLine(
                $"**Table** refers to the table that defines a foreign key mapping to {table}."
            );

            writer.WriteLine();

            writer.WriteLine(
                $"**Primary Key** is the column in {table} that maps to **Foreign Key** in **Table**."
            );

            writer.WriteLine();

            writer.WriteLine(
                "Table | Primary Key | Foreign Key | Foreign Key Name"
            );

            writer.WriteLine(
                "------|-------------|-------------|-----------------"
            );
        }
        else
            writer.WriteLine(
                "No dependencies defined"
            );
    }

    #endregion

    #endregion

    #region Maps

    async Task GenerateMaps(StreamWriter writer, ScraperTable table)
    {
        Console.WriteLine($"Generating map metadata for {table}");
        FormatHeader(writer, "Maps", table);
        await GenerateDependencyMap(writer, table);
        await GenerateDependentMap(writer, table);
    }

    # region Dependency Map

    async Task GenerateDependencyMap(StreamWriter writer, ScraperTable table)
    {
        bool hasMap = (await query.MapDependencies(table.Table)).Count > 0;
        InitializeDependencyMap(writer, table, hasMap);

        if (hasMap)
            await WriteDependencyMap(writer, table, [table.Table]);
    }

    static void InitializeDependencyMap(StreamWriter writer, ScraperTable table, bool hasMap)
    {
        FormatHeader(writer, "Dependency Map", table, "###");

        if (hasMap)
        {
            writer.WriteLine(
                $"> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table {table}."
            );
            writer.WriteLine();
        }
        else
            writer.WriteLine(
                $"{table} has no dependencies"
            );
    }

    async Task WriteDependencyMap(StreamWriter writer, ScraperTable table, IEnumerable<string> tables)
    {
        List<ScraperTable> map = await query.MapDependencies(table.Table);
        map = map.Where(x => !tables.Contains(x.Table)).ToList();
        tables = tables.Concat(map.Select(x => x.Table));

        foreach (ScraperTable dep in map)
        {
            writer.WriteLine($"* {FormatLink(dep, table)}");

            await WriteDependencyMap(
                writer,
                dep,
                tables
            );
        }
    }

    #endregion

    #region Dependent Map

    async Task GenerateDependentMap(StreamWriter writer, ScraperTable table)
    {
        bool hasMap = (await query.MapDependents(table.Table)).Count > 0;
        InitializeDependentMap(writer, table, hasMap);

        if (hasMap)
            await WriteDependentMap(writer, table, [table.Table]);
    }

    static void InitializeDependentMap(StreamWriter writer, ScraperTable table, bool hasMap)
    {
        FormatHeader(writer, "Dependent Map", table, "###");

        if (hasMap)
        {
            writer.WriteLine(
                $"> The following is a distinct list of tables captured by recursively evaluating tables that list {table} as a foreign key dependency."
            );
            writer.WriteLine();
        }
        else
            writer.WriteLine(
                $"{table} has no dependents"
            );
    }

    async Task WriteDependentMap(StreamWriter writer, ScraperTable table, IEnumerable<string> tables)
    {
        List<ScraperTable> map = await query.MapDependents(table.Table);
        map = map.Where(x => !tables.Contains(x.Table)).ToList();
        tables = tables.Concat(map.Select(x => x.Table));

        foreach (ScraperTable dep in map)
        {
            writer.WriteLine($"* {FormatLink(dep, table)}");
            
            await WriteDependentMap(
                writer,
                dep,
                tables
            );
        }
    }

    #endregion

    #endregion

    #region Initialization

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

    #region Formatting

    static void FormatHeader(StreamWriter writer, string header, ScraperTable table, string level = "##")
    {
        writer.WriteLine($"{level} {header}");
        writer.WriteLine($"[Back to Top](#{table.ToString().ToLower().Replace(".", string.Empty)})");
        writer.WriteLine();
    }

    static string FormatLink(string label, string document, string prefix = "./") =>
        $"[{label}]({prefix}{document}.md)";

    static string FormatLink(IScraperTable table) =>
        FormatLink($"{table.Schema}.{table.Table}", table.Table, $"./{table.Schema}/");

    static string FormatLink(IScraperTable table, IScraperTable root)
    {
        string prefix = table.Schema == root.Schema
            ? "./"
            : $"../{table.Schema}/";

        return FormatLink($"{table.Schema}.{table.Table}", table.Table, prefix);
    }

    static string FormatRow(IScraperTable table, IScraperTable root) =>
        table.Table.Equals(root.Table, StringComparison.CurrentCultureIgnoreCase)
            ? table.Table
            : FormatLink(table, root);

    #endregion
}