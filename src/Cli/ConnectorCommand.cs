using System.CommandLine;

namespace SchemaScraper.Cli;
public abstract class ConnectorCommand : CliCommand
{
    private readonly List<Option> connectorOptions = [
        new Option<string?>(
                aliases: ["--connection", "-c"],
                description: "connections.json configuration key"
            ),
        new Option<string?>(
            aliases: ["--server", "-s"],
            description: "SQL server name"
        ),
        new Option<string?>(
            aliases: ["--database", "--db", "-d"],
            description: "SQL database name"
        )
    ];

    public ConnectorCommand(string name, string description, Delegate? @delegate = null, List<Option>? options = null) : base(name, description, @delegate, options)
    {
        this.options = this.options is null
            ? connectorOptions
            : [.. this.options, .. connectorOptions];
    }
}