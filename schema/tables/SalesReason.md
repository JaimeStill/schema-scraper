# SalesReason

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
* **Dependencies** - foreign key relationships defined by `SalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesReason`.

### Dependencies
[Back to Top](#salesreason)

**Dependency Table** refers to the table that the foreign key defined by `SalesReason` maps to.

**Foreign Key Column** is the column in `SalesReason` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#salesreason)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesReason.

**Dependency Key Column** is the column in SalesReason that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md) | **FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID** | `SalesReasonID` | `SalesReasonID`

## Dependency Map
[Back to Top](#salesreason)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesReason.

* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
