using SchemaScraper.Cli;

namespace SchemaScraper.Commands;
public class SchemaCommand : CliCommand
{
    public SchemaCommand() : base(
        "schema",
        "Scrape the schema for the specified connection",
        commands: [
            new GenerateCommand()
        ]
    ) { }
}