# SalesPerson

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
* **Dependencies** - foreign key relationships defined by `SalesPerson`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesPerson`.

### Dependencies
[Back to Top](#salesperson)

**Dependency Table** refers to the table that the foreign key defined by `SalesPerson` maps to.

**Foreign Key Column** is the column in `SalesPerson` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesPerson_Employee_BusinessEntityID** | `BusinessEntityID` | [Employee](./Employee.md) | `BusinessEntityID`
**FK_SalesPerson_SalesTerritory_TerritoryID** | `TerritoryID` | [SalesTerritory](./SalesTerritory.md) | `TerritoryID`

### Dependents
[Back to Top](#salesperson)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesPerson.

**Dependency Key Column** is the column in SalesPerson that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_SalesPerson_SalesPersonID** | `SalesPersonID` | `BusinessEntityID`
[SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md) | **FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[SalesTerritoryHistory](./SalesTerritoryHistory.md) | **FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Store](./Store.md) | **FK_Store_SalesPerson_SalesPersonID** | `SalesPersonID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#salesperson)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesPerson.

* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [Store](./Store.md)
* [Customer](./Customer.md)
