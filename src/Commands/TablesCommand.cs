using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class TablesCommand()
: ConnectorCommand(
    "tables",
    "Scrape and output database tables and their record count.",
    new Func<string?, string?, string?, FileInfo, Task>(Call)
)
{
    static async Task Call(string? key, string? server, string? db, FileInfo connections)
    {
        Connector connector = Connector.Generate(key, server, db, connections);
        ScraperQuery query = new(connector);
        List<ScraperTable> tables = await query.QueryTables();
        Console.WriteLine("Table, RecordCount");
        tables.ForEach(table => Console.WriteLine($"{table}, {table.RecordCount}"));
    }    
}