# Sales.CreditCard

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salescreditcard)

Column | Type | Is Nullable
-------|------|------------
**CreditCardID** | `int` | False
**CardType** | `nvarchar` | False
**CardNumber** | `nvarchar` | False
**ExpMonth** | `tinyint` | False
**ExpYear** | `smallint` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salescreditcard)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.CreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.CreditCard`.

### Dependencies
[Back to Top](#salescreditcard)


No dependencies defined

### Dependents
[Back to Top](#salescreditcard)

**Table** refers to the table that defines a foreign key mapping to Sales.CreditCard.

**Primary Key** is the column in Sales.CreditCard that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.PersonCreditCard](./PersonCreditCard.md) | `CreditCardID` | `CreditCardID` | **FK_PersonCreditCard_CreditCard_CreditCardID**
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `CreditCardID` | `CreditCardID` | **FK_SalesOrderHeader_CreditCard_CreditCardID**

## Maps
[Back to Top](#salescreditcard)

### Dependency Map
[Back to Top](#salescreditcard)

Sales.CreditCard has no dependencies

### Dependent Map
[Back to Top](#salescreditcard)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.CreditCard as a foreign key dependency.

* [Sales.PersonCreditCard](./PersonCreditCard.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)

