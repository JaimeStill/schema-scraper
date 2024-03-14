# SalesOrderHeaderSalesReason

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesorderheadersalesreason)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesReasonID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesorderheadersalesreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesOrderHeaderSalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesOrderHeaderSalesReason`.

### Dependencies
[Back to Top](#salesorderheadersalesreason)

**Dependency Table** refers to the table that the foreign key defined by `SalesOrderHeaderSalesReason` maps to.

**Foreign Key Column** is the column in `SalesOrderHeaderSalesReason` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID** | `SalesOrderID` | [SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID`
**FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID** | `SalesReasonID` | [SalesReason](./SalesReason.md) | `SalesReasonID`

### Dependents
[Back to Top](#salesorderheadersalesreason)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesOrderHeaderSalesReason.

**Dependency Key Column** is the column in SalesOrderHeaderSalesReason that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#salesorderheadersalesreason)

SalesOrderHeaderSalesReason has no dependencies.
