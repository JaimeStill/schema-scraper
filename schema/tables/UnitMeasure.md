# UnitMeasure

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#unitmeasure)

Column | Type | Is Nullable
-------|------|------------
**UnitMeasureCode** | `nchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#unitmeasure)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `UnitMeasure`.
* **Dependents** - foreign key relationships defined by other tables that reference `UnitMeasure`.

### Dependencies
[Back to Top](#unitmeasure)

**Dependency Table** refers to the table that the foreign key defined by `UnitMeasure` maps to.

**Foreign Key Column** is the column in `UnitMeasure` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#unitmeasure)

**Dependent Table** refers to the table that defines a foreign key mapping to UnitMeasure.

**Dependency Key Column** is the column in UnitMeasure that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BillOfMaterials](./BillOfMaterials.md) | **FK_BillOfMaterials_UnitMeasure_UnitMeasureCode** | `UnitMeasureCode` | `UnitMeasureCode`
[Product](./Product.md) | **FK_Product_UnitMeasure_SizeUnitMeasureCode** | `SizeUnitMeasureCode` | `UnitMeasureCode`
[Product](./Product.md) | **FK_Product_UnitMeasure_WeightUnitMeasureCode** | `WeightUnitMeasureCode` | `UnitMeasureCode`
[ProductVendor](./ProductVendor.md) | **FK_ProductVendor_UnitMeasure_UnitMeasureCode** | `UnitMeasureCode` | `UnitMeasureCode`

## Dependency Map
[Back to Top](#unitmeasure)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table UnitMeasure.

* [BillOfMaterials](./BillOfMaterials.md)
* [Product](./Product.md)
* [ProductCostHistory](./ProductCostHistory.md)
* [ProductDocument](./ProductDocument.md)
* [ProductInventory](./ProductInventory.md)
* [ProductListPriceHistory](./ProductListPriceHistory.md)
* [ProductProductPhoto](./ProductProductPhoto.md)
* [ProductReview](./ProductReview.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [ShoppingCartItem](./ShoppingCartItem.md)
* [SpecialOfferProduct](./SpecialOfferProduct.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [TransactionHistory](./TransactionHistory.md)
* [WorkOrder](./WorkOrder.md)
* [WorkOrderRouting](./WorkOrderRouting.md)
* [ProductVendor](./ProductVendor.md)
