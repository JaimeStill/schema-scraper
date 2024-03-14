# PurchaseOrderDetail

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#purchaseorderdetail)

Column | Type | Is Nullable
-------|------|------------
**PurchaseOrderID** | `int` | False
**PurchaseOrderDetailID** | `int` | False
**DueDate** | `datetime` | False
**OrderQty** | `smallint` | False
**ProductID** | `int` | False
**UnitPrice** | `money` | False
**LineTotal** | `money` | False
**ReceivedQty** | `decimal` | False
**RejectedQty** | `decimal` | False
**StockedQty** | `decimal` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#purchaseorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `PurchaseOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `PurchaseOrderDetail`.

### Dependencies
[Back to Top](#purchaseorderdetail)

**Dependency Table** refers to the table that the foreign key defined by `PurchaseOrderDetail` maps to.

**Foreign Key Column** is the column in `PurchaseOrderDetail` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_PurchaseOrderDetail_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID** | `PurchaseOrderID` | [PurchaseOrderHeader](./PurchaseOrderHeader.md) | `PurchaseOrderID`

### Dependents
[Back to Top](#purchaseorderdetail)

**Dependent Table** refers to the table that defines a foreign key mapping to PurchaseOrderDetail.

**Dependency Key Column** is the column in PurchaseOrderDetail that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#purchaseorderdetail)

PurchaseOrderDetail has no dependencies.
