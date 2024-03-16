using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class TablesCommand()
: ConnectorCommand(
    "tables",
    "Scrape and output database tables",
    new Func<string?, string?, string?, Task>(Call)
)
{
    static async Task Call(string? connection, string? server, string? db)
    {
        Connector connector = Connector.Generate(connection, server, db);
        ScraperQuery query = new(connector);
        List<ScraperTable> tables = await query.QueryTables();
        Console.WriteLine("Table, RecordCount");
        tables.ForEach(table => Console.WriteLine($"{table}, {table.RecordCount}"));
    }    
}