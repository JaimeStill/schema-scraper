# Sales.CurrencyRate

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salescurrencyrate)

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
[Back to Top](#salescurrencyrate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.CurrencyRate`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.CurrencyRate`.

### Dependencies
[Back to Top](#salescurrencyrate)


**Table** refers to the table that the foreign key defined by `Sales.CurrencyRate` maps to.

**Foreign Key** is the column in `Sales.CurrencyRate` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.Currency](./Currency.md) | `CurrencyCode` | `FromCurrencyCode` | **FK_CurrencyRate_Currency_FromCurrencyCode**
[Sales.Currency](./Currency.md) | `CurrencyCode` | `ToCurrencyCode` | **FK_CurrencyRate_Currency_ToCurrencyCode**

### Dependents
[Back to Top](#salescurrencyrate)

**Table** refers to the table that defines a foreign key mapping to Sales.CurrencyRate.

**Primary Key** is the column in Sales.CurrencyRate that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `CurrencyRateID` | `CurrencyRateID` | **FK_SalesOrderHeader_CurrencyRate_CurrencyRateID**

## Maps
[Back to Top](#salescurrencyrate)

### Dependency Map
[Back to Top](#salescurrencyrate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.CurrencyRate.

* [Sales.Currency](./Currency.md)

### Dependent Map
[Back to Top](#salescurrencyrate)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.CurrencyRate as a foreign key dependency.

* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)

