# Sales.SalesTerritoryHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesterritoryhistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**TerritoryID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesterritoryhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesTerritoryHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesTerritoryHistory`.

### Dependencies
[Back to Top](#salessalesterritoryhistory)


**Table** refers to the table that the foreign key defined by `Sales.SalesTerritoryHistory` maps to.

**Foreign Key** is the column in `Sales.SalesTerritoryHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesPerson](./SalesPerson.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID**
[Sales.SalesTerritory](./SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_SalesTerritoryHistory_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#salessalesterritoryhistory)

No dependencies defined

## Maps
[Back to Top](#salessalesterritoryhistory)

### Dependency Map
[Back to Top](#salessalesterritoryhistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesTerritoryHistory.

* [Sales.SalesPerson](./SalesPerson.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salessalesterritoryhistory)

Sales.SalesTerritoryHistory has no dependents
