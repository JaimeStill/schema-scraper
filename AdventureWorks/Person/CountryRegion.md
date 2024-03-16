# Person.CountryRegion

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personcountryregion)

Column | Type | Is Nullable
-------|------|------------
**CountryRegionCode** | `nvarchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personcountryregion)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.CountryRegion`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.CountryRegion`.

### Dependencies
[Back to Top](#personcountryregion)


No dependencies defined

### Dependents
[Back to Top](#personcountryregion)

**Table** refers to the table that defines a foreign key mapping to Person.CountryRegion.

**Primary Key** is the column in Person.CountryRegion that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.StateProvince](./StateProvince.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_StateProvince_CountryRegion_CountryRegionCode**
[Sales.CountryRegionCurrency](../Sales/CountryRegionCurrency.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_CountryRegionCurrency_CountryRegion_CountryRegionCode**
[Sales.SalesTerritory](../Sales/SalesTerritory.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_SalesTerritory_CountryRegion_CountryRegionCode**

## Maps
[Back to Top](#personcountryregion)

### Dependency Map
[Back to Top](#personcountryregion)

Person.CountryRegion has no dependencies
### Dependent Map
[Back to Top](#personcountryregion)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.CountryRegion as a foreign key dependency.

* [Person.StateProvince](./StateProvince.md)
* [Person.Address](./Address.md)
* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesTaxRate](../Sales/SalesTaxRate.md)
* [Sales.CountryRegionCurrency](../Sales/CountryRegionCurrency.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
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
