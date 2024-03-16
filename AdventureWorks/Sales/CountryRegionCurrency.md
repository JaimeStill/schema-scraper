# Sales.CountryRegionCurrency

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salescountryregioncurrency)

Column | Type | Is Nullable
-------|------|------------
**CountryRegionCode** | `nvarchar` | False
**CurrencyCode** | `nchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salescountryregioncurrency)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.CountryRegionCurrency`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.CountryRegionCurrency`.

### Dependencies
[Back to Top](#salescountryregioncurrency)


**Table** refers to the table that the foreign key defined by `Sales.CountryRegionCurrency` maps to.

**Foreign Key** is the column in `Sales.CountryRegionCurrency` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.CountryRegion](../Person/CountryRegion.md) | `CountryRegionCode` | `CountryRegionCode` | **FK_CountryRegionCurrency_CountryRegion_CountryRegionCode**
[Sales.Currency](./Currency.md) | `CurrencyCode` | `CurrencyCode` | **FK_CountryRegionCurrency_Currency_CurrencyCode**

### Dependents
[Back to Top](#salescountryregioncurrency)

No dependencies defined

## Maps
[Back to Top](#salescountryregioncurrency)

### Dependency Map
[Back to Top](#salescountryregioncurrency)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.CountryRegionCurrency.

* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.Currency](./Currency.md)
### Dependent Map
[Back to Top](#salescountryregioncurrency)

Sales.CountryRegionCurrency has no dependents
