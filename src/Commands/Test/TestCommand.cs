using SchemaScraper.Cli;

namespace SchemaScraper.Commands;
public class TestCommand : CliCommand
{
    public TestCommand() : base(
        "test",
        "Test out command infrastructure",
        commands: [
            new MapCommand(),
            new QueryCommand(),
            new WriteTablesCommand()
        ]
    ) { }
}