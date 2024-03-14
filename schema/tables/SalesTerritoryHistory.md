# SalesTerritoryHistory

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesterritoryhistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**TerritoryID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesterritoryhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesTerritoryHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesTerritoryHistory`.

### Dependencies
[Back to Top](#salesterritoryhistory)

**Dependency Table** refers to the table that the foreign key defined by `SalesTerritoryHistory` maps to.

**Foreign Key Column** is the column in `SalesTerritoryHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID** | `BusinessEntityID` | [SalesPerson](./SalesPerson.md) | `BusinessEntityID`
**FK_SalesTerritoryHistory_SalesTerritory_TerritoryID** | `TerritoryID` | [SalesTerritory](./SalesTerritory.md) | `TerritoryID`

### Dependents
[Back to Top](#salesterritoryhistory)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesTerritoryHistory.

**Dependency Key Column** is the column in SalesTerritoryHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#salesterritoryhistory)

SalesTerritoryHistory has no dependencies.
