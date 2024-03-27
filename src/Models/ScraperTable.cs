using System.Diagnostics.CodeAnalysis;

namespace SchemaScraper.Models;
public class ScraperTable : EqualityComparer<ScraperTable>, IScraperTable
{
    public string Schema { get; set; } = string.Empty;
    public string Table { get; set; } = string.Empty;
    public int RecordCount { get; set; }

    public override string ToString() => $"{Schema}.{Table}";

    public override bool Equals(ScraperTable? x, ScraperTable? y)
    {
        if (x is null && y is null)
            return true;

        if (x is null || y is null)
            return false;

        return x.ToString() == y.ToString();
    }

    public override int GetHashCode([DisallowNull] ScraperTable obj) =>
        obj.ToString().GetHashCode();
}