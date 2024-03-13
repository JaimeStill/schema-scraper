namespace SchemaScraper.Models;
public class ScraperColumn
{
    public string Column { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsNullable { get; set; }
}