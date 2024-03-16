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

    public Connector(string key, FileInfo sources)
    {
        IConfiguration builder = new ConfigurationBuilder()
          .AddJsonFile(sources.FullName)
          .AddEnvironmentVariables()
          .Build();

        config = builder
          .GetRequiredSection(key)
          .Get<ConnectorConfig>()
        ?? throw new Exception($"No connector configuration was found for {key}");
    }

    public override string ToString() => $"{config.DataSource}:{config.InitialCatalog}";

    public static Connector Generate(string? key, string? server, string? db, FileInfo sources)
    {
        if (key is not null)
            return new(key, sources);
        else if (server is not null && db is not null)
            return new(server, db);
        else
            throw new Exception("To initialize a SQL connection, you must either provide a configuration key and path to the JSON configuration or a SQL server name and SQL database name");
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
        using SqlConnection connection = BuildConnection(config);
        await connection.OpenAsync();
        IEnumerable<T> result = await connection.QueryAsync<T>(query);

        return result.ToList();
    }

    protected static SqlConnection BuildConnection(ConnectorConfig config)
    {
        string connection = config.ToConnectionString();
        Console.WriteLine($"Creating connection on {connection}");
        return new(connection);
    }
}