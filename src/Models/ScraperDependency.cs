namespace SchemaScraper.Models;
public class ScraperDependency
{
    public string ForeignKeyName { get; set; } = string.Empty;
    public string ForeignKeyColumn { get; set; } = string.Empty;
    public string DependencyTable { get; set; } = string.Empty;
    public string DependencyKey { get; set; } = string.Empty;
}