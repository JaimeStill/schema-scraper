using SchemaScraper.Cli;
using SchemaScraper.Test.Commands;

await new CliApp(
    "SQL Schema Scraper Test",
    [
        new TestCommand()
    ]
).InvokeAsync(args);