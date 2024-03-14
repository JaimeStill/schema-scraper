# Currency

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#currency)

Column | Type | Is Nullable
-------|------|------------
**CurrencyCode** | `nchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#currency)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Currency`.
* **Dependents** - foreign key relationships defined by other tables that reference `Currency`.

### Dependencies
[Back to Top](#currency)

**Dependency Table** refers to the table that the foreign key defined by `Currency` maps to.

**Foreign Key Column** is the column in `Currency` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#currency)

**Dependent Table** refers to the table that defines a foreign key mapping to Currency.

**Dependency Key Column** is the column in Currency that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[CountryRegionCurrency](./CountryRegionCurrency.md) | **FK_CountryRegionCurrency_Currency_CurrencyCode** | `CurrencyCode` | `CurrencyCode`
[CurrencyRate](./CurrencyRate.md) | **FK_CurrencyRate_Currency_FromCurrencyCode** | `FromCurrencyCode` | `CurrencyCode`
[CurrencyRate](./CurrencyRate.md) | **FK_CurrencyRate_Currency_ToCurrencyCode** | `ToCurrencyCode` | `CurrencyCode`

## Dependency Map
[Back to Top](#currency)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Currency.

* [CountryRegionCurrency](./CountryRegionCurrency.md)
* [CurrencyRate](./CurrencyRate.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
