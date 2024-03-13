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

    public async Task<List<ScraperTable>> GetTables()
    {
        string tableQuery = await Connector.GetQuery(
            Queries.TableQuery
        );

        return await connector.Query<ScraperTable>(tableQuery);
    }

    public async Task<List<ScraperColumn>> GetColumns(string table) =>
        await BuildGet<ScraperColumn>(table, Queries.ColumnQuery);

    public async Task<List<string>> GetMaps(string table) =>
        await BuildGet<string>(table, Queries.MapQuery);

    public async Task<List<ScraperRelationship>> GetRelationships(string table) =>
        await BuildGet<ScraperRelationship>(table, Queries.RelationshipQuery);

    async Task<List<T>> BuildGet<T>(string table, string file)
    {
        string query = (await Connector.GetQuery(file)).Replace(TABLENAME, table);
        return await connector.Query<T>(query);
    }
}