# Production.ProductSubcategory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductsubcategory)

Column | Type | Is Nullable
-------|------|------------
**ProductSubcategoryID** | `int` | False
**ProductCategoryID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductsubcategory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductSubcategory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductSubcategory`.

### Dependencies
[Back to Top](#productionproductsubcategory)


**Table** refers to the table that the foreign key defined by `Production.ProductSubcategory` maps to.

**Foreign Key** is the column in `Production.ProductSubcategory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductCategory](./ProductCategory.md) | `ProductCategoryID` | `ProductCategoryID` | **FK_ProductSubcategory_ProductCategory_ProductCategoryID**

### Dependents
[Back to Top](#productionproductsubcategory)

**Table** refers to the table that defines a foreign key mapping to Production.ProductSubcategory.

**Primary Key** is the column in Production.ProductSubcategory that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductSubcategoryID` | `ProductSubcategoryID` | **FK_Product_ProductSubcategory_ProductSubcategoryID**

## Maps
[Back to Top](#productionproductsubcategory)

### Dependency Map
[Back to Top](#productionproductsubcategory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductSubcategory.

* [Production.ProductCategory](./ProductCategory.md)

### Dependent Map
[Back to Top](#productionproductsubcategory)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.ProductSubcategory as a foreign key dependency.

* [Production.BillOfMaterials](./BillOfMaterials.md)
* [Production.Product](./Product.md)
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
* [Sales.SalesOrderDetail](../Sales/SalesOrderDetail.md)
* [Sales.ShoppingCartItem](../Sales/ShoppingCartItem.md)
* [Sales.SpecialOfferProduct](../Sales/SpecialOfferProduct.md)

