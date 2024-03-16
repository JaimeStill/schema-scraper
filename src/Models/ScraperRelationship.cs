namespace SchemaScraper.Models;
public class ScraperRelationship : IScraperTable
{
    public string Schema { get; set; } = string.Empty;
    public string Table { get; set; } = string.Empty;
    public string ForeignKeyName { get; set; } = string.Empty;
    public string ForeignKey { get; set; } = string.Empty;
    public string PrimaryKey { get; set; } = string.Empty;
}