using System.CommandLine;
using System.CommandLine.NamingConventionBinder;

namespace SchemaScraper.Cli;
public abstract class CliCommand(
    string name,
    string description,
    Delegate? @delegate = null,
    List<Option>? options = null,
    List<CliCommand>? commands = null
)
{
    readonly string name = name;
    readonly string description = description;
    readonly Delegate? @delegate = @delegate;
    readonly List<Option>? options = options;
    readonly List<CliCommand>? commands = commands;

    public Command Build()
    {
        Command command = new(name, description);

        if (@delegate is not null)
            command.Handler = CommandHandler.Create(@delegate);

        options?.ForEach(command.AddOption);

        if (commands?.Count > 0)
            commands
              .Select(c => c.Build())
              .ToList()
              .ForEach(command.AddCommand);

        return command;
    }
}