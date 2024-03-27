# Sales.SalesPersonQuotaHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalespersonquotahistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**QuotaDate** | `datetime` | False
**SalesQuota** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalespersonquotahistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesPersonQuotaHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesPersonQuotaHistory`.

### Dependencies
[Back to Top](#salessalespersonquotahistory)


**Table** refers to the table that the foreign key defined by `Sales.SalesPersonQuotaHistory` maps to.

**Foreign Key** is the column in `Sales.SalesPersonQuotaHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesPerson](./SalesPerson.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID**

### Dependents
[Back to Top](#salessalespersonquotahistory)

No dependencies defined

## Maps
[Back to Top](#salessalespersonquotahistory)

### Dependency Map
[Back to Top](#salessalespersonquotahistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesPersonQuotaHistory.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.Person](../Person/Person.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [Sales.SalesTerritory](./SalesTerritory.md)

### Dependent Map
[Back to Top](#salessalespersonquotahistory)

Sales.SalesPersonQuotaHistory has no dependents

