# Sales.SpecialOffer

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#specialoffer)

Column | Type | Is Nullable
-------|------|------------
**SpecialOfferID** | `int` | False
**Description** | `nvarchar` | False
**DiscountPct** | `smallmoney` | False
**Type** | `nvarchar` | False
**Category** | `nvarchar` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | False
**MinQty** | `int` | False
**MaxQty** | `int` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#specialoffer)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SpecialOffer`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SpecialOffer`.

### Dependencies
[Back to Top](#specialoffer)


No dependencies defined

### Dependents
[Back to Top](#specialoffer)

**Table** refers to the table that defines a foreign key mapping to SpecialOffer.

**Primary Key** is the column in SpecialOffer that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID**

## Maps
[Back to Top](#specialoffer)

### Dependency Map
[Back to Top](#specialoffer)

SpecialOffer has no dependencies
### Dependent Map
[Back to Top](#specialoffer)

> The following is a distinct list of tables captured by recursively evaluating tables that list SpecialOffer as a foreign key dependency.

* [Sales.SpecialOfferProduct](./SpecialOfferProduct.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
