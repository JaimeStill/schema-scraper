# Sales.SalesReason

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesreason)

Column | Type | Is Nullable
-------|------|------------
**SalesReasonID** | `int` | False
**Name** | `nvarchar` | False
**ReasonType** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesReason`.

### Dependencies
[Back to Top](#salessalesreason)


No dependencies defined

### Dependents
[Back to Top](#salessalesreason)

**Table** refers to the table that defines a foreign key mapping to Sales.SalesReason.

**Primary Key** is the column in Sales.SalesReason that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md) | `SalesReasonID` | `SalesReasonID` | **FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID**

## Maps
[Back to Top](#salessalesreason)

### Dependency Map
[Back to Top](#salessalesreason)

Sales.SalesReason has no dependencies
### Dependent Map
[Back to Top](#salessalesreason)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.SalesReason as a foreign key dependency.

* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
