# Sales.CurrencyRate

**Schema**: Sales
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
* **Dependencies** - foreign key relationships defined by `Sales.CurrencyRate`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.CurrencyRate`.

### Dependencies
[Back to Top](#currencyrate)


**Table** refers to the table that the foreign key defined by `Sales.CurrencyRate` maps to.

**Foreign Key** is the column in `Sales.CurrencyRate` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.Currency](./Currency.md) | `CurrencyCode` | `FromCurrencyCode` | **FK_CurrencyRate_Currency_FromCurrencyCode**
[Sales.Currency](./Currency.md) | `CurrencyCode` | `ToCurrencyCode` | **FK_CurrencyRate_Currency_ToCurrencyCode**

### Dependents
[Back to Top](#currencyrate)

**Table** refers to the table that defines a foreign key mapping to CurrencyRate.

**Primary Key** is the column in CurrencyRate that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `CurrencyRateID` | `CurrencyRateID` | **FK_SalesOrderHeader_CurrencyRate_CurrencyRateID**

## Maps
[Back to Top](#currencyrate)

### Dependency Map
[Back to Top](#currencyrate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table CurrencyRate.

* [Sales.Currency](./Currency.md)
### Dependent Map
[Back to Top](#currencyrate)

> The following is a distinct list of tables captured by recursively evaluating tables that list CurrencyRate as a foreign key dependency.

* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
