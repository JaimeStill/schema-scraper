# Sales.SalesTerritory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesterritory)

Column | Type | Is Nullable
-------|------|------------
**TerritoryID** | `int` | False
**Name** | `nvarchar` | False
**CountryRegionCode** | `nvarchar` | False
**Group** | `nvarchar` | False
**SalesYTD** | `money` | False
**SalesLastYear** | `money` | False
**CostYTD** | `money` | False
**CostLastYear** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesterritory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesTerritory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesTerritory`.

### Dependencies
[Back to Top](#salessalesterritory)


**Table** refers to the table that the foreign key defined by `Sales.SalesTerritory` maps to.

**Foreign Key** is the column in `Sales.SalesTerritory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.CountryRegion](../Person/CountryRegion.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_SalesTerritory_CountryRegion_CountryRegionCode**

### Dependents
[Back to Top](#salessalesterritory)

**Table** refers to the table that defines a foreign key mapping to Sales.SalesTerritory.

**Primary Key** is the column in Sales.SalesTerritory that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.StateProvince](../Person/StateProvince.md) | `TerritoryID` | `TerritoryID` | **FK_StateProvince_SalesTerritory_TerritoryID**
[Sales.Customer](./Customer.md) | `TerritoryID` | `TerritoryID` | **FK_Customer_SalesTerritory_TerritoryID**
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `TerritoryID` | `TerritoryID` | **FK_SalesOrderHeader_SalesTerritory_TerritoryID**
[Sales.SalesPerson](./SalesPerson.md) | `TerritoryID` | `TerritoryID` | **FK_SalesPerson_SalesTerritory_TerritoryID**
[Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md) | `TerritoryID` | `TerritoryID` | **FK_SalesTerritoryHistory_SalesTerritory_TerritoryID**

## Maps
[Back to Top](#salessalesterritory)

### Dependency Map
[Back to Top](#salessalesterritory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesTerritory.

* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salessalesterritory)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.SalesTerritory as a foreign key dependency.

* [Person.StateProvince](../Person/StateProvince.md)
* [Person.Address](./Address.md)
* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesTaxRate](../Sales/SalesTaxRate.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesPerson](./SalesPerson.md)
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
* [Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md)
