# ProductCategory

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
* **Dependencies** - foreign key relationships defined by `ProductCategory`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductCategory`.

### Dependencies
[Back to Top](#productcategory)

**Dependency Table** refers to the table that the foreign key defined by `ProductCategory` maps to.

**Foreign Key Column** is the column in `ProductCategory` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#productcategory)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductCategory.

**Dependency Key Column** is the column in ProductCategory that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductSubcategory](./ProductSubcategory.md) | **FK_ProductSubcategory_ProductCategory_ProductCategoryID** | `ProductCategoryID` | `ProductCategoryID`

## Dependency Map
[Back to Top](#productcategory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductCategory.

* [ProductSubcategory](./ProductSubcategory.md)
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
