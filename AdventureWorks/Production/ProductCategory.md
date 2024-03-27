# Production.ProductCategory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductcategory)

Column | Type | Is Nullable
-------|------|------------
**ProductCategoryID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductcategory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductCategory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductCategory`.

### Dependencies
[Back to Top](#productionproductcategory)


No dependencies defined

### Dependents
[Back to Top](#productionproductcategory)

**Table** refers to the table that defines a foreign key mapping to Production.ProductCategory.

**Primary Key** is the column in Production.ProductCategory that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductSubcategory](./ProductSubcategory.md) | `ProductCategoryID` | `ProductCategoryID` | **FK_ProductSubcategory_ProductCategory_ProductCategoryID**

## Maps
[Back to Top](#productionproductcategory)

### Dependency Map
[Back to Top](#productionproductcategory)

Production.ProductCategory has no dependencies

### Dependent Map
[Back to Top](#productionproductcategory)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.ProductCategory as a foreign key dependency.

* [Production.BillOfMaterials](./BillOfMaterials.md)
* [Production.Product](./Product.md)
* [Production.ProductCostHistory](./ProductCostHistory.md)
* [Production.ProductDocument](./ProductDocument.md)
* [Production.ProductInventory](./ProductInventory.md)
* [Production.ProductListPriceHistory](./ProductListPriceHistory.md)
* [Production.ProductProductPhoto](./ProductProductPhoto.md)
* [Production.ProductReview](./ProductReview.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.TransactionHistory](./TransactionHistory.md)
* [Production.WorkOrder](./WorkOrder.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
* [Purchasing.ProductVendor](../Purchasing/ProductVendor.md)
* [Purchasing.PurchaseOrderDetail](../Purchasing/PurchaseOrderDetail.md)
* [Sales.SalesOrderDetail](../Sales/SalesOrderDetail.md)
* [Sales.ShoppingCartItem](../Sales/ShoppingCartItem.md)
* [Sales.SpecialOfferProduct](../Sales/SpecialOfferProduct.md)

