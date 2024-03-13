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
            List<ScraperTable> tables = await query.GetTables();

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
        await GenerateRelationships(writer, table);
        await GenerateColumns(writer, table);
        await GenerateMaps(writer, table);
    }

    static async Task InitializeTable(StreamWriter writer, string table)
    {
        await writer.WriteLineAsync($"# {table}");
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("* [Relationships](#relationships)");
        await writer.WriteLineAsync("* [Columns](#columns)");
        await writer.WriteLineAsync("* [Dependency Map](#dependency-map)");
        await writer.WriteLineAsync();
    }

    #endregion

    #region Relationships

    async Task GenerateRelationships(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating relationship metadata for {table}");

        List<ScraperRelationship> relationships = await query.GetRelationships(table);
        await InitializeRelationships(writer, relationships, table);

        foreach (ScraperRelationship relationship in relationships)
            await writer.WriteLineAsync(
                WriteRelationshipRow(relationship, table)
            );

        await writer.WriteLineAsync();
    }

    static async Task InitializeRelationships(StreamWriter writer, List<ScraperRelationship> relationships, string table)
    {
        await FormatHeader(writer, "Relationships", table);

        if (relationships.Count > 0)
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
                "No relationships defined"
            );
    }

    static string WriteRelationshipRow(ScraperRelationship relationship, string table) =>
        $"**{relationship.ForeignKeyName}** | `{relationship.ForeignKeyColumn}` | {FormatDependencyTable(relationship.DependencyTable, table)} | `{relationship.DependencyKey}`";

    static string FormatDependencyTable(string dependency, string table) =>
        dependency.Equals(table, StringComparison.CurrentCultureIgnoreCase)
            ? dependency
            : FormatLink(dependency);

    #endregion

    #region Columns

    async Task GenerateColumns(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating column metadata for {table}");

        List<ScraperColumn> columns = await query.GetColumns(table);
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

    #region Maps

    async Task GenerateMaps(StreamWriter writer, string table)
    {
        Console.WriteLine($"Generating dependency map metadata {table}");
        bool hasMaps = (await query.GetMaps(table)).Count != 0;
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
        List<string> maps = await query.GetMaps(table);
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
    
    static async Task FormatHeader(StreamWriter writer, string header, string table)
    {
        await writer.WriteLineAsync($"## {header}");
        await writer.WriteLineAsync($"[Back to Top](#{table.ToLower()})");
        await writer.WriteLineAsync();
    }

    static string FormatLink(string table, string prefix = "./") =>
        $"[{table}]({prefix}{table}.md)";

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