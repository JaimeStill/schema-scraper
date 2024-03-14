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

    public ScraperQuery(string key)
    {
        connector = new(key);
    }

    public ScraperQuery(string server, string db)
    {
        connector = new(server, db);
    }

    public async Task<List<string>> MapDependencies(string table) =>
        await Query<string>(table, Queries.MapDependencies);

    public async Task<List<string>> MapDependents(string table) =>
        await Query<string>(table, Queries.MapDependents);

    public async Task<List<ScraperColumn>> QueryColumns(string table) =>
        await Query<ScraperColumn>(table, Queries.QueryColumns);

    public async Task<List<ScraperDependency>> QueryDependencies(string table) =>
        await Query<ScraperDependency>(table, Queries.QueryDependencies);

    public async Task<List<ScraperDependent>> QueryDependents(string table) =>
        await Query<ScraperDependent>(table, Queries.QueryDependents);

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