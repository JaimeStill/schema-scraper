using System.CommandLine;
using SchemaScraper.Cli;
using SchemaScraper.Models;
using SchemaScraper.Services;
using SchemaScraper.Sql;

namespace SchemaScraper.Commands;
public class RelationshipsCommand()
: ConnectorCommand(
    "relationships",
    "Scrape and output table relationships.",
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
        List<ScraperRelationship> dependencies = await query.QueryDependencies(table);
        List<ScraperRelationship> dependents = await query.QueryDependents(table);
        Console.WriteLine("Table, PrimaryKey, ForeignKey, ForeignKeyName, IsDependency");
        dependencies.ForEach(x => Console.WriteLine(FormatRelationship(x, true)));
        dependents.ForEach(x => Console.WriteLine(FormatRelationship(x)));
    }

    static string FormatRelationship(ScraperRelationship rel, bool isDependency = false) =>
        $"{rel.Schema}.{rel.Table}, {rel.PrimaryKey}, {rel.ForeignKey}, {rel.ForeignKeyName}, {isDependency}";
}