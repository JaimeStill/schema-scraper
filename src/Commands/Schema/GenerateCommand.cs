using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class GenerateCommand()
: CliCommand(
    "generate",
    "Scrape and generate schema metadata documentation",
    new Func<string, string?, string?, string?, Task>(Call),
    [
        new Option<string>(
            aliases: ["--root", "-r"],
            description: "Root directory to generate schema metadata documentation",
            getDefaultValue: () => Path.Join("..", "schema")
        ),
        new Option<string?>(
            aliases: ["--connection", "-c"],
            description: "connections.json configuration key"
        ),
        new Option<string?>(
            aliases: ["--server", "-s"],
            description: "SQL server name"
        ),
        new Option<string?>(
            aliases: ["--database", "-db", "-d"],
            description: "SQL database name"
        )
    ]
)
{
    static async Task Call(
        string root, string? connection, string? server, string? db
    )
    {
        Connector connector = Connector.Generate(connection, server, db);
        ScraperWriter writer = new(root, connector);
        await writer.GenerateTables(writer.GenerateTable);
    }
}