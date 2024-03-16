# Person.StateProvince

**Schema**: Person
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
* **Dependencies** - foreign key relationships defined by `Person.StateProvince`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.StateProvince`.

### Dependencies
[Back to Top](#stateprovince)


**Table** refers to the table that the foreign key defined by `Person.StateProvince` maps to.

**Foreign Key** is the column in `Person.StateProvince` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.CountryRegion](./CountryRegion.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_StateProvince_CountryRegion_CountryRegionCode**
[Sales.SalesTerritory](../Sales/SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_StateProvince_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#stateprovince)

**Table** refers to the table that defines a foreign key mapping to StateProvince.

**Primary Key** is the column in StateProvince that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Address](./Address.md) | `StateProvinceID` | `StateProvinceID` | **FK_Address_StateProvince_StateProvinceID**
[Sales.SalesTaxRate](../Sales/SalesTaxRate.md) | `StateProvinceID` | `StateProvinceID` | **FK_SalesTaxRate_StateProvince_StateProvinceID**

## Maps
[Back to Top](#stateprovince)

### Dependency Map
[Back to Top](#stateprovince)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table StateProvince.

* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#stateprovince)

> The following is a distinct list of tables captured by recursively evaluating tables that list StateProvince as a foreign key dependency.

* [Person.Address](./Address.md)
* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesTaxRate](../Sales/SalesTaxRate.md)
