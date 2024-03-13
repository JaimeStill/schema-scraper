using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SchemaScraper.Sql;
public class Connector
{
    readonly ConnectorConfig config;

    public Connector(string server, string db)
    {
        config = new(server, db);
    }

    public override string ToString() => $"{config.Server}:{config.Database}";

    public Connector(string key)
    {
        IConfiguration builder = new ConfigurationBuilder()
          .AddJsonFile("connections.json")
          .AddEnvironmentVariables()
          .Build();

        config = builder
          .GetRequiredSection(key)
          .Get<ConnectorConfig>()
        ?? throw new Exception($"No connector configuration was found for {key}");
    }

    public static Connector Generate(string? key, string? server, string? db)
    {
        if (key is not null)
            return new(key);
        else if (server is not null && db is not null)
            return new(server, db);
        else
            throw new Exception("To initialize a SQL connection, you must either provide a connection.json key or a SQL server name and SQL database name");
    }

    public static async Task<string> GetQuery(string file) =>
        await File.ReadAllTextAsync(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                file
            )
        );

    public async Task<List<T>> Query<T>(string query)
    {
        using SqlConnection connection = BuildConnection(config.Server, config.Database);
        await connection.OpenAsync();
        IEnumerable<T> result = await connection.QueryAsync<T>(query);

        return result.ToList();
    }

    protected static SqlConnection BuildConnection(string server, string db) =>
      new(
        new SqlConnectionStringBuilder()
        {
            DataSource = server,
            InitialCatalog = db,
            IntegratedSecurity = true,
            TrustServerCertificate = true,
            ConnectRetryCount = 3,
            ConnectRetryInterval = 10
        }.ConnectionString
      );
}