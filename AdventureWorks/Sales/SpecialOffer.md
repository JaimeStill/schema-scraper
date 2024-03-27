# Sales.SpecialOffer

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salesspecialoffer)

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
[Back to Top](#salesspecialoffer)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SpecialOffer`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SpecialOffer`.

### Dependencies
[Back to Top](#salesspecialoffer)


No dependencies defined

### Dependents
[Back to Top](#salesspecialoffer)

**Table** refers to the table that defines a foreign key mapping to Sales.SpecialOffer.

**Primary Key** is the column in Sales.SpecialOffer that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID**

## Maps
[Back to Top](#salesspecialoffer)

### Dependency Map
[Back to Top](#salesspecialoffer)

Sales.SpecialOffer has no dependencies

### Dependent Map
[Back to Top](#salesspecialoffer)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.SpecialOffer as a foreign key dependency.

* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SpecialOfferProduct](./SpecialOfferProduct.md)

