using Microsoft.Data.SqlClient;

namespace SchemaScraper.Sql;
public record ConnectorConfig(
    string DataSource,
    string InitialCatalog,
    string? UserId = null,
    string? Password = null,
    bool IntegratedSecurity = true,
    bool TrustServerCertificate = true,
    int ConnectRetryCount = 3,
    int ConnectRetryInterval = 10
)
{
    public string DataSource { get; set; } = DataSource;
    public string InitialCatalog { get; set; } = InitialCatalog;
    public string? UserID { get; set; } = UserId;
    public string? Password { get; set; } = Password;
    public bool IntegratedSecurity { get; set; } = IntegratedSecurity;
    public bool TrustServerCertificate { get; set; } = TrustServerCertificate;
    public int ConnectRetryCount { get; set; } = ConnectRetryCount;
    public int ConnectRetryInterval { get; set; } = ConnectRetryInterval;

    public string ToConnectionString()
    {
        SqlConnectionStringBuilder builder = new()
        {
            DataSource = DataSource,
            InitialCatalog = InitialCatalog,
            IntegratedSecurity = IntegratedSecurity,
            TrustServerCertificate = TrustServerCertificate,
            ConnectRetryCount = ConnectRetryCount,
            ConnectRetryInterval = ConnectRetryInterval
        };

        if (UserID is not null && Password is not null)
        {
            builder.UserID = UserId;
            builder.Password = Password;
        }

        return builder.ConnectionString;
    }
}