using SchemaScraper.Cli;
using SchemaScraper.Commands;

await new CliApp(
    "SQL Schema Scraper",
    [
        new ColumnsCommand(),
        new GenerateCommand(),
        new MapsCommand(),
        new RelationshipsCommand(),
        new TablesCommand()
    ]
).InvokeAsync(args);