# StateProvince

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#stateprovince)

Column | Type | Is Nullable
-------|------|------------
**StateProvinceID** | `int` | False
**StateProvinceCode** | `nchar` | False
**CountryRegionCode** | `nvarchar` | False
**IsOnlyStateProvinceFlag** | `bit` | False
**Name** | `nvarchar` | False
**TerritoryID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#stateprovince)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `StateProvince`.
* **Dependents** - foreign key relationships defined by other tables that reference `StateProvince`.

### Dependencies
[Back to Top](#stateprovince)

**Dependency Table** refers to the table that the foreign key defined by `StateProvince` maps to.

**Foreign Key Column** is the column in `StateProvince` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_StateProvince_CountryRegion_CountryRegionCode** | `CountryRegionCode` | [CountryRegion](./CountryRegion.md) | `CountryRegionCode`
**FK_StateProvince_SalesTerritory_TerritoryID** | `TerritoryID` | [SalesTerritory](./SalesTerritory.md) | `TerritoryID`

### Dependents
[Back to Top](#stateprovince)

**Dependent Table** refers to the table that defines a foreign key mapping to StateProvince.

**Dependency Key Column** is the column in StateProvince that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Address](./Address.md) | **FK_Address_StateProvince_StateProvinceID** | `StateProvinceID` | `StateProvinceID`
[SalesTaxRate](./SalesTaxRate.md) | **FK_SalesTaxRate_StateProvince_StateProvinceID** | `StateProvinceID` | `StateProvinceID`

## Dependency Map
[Back to Top](#stateprovince)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table StateProvince.

* [Address](./Address.md)
* [BusinessEntityAddress](./BusinessEntityAddress.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [SalesTaxRate](./SalesTaxRate.md)
