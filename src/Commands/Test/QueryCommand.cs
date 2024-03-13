using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;

namespace SchemaScraper.Commands;
public class QueryCommand()
: CliCommand(
    "query",
    "Test out querying with Dapper SQL Connector",
    new Func<Task>(Call)
)
{
    static async Task Call()
    {
        ScraperQuery query = new("AdventureWorks");
        List<ScraperTable> tables = await query.GetTables();

        tables.ForEach(t => Console.WriteLine($"{t.Table} - {t.RecordCount}"));
    }
}