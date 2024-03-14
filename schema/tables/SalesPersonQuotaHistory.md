# SalesPersonQuotaHistory

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salespersonquotahistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**QuotaDate** | `datetime` | False
**SalesQuota** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salespersonquotahistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesPersonQuotaHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesPersonQuotaHistory`.

### Dependencies
[Back to Top](#salespersonquotahistory)

**Dependency Table** refers to the table that the foreign key defined by `SalesPersonQuotaHistory` maps to.

**Foreign Key Column** is the column in `SalesPersonQuotaHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID** | `BusinessEntityID` | [SalesPerson](./SalesPerson.md) | `BusinessEntityID`

### Dependents
[Back to Top](#salespersonquotahistory)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesPersonQuotaHistory.

**Dependency Key Column** is the column in SalesPersonQuotaHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#salespersonquotahistory)

SalesPersonQuotaHistory has no dependencies.
