using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class GenerateCommand()
: ConnectorCommand(
    "generate",
    "Scrape and generate schema metadata documentation in markdown format.",
    new Func<string, string?, string?, string?, FileInfo, Task>(Call),
    [
        new Option<string?>(
            aliases: ["--root", "-r"],
            description: "Root directory to generate schema metadata documentation."
        )
    ]
)
{
    static async Task Call(
        string? root, string? key, string? server, string? db, FileInfo connections
    )
    {
        Connector connector = Connector.Generate(key, server, db, connections);
        string path = Path.Join("..", root ?? key ?? db);        
        ScraperWriter writer = new(path, connector);
        await writer.GenerateTables(writer.GenerateTable);
    }
}