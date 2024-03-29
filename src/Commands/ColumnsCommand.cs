using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class ColumnsCommand()
: ConnectorCommand(
    "columns",
    "Scrape and output table columns.",
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
        List<ScraperColumn> columns = await query.QueryColumns(table);
        Console.WriteLine("Column, Type, IsNullable");
        columns.ForEach(x => Console.WriteLine($"{x.Column}, {x.Type}, {x.IsNullable}"));
    }
}