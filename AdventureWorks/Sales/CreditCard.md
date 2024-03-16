# Sales.CreditCard

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#creditcard)

Column | Type | Is Nullable
-------|------|------------
**CreditCardID** | `int` | False
**CardType** | `nvarchar` | False
**CardNumber** | `nvarchar` | False
**ExpMonth** | `tinyint` | False
**ExpYear** | `smallint` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#creditcard)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.CreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.CreditCard`.

### Dependencies
[Back to Top](#creditcard)


No dependencies defined

### Dependents
[Back to Top](#creditcard)

**Table** refers to the table that defines a foreign key mapping to CreditCard.

**Primary Key** is the column in CreditCard that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.PersonCreditCard](./PersonCreditCard.md) | `CreditCardID` | `CreditCardID` | **FK_PersonCreditCard_CreditCard_CreditCardID**
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `CreditCardID` | `CreditCardID` | **FK_SalesOrderHeader_CreditCard_CreditCardID**

## Maps
[Back to Top](#creditcard)

### Dependency Map
[Back to Top](#creditcard)

CreditCard has no dependencies
### Dependent Map
[Back to Top](#creditcard)

> The following is a distinct list of tables captured by recursively evaluating tables that list CreditCard as a foreign key dependency.

* [Sales.PersonCreditCard](./PersonCreditCard.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
