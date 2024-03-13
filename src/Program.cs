using SchemaScraper.Cli;
using SchemaScraper.Commands;

await new CliApp(
    "SQL Schema Scraper",
    [
        new SchemaCommand(),
        new TestCommand()
    ]
).InvokeAsync(args);