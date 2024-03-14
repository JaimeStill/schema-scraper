# SalesOrderDetail

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesorderdetail)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesOrderDetailID** | `int` | False
**CarrierTrackingNumber** | `nvarchar` | True
**OrderQty** | `smallint` | False
**ProductID** | `int` | False
**SpecialOfferID** | `int` | False
**UnitPrice** | `money` | False
**UnitPriceDiscount** | `money` | False
**LineTotal** | `numeric` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesOrderDetail`.

### Dependencies
[Back to Top](#salesorderdetail)

**Dependency Table** refers to the table that the foreign key defined by `SalesOrderDetail` maps to.

**Foreign Key Column** is the column in `SalesOrderDetail` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID** | `SalesOrderID` | [SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID`
**FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID** | `SpecialOfferID` | [SpecialOfferProduct](./SpecialOfferProduct.md) | `SpecialOfferID`
**FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID** | `ProductID` | [SpecialOfferProduct](./SpecialOfferProduct.md) | `ProductID`

### Dependents
[Back to Top](#salesorderdetail)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesOrderDetail.

**Dependency Key Column** is the column in SalesOrderDetail that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#salesorderdetail)

SalesOrderDetail has no dependencies.
