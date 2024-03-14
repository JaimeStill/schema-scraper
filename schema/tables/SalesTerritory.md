# SalesTerritory

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesterritory)

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
[Back to Top](#salesterritory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesTerritory`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesTerritory`.

### Dependencies
[Back to Top](#salesterritory)

**Dependency Table** refers to the table that the foreign key defined by `SalesTerritory` maps to.

**Foreign Key Column** is the column in `SalesTerritory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesTerritory_CountryRegion_CountryRegionCode** | `CountryRegionCode` | [CountryRegion](./CountryRegion.md) | `CountryRegionCode`

### Dependents
[Back to Top](#salesterritory)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesTerritory.

**Dependency Key Column** is the column in SalesTerritory that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Customer](./Customer.md) | **FK_Customer_SalesTerritory_TerritoryID** | `TerritoryID` | `TerritoryID`
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_SalesTerritory_TerritoryID** | `TerritoryID` | `TerritoryID`
[SalesPerson](./SalesPerson.md) | **FK_SalesPerson_SalesTerritory_TerritoryID** | `TerritoryID` | `TerritoryID`
[SalesTerritoryHistory](./SalesTerritoryHistory.md) | **FK_SalesTerritoryHistory_SalesTerritory_TerritoryID** | `TerritoryID` | `TerritoryID`
[StateProvince](./StateProvince.md) | **FK_StateProvince_SalesTerritory_TerritoryID** | `TerritoryID` | `TerritoryID`

## Dependency Map
[Back to Top](#salesterritory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesTerritory.

* [Customer](./Customer.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [SalesPerson](./SalesPerson.md)
* [SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [Store](./Store.md)
* [SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [StateProvince](./StateProvince.md)
* [Address](./Address.md)
* [BusinessEntityAddress](./BusinessEntityAddress.md)
* [SalesTaxRate](./SalesTaxRate.md)
