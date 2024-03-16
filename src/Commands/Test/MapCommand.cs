using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
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
        ScraperQuery query = new("AdventureWorks");
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

        IEnumerable<ScraperTable> maps = await query.MapDependencies(table);
        maps = maps.Where(x => !tables.Contains(x.Table)).ToList();
        tables = tables.Concat(maps.Select(x => x.Table));

        foreach (ScraperTable map in maps)
        {
            await MapDistinct(
                query,
                map.Table,
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
        IEnumerable<ScraperTable> maps = await query.MapDependencies(table);

        foreach (ScraperTable map in maps.Where(x => !tables.Contains(x.Table)))
        {
            await MapDistinctPerLeg(
                query,
                map.Table,
                tables.Concat([map.Table]),
                ++iter
            );
        }
    }
}