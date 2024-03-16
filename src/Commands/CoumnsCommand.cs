using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class ColumnsCommand()
: ConnectorCommand(
    "columns",
    "Scrape and output table columns",
    new Func<string, string?, string?, string?, Task>(Call),
    [
        new Option<string>(
            aliases: ["--table", "-t"],
            description: "SQL database table"
        )
    ]
)
{
    static async Task Call(string table, string? connection, string? server, string? db)
    {
        Connector connector = Connector.Generate(connection, server, db);
        ScraperQuery query = new(connector);
        List<ScraperColumn> columns = await query.QueryColumns(table);
        Console.WriteLine("Column, Type, IsNullable");
        columns.ForEach(x => Console.WriteLine($"{x.Column}, {x.Type}, {x.IsNullable}"));
    }
}