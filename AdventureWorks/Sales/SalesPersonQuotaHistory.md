# Sales.SalesPersonQuotaHistory

**Schema**: Sales
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
* **Dependencies** - foreign key relationships defined by `Sales.SalesPersonQuotaHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesPersonQuotaHistory`.

### Dependencies
[Back to Top](#salespersonquotahistory)


**Table** refers to the table that the foreign key defined by `Sales.SalesPersonQuotaHistory` maps to.

**Foreign Key** is the column in `Sales.SalesPersonQuotaHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesPerson](./SalesPerson.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID**

### Dependents
[Back to Top](#salespersonquotahistory)

No dependencies defined

## Maps
[Back to Top](#salespersonquotahistory)

### Dependency Map
[Back to Top](#salespersonquotahistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesPersonQuotaHistory.

* [Sales.SalesPerson](./SalesPerson.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salespersonquotahistory)

SalesPersonQuotaHistory has no dependents
