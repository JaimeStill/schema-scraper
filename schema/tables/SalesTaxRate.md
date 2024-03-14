# SalesTaxRate

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salestaxrate)

Column | Type | Is Nullable
-------|------|------------
**SalesTaxRateID** | `int` | False
**StateProvinceID** | `int` | False
**TaxType** | `tinyint` | False
**TaxRate** | `smallmoney` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salestaxrate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesTaxRate`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesTaxRate`.

### Dependencies
[Back to Top](#salestaxrate)

**Dependency Table** refers to the table that the foreign key defined by `SalesTaxRate` maps to.

**Foreign Key Column** is the column in `SalesTaxRate` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesTaxRate_StateProvince_StateProvinceID** | `StateProvinceID` | [StateProvince](./StateProvince.md) | `StateProvinceID`

### Dependents
[Back to Top](#salestaxrate)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesTaxRate.

**Dependency Key Column** is the column in SalesTaxRate that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#salestaxrate)

SalesTaxRate has no dependencies.
