# Person.StateProvince

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personstateprovince)

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
[Back to Top](#personstateprovince)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.StateProvince`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.StateProvince`.

### Dependencies
[Back to Top](#personstateprovince)


**Table** refers to the table that the foreign key defined by `Person.StateProvince` maps to.

**Foreign Key** is the column in `Person.StateProvince` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.CountryRegion](./CountryRegion.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_StateProvince_CountryRegion_CountryRegionCode**
[Sales.SalesTerritory](../Sales/SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_StateProvince_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#personstateprovince)

**Table** refers to the table that defines a foreign key mapping to Person.StateProvince.

**Primary Key** is the column in Person.StateProvince that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Address](./Address.md) | `StateProvinceID` | `StateProvinceID` | **FK_Address_StateProvince_StateProvinceID**
[Sales.SalesTaxRate](../Sales/SalesTaxRate.md) | `StateProvinceID` | `StateProvinceID` | **FK_SalesTaxRate_StateProvince_StateProvinceID**

## Maps
[Back to Top](#personstateprovince)

### Dependency Map
[Back to Top](#personstateprovince)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.StateProvince.

* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)

### Dependent Map
[Back to Top](#personstateprovince)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.StateProvince as a foreign key dependency.

* [Person.Address](./Address.md)
* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Sales.SalesOrderDetail](../Sales/SalesOrderDetail.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](../Sales/SalesOrderHeaderSalesReason.md)
* [Sales.SalesTaxRate](../Sales/SalesTaxRate.md)

