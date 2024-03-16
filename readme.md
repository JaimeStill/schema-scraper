# Schema Scraper

This repository contains a [Schema Scraper CLI](#schemascraper-cli) that allows you to connect to a SQL database and generate metadata documentation for all tables that contain data. This repository is configured to scrape the schema for the [AdventureWorks 2022 OLTP](https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16&tabs=ssms) database on a local SQL Server instance named `.\DevSql`. If you want to run the CLI against a different SQL database, just adjust the keys in [*connections.json*](./src/connections.json).

The [*AdventureWorks*](./AdventureWorks) directory was generated from the `src` directory by running:

```pwsh
dotnet run -- generate -c "AdventureWorks"
```

This generated the [*readme.md*](./AdventureWorks/readme.md) document, which contains all of the tables that have data along with the number of records in that table. Each table is linked to the specific metadata document for that table and tables are organized in sub-directories around their schema. For instance `Production.Product` is located at [*AdventureWorks/Production/Product.md*](./AdventureWorks/Production/Product.md).

Each table metadata document contains three sections:
* [**Columns**](./AdventureWorks/Production/Product.md#columns) - Provides the column metadata for the table.
* [**Relationships**](./AdventureWorks/Production/Product.md#relationships) - Provides the relationship metadata for the table broken down into the following sections:
    * [**Dependencies**](./AdventureWorks/Production/Product.md#dependencies) - Provides the foreign key relationships defined on the table.
    * [**Dependents**](./AdventureWorks/Production/Product.md#dpeendents) - Provides the foreign key relationships other tables define against the table.
* [**Maps**](./AdventureWorks/Production/Product.md#maps) - Provides a unique collection of tables that can be mapped to table through a relationship dependency. It is broken down into the following sections:
    * [**Dependency Map**](./AdventureWorks/Production/Product.md#dependency-map) - Recursively analyzes the foreign key dependencies defined by the table to identify all tables that can be mapped through those relationships.
    * [**Dependent Map**](./AdventureWorks/Production/Product.md#dependent-map) - Recursively analyzes the foreign key dependencies defined by tables that point to the table to identify all tables that can be mapped through those relationships.

## Schema Scraper CLI

The [*src*](./src) directory contains the `schemascraper` CLI tool.
