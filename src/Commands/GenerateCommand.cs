using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class GenerateCommand()
: ConnectorCommand(
    "generate",
    "Scrape and generate schema metadata documentation",
    new Func<string, string?, string?, string?, FileInfo, Task>(Call),
    [
        new Option<string?>(
            aliases: ["--root", "-r"],
            description: "Root directory to generate schema metadata documentation"
        )
    ]
)
{
    static async Task Call(
        string? root, string? connection, string? server, string? db, FileInfo sources
    )
    {
        Connector connector = Connector.Generate(connection, server, db, sources);
        string path = Path.Join("..", root ?? connection ?? db);        
        ScraperWriter writer = new(path, connector);
        await writer.GenerateTables(writer.GenerateTable);
    }
}