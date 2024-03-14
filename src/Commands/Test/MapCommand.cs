using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Services;

namespace SchemaScraper.Commands;
public class MapCommand()
: CliCommand(
    "map",
    "Test out recursive dependency mapping",
    new Func<string, Task>(Call),
    [
        new Option<string>(
            aliases: ["--table", "-t"],
            description: "The table to use for map testing"
        )
    ]
)
{
    static async Task Call(string table)
    {
        ScraperQuery query = new("Crm");
        List<string> tables = [ table ];
        await MapDistinct(query, table, tables);
    }

    static async Task MapDistinct(
        ScraperQuery query,
        string table,
        IEnumerable<string> tables,
        int iter = 0
    )
    {
        Console.WriteLine($"{new(' ', iter * 2)}{table}");

        IEnumerable<string> maps = await query.MapDependencies(table);
        maps = maps.Where(x => !tables.Contains(x)).ToList();
        tables = tables.Concat(maps);

        foreach (string map in maps)
        {
            await MapDistinct(
                query,
                map,
                tables,
                ++iter
            );
        }
    }

    static async Task MapDistinctPerLeg(
        ScraperQuery query,
        string table,
        IEnumerable<string> tables,
        int iter = 0
    )
    {
        Console.WriteLine($"{new(' ', iter * 2)}{table}");
        IEnumerable<string> maps = await query.MapDependencies(table);

        foreach (string map in maps.Where(x => !tables.Contains(x)))
        {
            await MapDistinctPerLeg(
                query,
                map,
                tables.Concat([map]),
                ++iter
            );
        }
    }
}