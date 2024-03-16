# Production.UnitMeasure

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionunitmeasure)

Column | Type | Is Nullable
-------|------|------------
**UnitMeasureCode** | `nchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionunitmeasure)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.UnitMeasure`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.UnitMeasure`.

### Dependencies
[Back to Top](#productionunitmeasure)


No dependencies defined

### Dependents
[Back to Top](#productionunitmeasure)

**Table** refers to the table that defines a foreign key mapping to Production.UnitMeasure.

**Primary Key** is the column in Production.UnitMeasure that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.BillOfMaterials](./BillOfMaterials.md) | `UnitMeasureCode` | `UnitMeasureCode` | **FK_BillOfMaterials_UnitMeasure_UnitMeasureCode**
[Production.Product](./Product.md) | `UnitMeasureCode` | `SizeUnitMeasureCode` | **FK_Product_UnitMeasure_SizeUnitMeasureCode**
[Production.Product](./Product.md) | `UnitMeasureCode` | `WeightUnitMeasureCode` | **FK_Product_UnitMeasure_WeightUnitMeasureCode**
[Purchasing.ProductVendor](../Purchasing/ProductVendor.md) | `UnitMeasureCode` | `UnitMeasureCode` | **FK_ProductVendor_UnitMeasure_UnitMeasureCode**

## Maps
[Back to Top](#productionunitmeasure)

### Dependency Map
[Back to Top](#productionunitmeasure)

Production.UnitMeasure has no dependencies
### Dependent Map
[Back to Top](#productionunitmeasure)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.UnitMeasure as a foreign key dependency.

* [Production.BillOfMaterials](./BillOfMaterials.md)
* [Production.Product](./Product.md)
* [Production.BillOfMaterials](./BillOfMaterials.md)
* [Production.ProductCostHistory](./ProductCostHistory.md)
* [Production.ProductDocument](./ProductDocument.md)
* [Production.ProductInventory](./ProductInventory.md)
* [Production.ProductListPriceHistory](./ProductListPriceHistory.md)
* [Production.ProductProductPhoto](./ProductProductPhoto.md)
* [Production.ProductReview](./ProductReview.md)
* [Production.TransactionHistory](./TransactionHistory.md)
* [Production.WorkOrder](./WorkOrder.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
* [Purchasing.ProductVendor](../Purchasing/ProductVendor.md)
* [Purchasing.PurchaseOrderDetail](../Purchasing/PurchaseOrderDetail.md)
* [Sales.ShoppingCartItem](../Sales/ShoppingCartItem.md)
* [Sales.SpecialOfferProduct](../Sales/SpecialOfferProduct.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Purchasing.ProductVendor](../Purchasing/ProductVendor.md)
