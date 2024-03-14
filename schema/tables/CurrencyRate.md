# CurrencyRate

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#currencyrate)

Column | Type | Is Nullable
-------|------|------------
**CurrencyRateID** | `int` | False
**CurrencyRateDate** | `datetime` | False
**FromCurrencyCode** | `nchar` | False
**ToCurrencyCode** | `nchar` | False
**AverageRate** | `money` | False
**EndOfDayRate** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#currencyrate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `CurrencyRate`.
* **Dependents** - foreign key relationships defined by other tables that reference `CurrencyRate`.

### Dependencies
[Back to Top](#currencyrate)

**Dependency Table** refers to the table that the foreign key defined by `CurrencyRate` maps to.

**Foreign Key Column** is the column in `CurrencyRate` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_CurrencyRate_Currency_FromCurrencyCode** | `FromCurrencyCode` | [Currency](./Currency.md) | `CurrencyCode`
**FK_CurrencyRate_Currency_ToCurrencyCode** | `ToCurrencyCode` | [Currency](./Currency.md) | `CurrencyCode`

### Dependents
[Back to Top](#currencyrate)

**Dependent Table** refers to the table that defines a foreign key mapping to CurrencyRate.

**Dependency Key Column** is the column in CurrencyRate that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_CurrencyRate_CurrencyRateID** | `CurrencyRateID` | `CurrencyRateID`

## Dependency Map
[Back to Top](#currencyrate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table CurrencyRate.

* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
