# Sales.SalesPerson

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesperson)

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
[Back to Top](#salesperson)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesPerson`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesPerson`.

### Dependencies
[Back to Top](#salesperson)


**Table** refers to the table that the foreign key defined by `Sales.SalesPerson` maps to.

**Foreign Key** is the column in `Sales.SalesPerson` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPerson_Employee_BusinessEntityID**
[Sales.SalesTerritory](./SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_SalesPerson_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#salesperson)

**Table** refers to the table that defines a foreign key mapping to SalesPerson.

**Primary Key** is the column in SalesPerson that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `BusinessEntityID` | `SalesPersonID` | **FK_SalesOrderHeader_SalesPerson_SalesPersonID**
[Sales.SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID**
[Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID**
[Sales.Store](./Store.md) | `BusinessEntityID` | `SalesPersonID` | **FK_Store_SalesPerson_SalesPersonID**

## Maps
[Back to Top](#salesperson)

### Dependency Map
[Back to Top](#salesperson)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesPerson.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salesperson)

> The following is a distinct list of tables captured by recursively evaluating tables that list SalesPerson as a foreign key dependency.

* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [Sales.Store](./Store.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)