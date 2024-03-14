# Product

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#product)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**Name** | `nvarchar` | False
**ProductNumber** | `nvarchar` | False
**MakeFlag** | `bit` | False
**FinishedGoodsFlag** | `bit` | False
**Color** | `nvarchar` | True
**SafetyStockLevel** | `smallint` | False
**ReorderPoint** | `smallint` | False
**StandardCost** | `money` | False
**ListPrice** | `money` | False
**Size** | `nvarchar` | True
**SizeUnitMeasureCode** | `nchar` | True
**WeightUnitMeasureCode** | `nchar` | True
**Weight** | `decimal` | True
**DaysToManufacture** | `int` | False
**ProductLine** | `nchar` | True
**Class** | `nchar` | True
**Style** | `nchar` | True
**ProductSubcategoryID** | `int` | True
**ProductModelID** | `int` | True
**SellStartDate** | `datetime` | False
**SellEndDate** | `datetime` | True
**DiscontinuedDate** | `datetime` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#product)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Product`.
* **Dependents** - foreign key relationships defined by other tables that reference `Product`.

### Dependencies
[Back to Top](#product)

**Dependency Table** refers to the table that the foreign key defined by `Product` maps to.

**Foreign Key Column** is the column in `Product` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Product_ProductModel_ProductModelID** | `ProductModelID` | [ProductModel](./ProductModel.md) | `ProductModelID`
**FK_Product_ProductSubcategory_ProductSubcategoryID** | `ProductSubcategoryID` | [ProductSubcategory](./ProductSubcategory.md) | `ProductSubcategoryID`
**FK_Product_UnitMeasure_SizeUnitMeasureCode** | `SizeUnitMeasureCode` | [UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode`
**FK_Product_UnitMeasure_WeightUnitMeasureCode** | `WeightUnitMeasureCode` | [UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode`

### Dependents
[Back to Top](#product)

**Dependent Table** refers to the table that defines a foreign key mapping to Product.

**Dependency Key Column** is the column in Product that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BillOfMaterials](./BillOfMaterials.md) | **FK_BillOfMaterials_Product_ProductAssemblyID** | `ProductAssemblyID` | `ProductID`
[BillOfMaterials](./BillOfMaterials.md) | **FK_BillOfMaterials_Product_ComponentID** | `ComponentID` | `ProductID`
[ProductCostHistory](./ProductCostHistory.md) | **FK_ProductCostHistory_Product_ProductID** | `ProductID` | `ProductID`
[ProductDocument](./ProductDocument.md) | **FK_ProductDocument_Product_ProductID** | `ProductID` | `ProductID`
[ProductInventory](./ProductInventory.md) | **FK_ProductInventory_Product_ProductID** | `ProductID` | `ProductID`
[ProductListPriceHistory](./ProductListPriceHistory.md) | **FK_ProductListPriceHistory_Product_ProductID** | `ProductID` | `ProductID`
[ProductProductPhoto](./ProductProductPhoto.md) | **FK_ProductProductPhoto_Product_ProductID** | `ProductID` | `ProductID`
[ProductReview](./ProductReview.md) | **FK_ProductReview_Product_ProductID** | `ProductID` | `ProductID`
[ProductVendor](./ProductVendor.md) | **FK_ProductVendor_Product_ProductID** | `ProductID` | `ProductID`
[PurchaseOrderDetail](./PurchaseOrderDetail.md) | **FK_PurchaseOrderDetail_Product_ProductID** | `ProductID` | `ProductID`
[ShoppingCartItem](./ShoppingCartItem.md) | **FK_ShoppingCartItem_Product_ProductID** | `ProductID` | `ProductID`
[SpecialOfferProduct](./SpecialOfferProduct.md) | **FK_SpecialOfferProduct_Product_ProductID** | `ProductID` | `ProductID`
[TransactionHistory](./TransactionHistory.md) | **FK_TransactionHistory_Product_ProductID** | `ProductID` | `ProductID`
[WorkOrder](./WorkOrder.md) | **FK_WorkOrder_Product_ProductID** | `ProductID` | `ProductID`

## Dependency Map
[Back to Top](#product)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Product.

* [BillOfMaterials](./BillOfMaterials.md)
* [ProductCostHistory](./ProductCostHistory.md)
* [ProductDocument](./ProductDocument.md)
* [ProductInventory](./ProductInventory.md)
* [ProductListPriceHistory](./ProductListPriceHistory.md)
* [ProductProductPhoto](./ProductProductPhoto.md)
* [ProductReview](./ProductReview.md)
* [ProductVendor](./ProductVendor.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [ShoppingCartItem](./ShoppingCartItem.md)
* [SpecialOfferProduct](./SpecialOfferProduct.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [TransactionHistory](./TransactionHistory.md)
* [WorkOrder](./WorkOrder.md)
* [WorkOrderRouting](./WorkOrderRouting.md)
