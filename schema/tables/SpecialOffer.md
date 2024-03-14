# SpecialOffer

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
* **Dependencies** - foreign key relationships defined by `SpecialOffer`.
* **Dependents** - foreign key relationships defined by other tables that reference `SpecialOffer`.

### Dependencies
[Back to Top](#specialoffer)

**Dependency Table** refers to the table that the foreign key defined by `SpecialOffer` maps to.

**Foreign Key Column** is the column in `SpecialOffer` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#specialoffer)

**Dependent Table** refers to the table that defines a foreign key mapping to SpecialOffer.

**Dependency Key Column** is the column in SpecialOffer that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SpecialOfferProduct](./SpecialOfferProduct.md) | **FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID** | `SpecialOfferID` | `SpecialOfferID`

## Dependency Map
[Back to Top](#specialoffer)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SpecialOffer.

* [SpecialOfferProduct](./SpecialOfferProduct.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
