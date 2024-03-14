# CreditCard

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
* **Dependencies** - foreign key relationships defined by `CreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `CreditCard`.

### Dependencies
[Back to Top](#creditcard)

**Dependency Table** refers to the table that the foreign key defined by `CreditCard` maps to.

**Foreign Key Column** is the column in `CreditCard` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#creditcard)

**Dependent Table** refers to the table that defines a foreign key mapping to CreditCard.

**Dependency Key Column** is the column in CreditCard that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[PersonCreditCard](./PersonCreditCard.md) | **FK_PersonCreditCard_CreditCard_CreditCardID** | `CreditCardID` | `CreditCardID`
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_CreditCard_CreditCardID** | `CreditCardID` | `CreditCardID`

## Dependency Map
[Back to Top](#creditcard)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table CreditCard.

* [PersonCreditCard](./PersonCreditCard.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
