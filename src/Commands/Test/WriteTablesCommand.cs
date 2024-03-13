using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;

namespace SchemaScraper.Commands;
public class WriteTablesCommand()
: CliCommand(
    "writetables",
    "Test out writing table metadata to a Markdown file",
    new Func<string, Task>(Call),
    [
        new Option<string>(
            aliases: ["--root", "-r"],
            description: "Root directory to generate schema metadata",
            getDefaultValue: () => Path.Join("..", "test")
        )
    ]
)
{
    static async Task Call(string root)
    {
        ScraperQuery query = new("Crm");
        List<ScraperTable> tables = await query.GetTables();

        if (Path.Exists(root))
        {
            DirectoryInfo dir = new(root);

            foreach (FileInfo file in dir.EnumerateFiles())
                file.Delete();

            foreach (DirectoryInfo d in dir.EnumerateDirectories())
                d.Delete();
        }
        else Directory.CreateDirectory(root);

        string md = Path.Join(root, "tables.md");

        using StreamWriter writer = File.CreateText(md);

        await writer.WriteLineAsync("# Tables");
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("Table | RecordCount");
        await writer.WriteLineAsync("------|------------");

        foreach (ScraperTable table in tables)
            await writer.WriteLineAsync(
                $"{FormatLink(table.Table)} | {table.RecordCount}"
            );
    }

    static string FormatLink(string table) =>
        $"[{table}](./tables/{table}.md)";
}