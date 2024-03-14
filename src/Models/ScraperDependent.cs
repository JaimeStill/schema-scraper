namespace SchemaScraper.Models;
public class ScraperDependent
{
    public string DependentTable { get; set; } = string.Empty;
    public string ForeignKeyName { get; set; } = string.Empty;
    public string ForeignKeyColumn { get; set; } = string.Empty;
    public string DependencyKey { get; set; } = string.Empty;
}