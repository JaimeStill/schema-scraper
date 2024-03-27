# Schema Scraper

* [Schema Scraper CLI](#schema-scraper-cli)
    * [Run the CLI](#run-the-cli)
    * [Commands](#commands)
        * [Columns](#columns)
        * [Generate](#generate)
        * [Maps](#maps)
        * [Relationships](#relationships)
        * [Tables](#tables)
    * [Configuration](#configuration)
* [Architecture](#architecture)
* [Notes](#notes)

This repository contains a [Schema Scraper CLI](#schemascraper-cli) that allows you to connect to a SQL Server database and generate metadata documentation for all tables that contain data. This repository is configured to scrape the schema for the [AdventureWorks 2022 OLTP](https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16&tabs=ssms) database on a local SQL Server instance named `.\DevSql`. If you want to run the CLI against a different SQL database, just adjust the keys in [*connections.json*](./src/connections.json).

The [*AdventureWorks*](./AdventureWorks) directory was generated from the `src` directory by running:

```pwsh
dotnet run -- generate -k "AdventureWorks"
```

This generated the [*readme.md*](./AdventureWorks/readme.md) document, which contains all of the tables that have data along with the number of records in that table. Each table is linked to the specific metadata document for that table and tables are organized in sub-directories around their schema. For instance `Production.Product` is located at [*AdventureWorks/Production/Product.md*](./AdventureWorks/Production/Product.md).

Each table metadata document contains three sections:
* [**Columns**](./AdventureWorks/Production/Product.md#columns) - Provides the column metadata for the table.
* [**Relationships**](./AdventureWorks/Production/Product.md#relationships) - Provides the relationship metadata for the table broken down into the following sections:
    * [**Dependencies**](./AdventureWorks/Production/Product.md#dependencies) - Provides the foreign key relationships defined on the table.
    * [**Dependents**](./AdventureWorks/Production/Product.md#dpeendents) - Provides the foreign key relationships other tables define against the table.
* [**Maps**](./AdventureWorks/Production/Product.md#maps) - Provides a unique collection of tables that can be mapped to table through a relationship dependency. If you made a database diagram consisting of every table in the database, these would be all of the tables that you could trace to this table through diagram connections. It is broken down into the following sections:
    * [**Dependency Map**](./AdventureWorks/Production/Product.md#dependency-map) - Recursively analyzes the foreign key dependencies defined by the table to identify all tables that can be mapped through those relationships.
    * [**Dependent Map**](./AdventureWorks/Production/Product.md#dependent-map) - Recursively analyzes the foreign key dependencies defined by tables that point to the table to identify all tables that can be mapped through those relationships.

## Schema Scraper CLI
[Back to Top](#schema-scraper)

The [*src*](./src) directory contains the `schemascraper` CLI tool. The sections that guide you through using the tool.

### Run the CLI
[Back to Top](#schema-scraper)

To run the CLI tool, you will need access to a SQL database on a machine with the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.

Open a terminal pointed to the *src* directory.

Commands can be executed as follows:

```powershell
dotnet run -- [command] [options]

# example
dotnet run -- generate -k "AdventureWorks"
```

### Commands
[Back to Top](#schema-scraper)

Every command has the following options:

Option | Type | Description
-------|------|------------
**--key<br />-k** | `string?` | Database connection configuration key in the JSON connections file, specified with **--connections**.
**--server<br />-s** | `string?` | SQL server name. If used, **--database** is required.
**--database**<br />**--db**<br />**-d** | `string?` | SQL database name. If used, **--server** is required.
**--connections<br />-c** | `FileInfo` | SQL connection configuration JSON file. Default value is `./connections.json`.

#### Columns
[Back to Top](#schema-scraper)

Scrape and output table columns.

Option | Type | Description
-------|------|------------
**--table<br />-t** | `string` | SQL database table.

**Example**  

```powershell
dotnet run -- columns -t "Product" -k "AdventureWorks"
```

**Output**

```csv
Column, Type, IsNullable
ProductID, int, False
Name, nvarchar, False
ProductNumber, nvarchar, False
MakeFlag, bit, False
FinishedGoodsFlag, bit, False
Color, nvarchar, True
SafetyStockLevel, smallint, False
ReorderPoint, smallint, False
StandardCost, money, False
ListPrice, money, False
Size, nvarchar, True
SizeUnitMeasureCode, nchar, True
WeightUnitMeasureCode, nchar, True
Weight, decimal, True
DaysToManufacture, int, False
ProductLine, nchar, True
Class, nchar, True
Style, nchar, True
ProductSubcategoryID, int, True
ProductModelID, int, True
SellStartDate, datetime, False
SellEndDate, datetime, True
DiscontinuedDate, datetime, True
rowguid, uniqueidentifier, False
ModifiedDate, datetime, False
```

#### Generate
[Back to Top](#schema-scraper)

Scrape and generate schema metadata documentation in markdown format.

Option | Type | Description
-------|------|------------
**--root<br />-r** | `string?` | Root directory to generate schema metadata documentation. If not provided, defaults to the value provided through the **--key** option. If the key value is null, will use the value provided through the **--database** option.

**Example**

```pwsh
dotnet run -- generate -k "AdventureWorks"
```

The [AdventureWorks](./AdventureWorks/) directory is an example of the output this command generates.

#### Maps
[Back to Top](#schema-scraper)

Scrape and output recursive relationship maps for a table.

Option | Type | Description
-------|------|------------
**--table<br />-t** | `string` | SQL database table.

**Example**

```pwsh
dotnet run -- maps -t "Product" -k "AdventureWorks"
```

**Output**

```csv
Table, IsDependency
Production.ProductModel, True
Production.ProductSubcategory, True
Production.UnitMeasure, True
Production.BillOfMaterials, False
Production.ProductCostHistory, False
Production.ProductDocument, False
Production.ProductInventory, False
Production.ProductListPriceHistory, False
Production.ProductProductPhoto, False
Production.ProductReview, False
Production.TransactionHistory, False
Production.WorkOrder, False
Purchasing.ProductVendor, False
Purchasing.PurchaseOrderDetail, False
Sales.ShoppingCartItem, False
Sales.SpecialOfferProduct, False
```

#### Relationships
[Back to Top](#schema-scraper)

Scrape and output table relationships.

Option | Type | Description
-------|------|------------
**--table<br />-t** | `string` | SQL database table.

**Example**

```pwsh
dotnet run -- relationships -t "Product" -k "AdventureWorks"
```

**Output**

```csv
Table, PrimaryKey, ForeignKey, ForeignKeyName, IsDependency
Production.ProductModel, ProductModelID, ProductModelID, FK_Product_ProductModel_ProductModelID, True
Production.ProductSubcategory, ProductSubcategoryID, ProductSubcategoryID, FK_Product_ProductSubcategory_ProductSubcategoryID, True
Production.UnitMeasure, UnitMeasureCode, SizeUnitMeasureCode, FK_Product_UnitMeasure_SizeUnitMeasureCode, True
Production.UnitMeasure, UnitMeasureCode, WeightUnitMeasureCode, FK_Product_UnitMeasure_WeightUnitMeasureCode, True
Production.BillOfMaterials, ProductID, ProductAssemblyID, FK_BillOfMaterials_Product_ProductAssemblyID, False
Production.BillOfMaterials, ProductID, ComponentID, FK_BillOfMaterials_Product_ComponentID, False
Production.ProductCostHistory, ProductID, ProductID, FK_ProductCostHistory_Product_ProductID, False
Production.ProductDocument, ProductID, ProductID, FK_ProductDocument_Product_ProductID, False
Production.ProductInventory, ProductID, ProductID, FK_ProductInventory_Product_ProductID, False
Production.ProductListPriceHistory, ProductID, ProductID, FK_ProductListPriceHistory_Product_ProductID, False
Production.ProductProductPhoto, ProductID, ProductID, FK_ProductProductPhoto_Product_ProductID, False
Production.ProductReview, ProductID, ProductID, FK_ProductReview_Product_ProductID, False
Production.TransactionHistory, ProductID, ProductID, FK_TransactionHistory_Product_ProductID, False
Production.WorkOrder, ProductID, ProductID, FK_WorkOrder_Product_ProductID, False
Purchasing.ProductVendor, ProductID, ProductID, FK_ProductVendor_Product_ProductID, False
Purchasing.PurchaseOrderDetail, ProductID, ProductID, FK_PurchaseOrderDetail_Product_ProductID, False
Sales.ShoppingCartItem, ProductID, ProductID, FK_ShoppingCartItem_Product_ProductID, False
Sales.SpecialOfferProduct, ProductID, ProductID, FK_SpecialOfferProduct_Product_ProductID, False
```

#### Tables
[Back to Top](#schema-scraper)

Scrape and output database tables and their record count.

**Example**

```pwsh
dotnet run -- tables -k "AdventureWorks"
```

**Output**

```csv
Table, RecordCount
dbo.AWBuildVersion, 1
dbo.DatabaseLog, 1596
HumanResources.Department, 16
HumanResources.Employee, 290
HumanResources.EmployeeDepartmentHistory, 296
HumanResources.EmployeePayHistory, 316
HumanResources.JobCandidate, 13
HumanResources.Shift, 3
Person.Address, 19614
Person.AddressType, 6
Person.BusinessEntity, 20777
Person.BusinessEntityAddress, 19614
Person.BusinessEntityContact, 909
Person.ContactType, 20
Person.CountryRegion, 238
Person.EmailAddress, 19972
Person.Password, 19972
Person.Person, 19972
Person.PersonPhone, 19972
Person.PhoneNumberType, 3
Person.StateProvince, 181
Production.BillOfMaterials, 2679
Production.Culture, 8
Production.Document, 13
Production.Illustration, 5
Production.Location, 14
Production.Product, 504
Production.ProductCategory, 4
Production.ProductCostHistory, 395
Production.ProductDescription, 762
Production.ProductDocument, 32
Production.ProductInventory, 1069
Production.ProductListPriceHistory, 395
Production.ProductModel, 128
Production.ProductModelIllustration, 7
Production.ProductModelProductDescriptionCulture, 762
Production.ProductPhoto, 101
Production.ProductProductPhoto, 504
Production.ProductReview, 4
Production.ProductSubcategory, 37
Production.ScrapReason, 16
Production.TransactionHistory, 113443
Production.TransactionHistoryArchive, 89253
Production.UnitMeasure, 38
Production.WorkOrder, 72591
Production.WorkOrderRouting, 67131
Purchasing.ProductVendor, 460
Purchasing.PurchaseOrderDetail, 8845
Purchasing.PurchaseOrderHeader, 4012
Purchasing.ShipMethod, 5
Purchasing.Vendor, 104
Sales.CountryRegionCurrency, 109
Sales.CreditCard, 19118
Sales.Currency, 105
Sales.CurrencyRate, 13532
Sales.Customer, 19820
Sales.PersonCreditCard, 19118
Sales.SalesOrderDetail, 121317
Sales.SalesOrderHeader, 31465
Sales.SalesOrderHeaderSalesReason, 27647
Sales.SalesPerson, 17
Sales.SalesPersonQuotaHistory, 163
Sales.SalesReason, 10
Sales.SalesTaxRate, 29
Sales.SalesTerritory, 10
Sales.SalesTerritoryHistory, 17
Sales.ShoppingCartItem, 3
Sales.SpecialOffer, 16
Sales.SpecialOfferProduct, 538
Sales.Store, 701
```

### Configuration
[Back to Top](#schema-scraper)

[**ConnectorConfig**](./src/Sql/ConnectorConfig.cs) schema

Property | Type | Default Value | Required
---------|------|---------------|---------
**DataSource** | `string` | | Yes
**InitialCatalog** | `string` | | Yes
**UserID** | `string?` | null | No
**Password** | `string?` | null | No
**IntegratedSecurity** | `bool` | true | No
**TrustServerCertificate** | `bool` | true | No
**ConnectRetryCount** | `int` | 3 | No
**ConnectRetryInterval** | `int` | 10 | No

These properties map to the [SqlConnectionStringBuilder](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder?view=dotnet-plat-ext-8.0#properties) properties of the same name.

If no `UserID` and `Password` are specified, it is assumed that the current logged in user has access to connect to the configured SQL database.

You can provide configuration to the CLI in two ways:

* Specifying a [JSON configuration file](./src/connections.json):

    ```json
    {
        "AdventureWorks": {
            "DataSource": "SqlDb01",
            "InitialCatalog": "AdventureWorks2022",
            "UserID": "viewer",
            "Password": "Password1234!@#$"
        }
    }
    ```

    The CLI is configured to look for a file named `connections.json` in the location you are executing the command from. If you have a different name / location for your JSON file, specify it with the [`--connections` option](./src/Cli/ConnectorCommand.cs#L19).

* Configuring environment variables:

    Environment variables can be configured in PowerShell as follows:

    ```powershell
    $env:Key__Property = Value

    # example
    $env:AdventureWorks__DataSource = SqlDb01
    $env:AdventureWorks__InitialCatalog = AdventureWorks2022
    $env:AdventureWorks__UserID = viewer
    $env:AdventureWorks__Password = 'Password1234!@#$'
    ```

## Architecture
[Back to Top](#schema-scraper)

The project depends on three libraries:

* [`System.CommandLine`](https://learn.microsoft.com/en-us/dotnet/standard/commandline/) - A library that provides functionality that is commonly needed by command-line apps, such as parsing the command-line input and displaying help text.
* [`Microsoft.Data.SqlClient`](https://github.com/dotnet/SqlClient) - A data provider for Microsoft SQL Server and Azure SQL Database.
* [`Dapper`](https://github.com/DapperLib/Dapper) - A simple object mapper for .NET.

The project is structured as follows:

* [**Cli**](./src/Cli/) - Contains classes that simplify building CLI apps.
    * [`CliApp.cs`](./src/Cli/CliApp.cs) - Standardizes and simplifies the initialization of a `System.CommandLine` app.
    * [`CliCommand.cs`](./src/Cli/CliCommand.cs) - Standardizes and simplifies the creation of a `System.CommandLine` command.
    * [`ConnectorCommand.cs`](./src/Cli/ConnectorCommand.cs) - An abstract class for building commands around a SQL [`Connector`](./src/Sql/Connector.cs).
* [**Commands**](./src/Commands/) - Contains all of the `System.CommandLine` commands for `schemascraper`. For command details, see the [Commands](#commands) section above.
    * [`ColumnsCommand.cs`](./src/Commands/ColumnsCommand.cs)
    * [`GenerateCommand.cs`](./src/Commands/GenerateCommand.cs)
    * [`MapsCommand.cs`](./src/Commands/MapsCommand.cs)
    * [`RelationshipsCommand.cs`](./src/Commands/RelationshipsCommand.cs)
    * [`TablesCommand.cs`](./src/Commands/TablesCommand.cs)
* [**Models**](./src/Models/) - Provides simple data models used for projecting SQL query results.
    * [`IScraperTable.cs`](./src/Models/IScraperTable.cs) - Provides an interface for models that contain `Schema` and `Table` properties, [`ScraperRelationship`](./src/Models/ScraperRelationship.cs) and [`ScraperTable.cs`](./src/Models/ScraperTable.cs).
    * [`ScraperColumn`](./src/Models/ScraperColumn.cs) - Defines table column metadata structure. Used with the [`query-columns.sql`](./queries/query-columns.sql) script executed by [ColumnsCommand](./src/Commands/ColumnsCommand.cs) and [GenerateCommand](./src/Commands/GenerateCommand.cs).
    * [`ScraperRelationship.cs`](./src/Models/ScraperRelationship.cs) - Defines table relationship metadata structure. Used with the [`query-dependencies.sql`](./queries/query-dependencies.sql) and [`query-dependents.sql`](./queries/query-dependents.sql) scripts executed by [GenerateCommand](./src/Commands/GenerateCommand.cs) and [RelationshipsCommand](./src/Commands/RelationshipsCommand.cs).
    * [`ScraperTable.cs`](./src/Models/ScraperTable.cs) - Defines table metadata structure. Used with the [`map-dependencies.sql`](./queries/map-dependencies.sql), [`map-dependents.sql`](./queries/map-dependents.sql), and [`query-tables.sql`](./queries/query-tables.sql) scripts executed by [GenerateCommand](./src/Commands/GenerateCommand.cs), [MapsCommand](./src/Commands/MapsCommand.cs), and [TablesCommand](./src/Commands/TablesCommand.cs).
* [**Services**](./src/Services) - Contains classes that define specific feature functionality.
    * [`ScraperQuery.cs`](./src/Services/ScraperQuery.cs) - Exposes methods for executing SQL queries and returning the results in the proper C# types.
    * [`ScraperWriter.cs`](./src/Services/ScraperWriter.cs) - Handles generating and writing markdown-based metadata documentation.
* [**Sql**](./src/Sql/) - Provides classes that handle interfacing with SQL infrastructure.
    * [`Connector.cs`](./src/Sql/Connector.cs) - Reads and implements SQL connection configuration as well as reading and executing file-based SQL scripts.
    * [`ConnectorConfig.cs`](./src/Sql/ConnectorConfig.cs) - Provides a [`Connector.cs`](./src/Sql/Connector.cs) configuration schema based around the [`SqlConnectionStringBuilder`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlclient.sqlconnectionstringbuilder?view=sqlclient-dotnet-core-5.1) class. See the [Configuration](#configuration) section above for more details.
    * [`Queries.cs`](./src/Sql/Queries.cs) - A static class that defines constant string properties for the SQL scripts [embedded in the CLI project](./src/SchemaScraper.csproj#L22).
* [`connections.json`](./src/connections.json) - A simple JSON [`ConnectorConfig`](./src/Sql/ConnectorConfig.cs) for testing. If you clone this repository, you can replace the values with your own meaningful configurations.
* [`Program.cs`](./src/Program.cs) - Initializes a [`CliApp`](./src/Cli/CliApp.cs) with all of the [Commands](./src/Commands/).
* [`SchemaScraper.csproj`](./src/SchemaScraper.csproj) - .NET project configuration.

## Notes
[Back to Top](#schema-scraper)

Currently the Schema Scraper CLI tool only supports connections to SQL Server. If a need is ever encountered, the [Connector](./src/Sql/Connector.cs) class could be abstracted around multiple providers and their interface libraries, e.g. [Npgsql](https://github.com/npgsql/npgsql) for PostgreSQL. Would need to add additional metadata to [ConnectorConfig](./src/Sql/ConnectorConfig.cs) to indicate the intended provider.