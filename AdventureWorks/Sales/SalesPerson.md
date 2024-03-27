# Sales.SalesPerson

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesperson)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**TerritoryID** | `int` | True
**SalesQuota** | `money` | True
**Bonus** | `money` | False
**CommissionPct** | `smallmoney` | False
**SalesYTD** | `money` | False
**SalesLastYear** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesperson)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesPerson`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesPerson`.

### Dependencies
[Back to Top](#salessalesperson)


**Table** refers to the table that the foreign key defined by `Sales.SalesPerson` maps to.

**Foreign Key** is the column in `Sales.SalesPerson` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPerson_Employee_BusinessEntityID**
[Sales.SalesTerritory](./SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_SalesPerson_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#salessalesperson)

**Table** refers to the table that defines a foreign key mapping to Sales.SalesPerson.

**Primary Key** is the column in Sales.SalesPerson that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `BusinessEntityID` | `SalesPersonID` | **FK_SalesOrderHeader_SalesPerson_SalesPersonID**
[Sales.SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID**
[Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID**
[Sales.Store](./Store.md) | `BusinessEntityID` | `SalesPersonID` | **FK_Store_SalesPerson_SalesPersonID**

## Maps
[Back to Top](#salessalesperson)

### Dependency Map
[Back to Top](#salessalesperson)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesPerson.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.Person](../Person/Person.md)
* [Sales.SalesTerritory](./SalesTerritory.md)

### Dependent Map
[Back to Top](#salessalesperson)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.SalesPerson as a foreign key dependency.

* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [Sales.Store](./Store.md)

