# Sales.SalesTaxRate

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalestaxrate)

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
[Back to Top](#salessalestaxrate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesTaxRate`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesTaxRate`.

### Dependencies
[Back to Top](#salessalestaxrate)


**Table** refers to the table that the foreign key defined by `Sales.SalesTaxRate` maps to.

**Foreign Key** is the column in `Sales.SalesTaxRate` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.StateProvince](../Person/StateProvince.md) | `StateProvinceID` | `StateProvinceID` | **FK_SalesTaxRate_StateProvince_StateProvinceID**

### Dependents
[Back to Top](#salessalestaxrate)

No dependencies defined

## Maps
[Back to Top](#salessalestaxrate)

### Dependency Map
[Back to Top](#salessalestaxrate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesTaxRate.

* [Person.StateProvince](../Person/StateProvince.md)
* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salessalestaxrate)

Sales.SalesTaxRate has no dependents
