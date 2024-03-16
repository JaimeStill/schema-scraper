# Sales.Currency

**Schema**: Sales
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
* **Dependencies** - foreign key relationships defined by `Sales.Currency`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.Currency`.

### Dependencies
[Back to Top](#currency)


No dependencies defined

### Dependents
[Back to Top](#currency)

**Table** refers to the table that defines a foreign key mapping to Currency.

**Primary Key** is the column in Currency that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.CountryRegionCurrency](./CountryRegionCurrency.md) | `CurrencyCode` | `CurrencyCode` | **FK_CountryRegionCurrency_Currency_CurrencyCode**
[Sales.CurrencyRate](./CurrencyRate.md) | `CurrencyCode` | `FromCurrencyCode` | **FK_CurrencyRate_Currency_FromCurrencyCode**
[Sales.CurrencyRate](./CurrencyRate.md) | `CurrencyCode` | `ToCurrencyCode` | **FK_CurrencyRate_Currency_ToCurrencyCode**

## Maps
[Back to Top](#currency)

### Dependency Map
[Back to Top](#currency)

Currency has no dependencies
### Dependent Map
[Back to Top](#currency)

> The following is a distinct list of tables captured by recursively evaluating tables that list Currency as a foreign key dependency.

* [Sales.CountryRegionCurrency](./CountryRegionCurrency.md)
* [Sales.CurrencyRate](./CurrencyRate.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
