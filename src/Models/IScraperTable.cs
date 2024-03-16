namespace SchemaScraper.Models;
public interface IScraperTable
{
    public string Schema { get; set; }
    public string Table { get; set; }
}