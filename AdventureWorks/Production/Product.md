# Production.Product

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproduct)

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
[Back to Top](#productionproduct)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.Product`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Product`.

### Dependencies
[Back to Top](#productionproduct)


**Table** refers to the table that the foreign key defined by `Production.Product` maps to.

**Foreign Key** is the column in `Production.Product` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModel](./ProductModel.md) | `ProductModelID` | `ProductModelID` | **FK_Product_ProductModel_ProductModelID**
[Production.ProductSubcategory](./ProductSubcategory.md) | `ProductSubcategoryID` | `ProductSubcategoryID` | **FK_Product_ProductSubcategory_ProductSubcategoryID**
[Production.UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode` | `SizeUnitMeasureCode` | **FK_Product_UnitMeasure_SizeUnitMeasureCode**
[Production.UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode` | `WeightUnitMeasureCode` | **FK_Product_UnitMeasure_WeightUnitMeasureCode**

### Dependents
[Back to Top](#productionproduct)

**Table** refers to the table that defines a foreign key mapping to Production.Product.

**Primary Key** is the column in Production.Product that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.BillOfMaterials](./BillOfMaterials.md) | `ProductID` | `ProductAssemblyID` | **FK_BillOfMaterials_Product_ProductAssemblyID**
[Production.BillOfMaterials](./BillOfMaterials.md) | `ProductID` | `ComponentID` | **FK_BillOfMaterials_Product_ComponentID**
[Production.ProductCostHistory](./ProductCostHistory.md) | `ProductID` | `ProductID` | **FK_ProductCostHistory_Product_ProductID**
[Production.ProductDocument](./ProductDocument.md) | `ProductID` | `ProductID` | **FK_ProductDocument_Product_ProductID**
[Production.ProductInventory](./ProductInventory.md) | `ProductID` | `ProductID` | **FK_ProductInventory_Product_ProductID**
[Production.ProductListPriceHistory](./ProductListPriceHistory.md) | `ProductID` | `ProductID` | **FK_ProductListPriceHistory_Product_ProductID**
[Production.ProductProductPhoto](./ProductProductPhoto.md) | `ProductID` | `ProductID` | **FK_ProductProductPhoto_Product_ProductID**
[Production.ProductReview](./ProductReview.md) | `ProductID` | `ProductID` | **FK_ProductReview_Product_ProductID**
[Production.TransactionHistory](./TransactionHistory.md) | `ProductID` | `ProductID` | **FK_TransactionHistory_Product_ProductID**
[Production.WorkOrder](./WorkOrder.md) | `ProductID` | `ProductID` | **FK_WorkOrder_Product_ProductID**
[Purchasing.ProductVendor](../Purchasing/ProductVendor.md) | `ProductID` | `ProductID` | **FK_ProductVendor_Product_ProductID**
[Purchasing.PurchaseOrderDetail](../Purchasing/PurchaseOrderDetail.md) | `ProductID` | `ProductID` | **FK_PurchaseOrderDetail_Product_ProductID**
[Sales.ShoppingCartItem](../Sales/ShoppingCartItem.md) | `ProductID` | `ProductID` | **FK_ShoppingCartItem_Product_ProductID**
[Sales.SpecialOfferProduct](../Sales/SpecialOfferProduct.md) | `ProductID` | `ProductID` | **FK_SpecialOfferProduct_Product_ProductID**

## Maps
[Back to Top](#productionproduct)

### Dependency Map
[Back to Top](#productionproduct)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.Product.

* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productionproduct)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.Product as a foreign key dependency.

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
