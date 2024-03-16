# Production.ProductCategory

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productcategory)

Column | Type | Is Nullable
-------|------|------------
**ProductCategoryID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productcategory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductCategory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductCategory`.

### Dependencies
[Back to Top](#productcategory)


No dependencies defined

### Dependents
[Back to Top](#productcategory)

**Table** refers to the table that defines a foreign key mapping to ProductCategory.

**Primary Key** is the column in ProductCategory that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductSubcategory](./ProductSubcategory.md) | `ProductCategoryID` | `ProductCategoryID` | **FK_ProductSubcategory_ProductCategory_ProductCategoryID**

## Maps
[Back to Top](#productcategory)

### Dependency Map
[Back to Top](#productcategory)

ProductCategory has no dependencies
### Dependent Map
[Back to Top](#productcategory)

> The following is a distinct list of tables captured by recursively evaluating tables that list ProductCategory as a foreign key dependency.

* [Production.ProductSubcategory](./ProductSubcategory.md)
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
