# Person.CountryRegion

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#countryregion)

Column | Type | Is Nullable
-------|------|------------
**CountryRegionCode** | `nvarchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#countryregion)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.CountryRegion`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.CountryRegion`.

### Dependencies
[Back to Top](#countryregion)


No dependencies defined

### Dependents
[Back to Top](#countryregion)

**Table** refers to the table that defines a foreign key mapping to CountryRegion.

**Primary Key** is the column in CountryRegion that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.StateProvince](./StateProvince.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_StateProvince_CountryRegion_CountryRegionCode**
[Sales.CountryRegionCurrency](../Sales/CountryRegionCurrency.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_CountryRegionCurrency_CountryRegion_CountryRegionCode**
[Sales.SalesTerritory](../Sales/SalesTerritory.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_SalesTerritory_CountryRegion_CountryRegionCode**

## Maps
[Back to Top](#countryregion)

### Dependency Map
[Back to Top](#countryregion)

CountryRegion has no dependencies
### Dependent Map
[Back to Top](#countryregion)

> The following is a distinct list of tables captured by recursively evaluating tables that list CountryRegion as a foreign key dependency.

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
