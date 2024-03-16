using SchemaScraper.Models;
using SchemaScraper.Sql;

namespace SchemaScraper.Services;
public class ScraperQuery
{
    readonly Connector connector;
    const string TABLENAME = "{{tablename}}";

    public ScraperQuery(Connector connector)
    {
        this.connector = connector;
    }

    public ScraperQuery(string key, FileInfo sources)
    {
        connector = new(key, sources);
    }

    public ScraperQuery(string server, string db)
    {
        connector = new(server, db);
    }

    public async Task<List<ScraperTable>> MapDependencies(string table) =>
        await Query<ScraperTable>(table, Queries.MapDependencies);

    public async Task<List<ScraperTable>> MapDependents(string table) =>
        await Query<ScraperTable>(table, Queries.MapDependents);

    public async Task<List<ScraperColumn>> QueryColumns(string table) =>
        await Query<ScraperColumn>(table, Queries.QueryColumns);

    public async Task<List<ScraperRelationship>> QueryDependencies(string table) =>
        await Query<ScraperRelationship>(table, Queries.QueryDependencies);

    public async Task<List<ScraperRelationship>> QueryDependents(string table) =>
        await Query<ScraperRelationship>(table, Queries.QueryDependents);

    public async Task<List<ScraperTable>> QueryTables()
    {
        string tableQuery = await Connector.GetQuery(
            Queries.QueryTables
        );

        return await connector.Query<ScraperTable>(tableQuery);
    }

    async Task<List<T>> Query<T>(string table, string file)
    {
        string query = (await Connector.GetQuery(file)).Replace(TABLENAME, table);
        return await connector.Query<T>(query);
    }
}