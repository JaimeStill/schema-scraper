using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;

namespace SchemaScraper.Test.Commands;
public class QueryCommand()
: CliCommand(
    "query",
    "Test out querying with Dapper SQL Connector.",
    new Func<FileInfo, Task>(Call),
    [
        new Option<FileInfo>(
            aliases: ["--connections"],
            description: "SQL connection configuration JSON file.",
            getDefaultValue: () => new FileInfo("./connections.json")
        )
    ]
)
{
    static async Task Call(FileInfo connections)
    {
        ScraperQuery query = new("AdventureWorks", connections);
        List<ScraperTable> tables = await query.QueryTables();

        tables.ForEach(t => Console.WriteLine($"{t.Schema}.{t.Table} - {t.RecordCount}"));
    }
}