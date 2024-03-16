using System.CommandLine;

namespace SchemaScraper.Cli;
public abstract class ConnectorCommand : CliCommand
{
    private readonly List<Option> connectorOptions = [
        new Option<string?>(
            aliases: ["--key", "-k"],
            description: "Database connection configuration key in the JSON connections file, specified with --connections."
        ),
        new Option<string?>(
            aliases: ["--server", "-s"],
            description: "SQL server name. If used, --database is required."
        ),
        new Option<string?>(
            aliases: ["--database", "--db", "-d"],
            description: "SQL database name. If used, --server is required."
        ),
        new Option<FileInfo>(
            aliases: ["--connections", "-c"],
            description: "SQL connection configuration JSON file.",
            getDefaultValue: () => new FileInfo("./connections.json")
        )
    ];

    public ConnectorCommand(string name, string description, Delegate? @delegate = null, List<Option>? options = null) : base(name, description, @delegate, options)
    {
        this.options = this.options is null
            ? connectorOptions
            : [.. this.options, .. connectorOptions];
    }
}