# Sales.SalesReason

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesreason)

Column | Type | Is Nullable
-------|------|------------
**SalesReasonID** | `int` | False
**Name** | `nvarchar` | False
**ReasonType** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesReason`.

### Dependencies
[Back to Top](#salesreason)


No dependencies defined

### Dependents
[Back to Top](#salesreason)

**Table** refers to the table that defines a foreign key mapping to SalesReason.

**Primary Key** is the column in SalesReason that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md) | `SalesReasonID` | `SalesReasonID` | **FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID**

## Maps
[Back to Top](#salesreason)

### Dependency Map
[Back to Top](#salesreason)

SalesReason has no dependencies
### Dependent Map
[Back to Top](#salesreason)

> The following is a distinct list of tables captured by recursively evaluating tables that list SalesReason as a foreign key dependency.

* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
