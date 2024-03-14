# ProductModel

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productmodel)

Column | Type | Is Nullable
-------|------|------------
**ProductModelID** | `int` | False
**Name** | `nvarchar` | False
**CatalogDescription** | `xml` | True
**Instructions** | `xml` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productmodel)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `ProductModel`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductModel`.

### Dependencies
[Back to Top](#productmodel)

**Dependency Table** refers to the table that the foreign key defined by `ProductModel` maps to.

**Foreign Key Column** is the column in `ProductModel` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#productmodel)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductModel.

**Dependency Key Column** is the column in ProductModel that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Product](./Product.md) | **FK_Product_ProductModel_ProductModelID** | `ProductModelID` | `ProductModelID`
[ProductModelIllustration](./ProductModelIllustration.md) | **FK_ProductModelIllustration_ProductModel_ProductModelID** | `ProductModelID` | `ProductModelID`
[ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | **FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID** | `ProductModelID` | `ProductModelID`

## Dependency Map
[Back to Top](#productmodel)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductModel.

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
* [ProductModelIllustration](./ProductModelIllustration.md)
* [ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
