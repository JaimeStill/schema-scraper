# SpecialOfferProduct

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#specialofferproduct)

Column | Type | Is Nullable
-------|------|------------
**SpecialOfferID** | `int` | False
**ProductID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#specialofferproduct)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SpecialOfferProduct`.
* **Dependents** - foreign key relationships defined by other tables that reference `SpecialOfferProduct`.

### Dependencies
[Back to Top](#specialofferproduct)

**Dependency Table** refers to the table that the foreign key defined by `SpecialOfferProduct` maps to.

**Foreign Key Column** is the column in `SpecialOfferProduct` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SpecialOfferProduct_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID** | `SpecialOfferID` | [SpecialOffer](./SpecialOffer.md) | `SpecialOfferID`

### Dependents
[Back to Top](#specialofferproduct)

**Dependent Table** refers to the table that defines a foreign key mapping to SpecialOfferProduct.

**Dependency Key Column** is the column in SpecialOfferProduct that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderDetail](./SalesOrderDetail.md) | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID** | `SpecialOfferID` | `SpecialOfferID`
[SalesOrderDetail](./SalesOrderDetail.md) | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID** | `ProductID` | `ProductID`

## Dependency Map
[Back to Top](#specialofferproduct)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SpecialOfferProduct.

* [SalesOrderDetail](./SalesOrderDetail.md)
