# CountryRegionCurrency

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#countryregioncurrency)

Column | Type | Is Nullable
-------|------|------------
**CountryRegionCode** | `nvarchar` | False
**CurrencyCode** | `nchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#countryregioncurrency)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `CountryRegionCurrency`.
* **Dependents** - foreign key relationships defined by other tables that reference `CountryRegionCurrency`.

### Dependencies
[Back to Top](#countryregioncurrency)

**Dependency Table** refers to the table that the foreign key defined by `CountryRegionCurrency` maps to.

**Foreign Key Column** is the column in `CountryRegionCurrency` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_CountryRegionCurrency_CountryRegion_CountryRegionCode** | `CountryRegionCode` | [CountryRegion](./CountryRegion.md) | `CountryRegionCode`
**FK_CountryRegionCurrency_Currency_CurrencyCode** | `CurrencyCode` | [Currency](./Currency.md) | `CurrencyCode`

### Dependents
[Back to Top](#countryregioncurrency)

**Dependent Table** refers to the table that defines a foreign key mapping to CountryRegionCurrency.

**Dependency Key Column** is the column in CountryRegionCurrency that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#countryregioncurrency)

CountryRegionCurrency has no dependencies.
