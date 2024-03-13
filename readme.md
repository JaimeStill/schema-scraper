# Schema Scraper

This repository contains a [Schema Scraping CLI](./src) that allows you to connect to a SQL database and generate metadata documentation for all tables that contain data. The [schema](./schema) directory was generated with:

```pwsh
dotnet run -- schema generate -c "AdventureWorks"
```

This repository is configured to scrape the schema for the [AdventureWorks 2022 Lightweight](https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16&tabs=ssms) database on a local SQL Server instance named `.\DevSql`. 

This generated the [tables.md](./schema/tables.md) document, which contains all of the tables that have data along with the number of records in that table. Each table is linked to the specific metadata document for that table.

Each table metadata document contains three sections:
* **Relationships** - Provides the relationship metadata for the table and links to dependent tables.
* **Columns** - Provides the column metadata for the table.
* **Dependency Map** - Provides the dependency map metadata for the table. This data is acquired by recursively analyzing the foreign key dependency map for the table.