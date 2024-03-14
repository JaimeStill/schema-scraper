# ProductSubcategory

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productsubcategory)

Column | Type | Is Nullable
-------|------|------------
**ProductSubcategoryID** | `int` | False
**ProductCategoryID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productsubcategory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `ProductSubcategory`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductSubcategory`.

### Dependencies
[Back to Top](#productsubcategory)

**Dependency Table** refers to the table that the foreign key defined by `ProductSubcategory` maps to.

**Foreign Key Column** is the column in `ProductSubcategory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductSubcategory_ProductCategory_ProductCategoryID** | `ProductCategoryID` | [ProductCategory](./ProductCategory.md) | `ProductCategoryID`

### Dependents
[Back to Top](#productsubcategory)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductSubcategory.

**Dependency Key Column** is the column in ProductSubcategory that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Product](./Product.md) | **FK_Product_ProductSubcategory_ProductSubcategoryID** | `ProductSubcategoryID` | `ProductSubcategoryID`

## Dependency Map
[Back to Top](#productsubcategory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductSubcategory.

* [Product](./Product.md)
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
