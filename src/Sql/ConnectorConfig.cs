namespace SchemaScraper.Sql;
public record ConnectorConfig(string Server, string Database)
{
    public string Server { get; set; } = Server;
    public string Database { get; set; } = Database;
}