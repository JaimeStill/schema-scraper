using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class MapsCommand()
: ConnectorCommand(
    "maps",
    "Scrape and output recursive relationship maps for a table.",
    new Func<string, string?, string?, string?, FileInfo, Task>(Call),
    [
        new Option<string>(
            aliases: ["--table", "-t"],
            description: "SQL database table."
        )
    ]
)
{
    static async Task Call(string table, string? key, string? server, string? db, FileInfo connections)
    {
        Connector connector = Connector.Generate(key, server, db, connections);
        ScraperQuery query = new(connector);
        List<ScraperTable> dependencyMap = await query.MapDependencies(table);
        List<ScraperTable> dependentMap = await query.MapDependents(table);
        Console.WriteLine("Table, IsDependency");
        dependencyMap.ForEach(x => Console.WriteLine($"{x}, {true}"));
        dependentMap.ForEach(x => Console.WriteLine($"{x}, {false}"));
    }
}