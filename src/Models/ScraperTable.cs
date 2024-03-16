namespace SchemaScraper.Models;
public class ScraperTable : IScraperTable
{
    public string Schema { get; set; } = string.Empty;
    public string Table { get; set; } = string.Empty;
    public int RecordCount { get; set; }

    public override string ToString() => $"{Schema}.{Table}";
}