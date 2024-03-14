# CountryRegion

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
* **Dependencies** - foreign key relationships defined by `CountryRegion`.
* **Dependents** - foreign key relationships defined by other tables that reference `CountryRegion`.

### Dependencies
[Back to Top](#countryregion)

**Dependency Table** refers to the table that the foreign key defined by `CountryRegion` maps to.

**Foreign Key Column** is the column in `CountryRegion` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#countryregion)

**Dependent Table** refers to the table that defines a foreign key mapping to CountryRegion.

**Dependency Key Column** is the column in CountryRegion that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[CountryRegionCurrency](./CountryRegionCurrency.md) | **FK_CountryRegionCurrency_CountryRegion_CountryRegionCode** | `CountryRegionCode` | `CountryRegionCode`
[SalesTerritory](./SalesTerritory.md) | **FK_SalesTerritory_CountryRegion_CountryRegionCode** | `CountryRegionCode` | `CountryRegionCode`
[StateProvince](./StateProvince.md) | **FK_StateProvince_CountryRegion_CountryRegionCode** | `CountryRegionCode` | `CountryRegionCode`

## Dependency Map
[Back to Top](#countryregion)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table CountryRegion.

* [CountryRegionCurrency](./CountryRegionCurrency.md)
* [SalesTerritory](./SalesTerritory.md)
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
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [SalesTaxRate](./SalesTaxRate.md)
