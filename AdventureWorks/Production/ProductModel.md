# Production.ProductModel

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.ProductModel`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductModel`.

### Dependencies
[Back to Top](#productmodel)


No dependencies defined

### Dependents
[Back to Top](#productmodel)

**Table** refers to the table that defines a foreign key mapping to ProductModel.

**Primary Key** is the column in ProductModel that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductModelID` | `ProductModelID` | **FK_Product_ProductModel_ProductModelID**
[Production.ProductModelIllustration](./ProductModelIllustration.md) | `ProductModelID` | `ProductModelID` | **FK_ProductModelIllustration_ProductModel_ProductModelID**
[Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | `ProductModelID` | `ProductModelID` | **FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID**

## Maps
[Back to Top](#productmodel)

### Dependency Map
[Back to Top](#productmodel)

ProductModel has no dependencies
### Dependent Map
[Back to Top](#productmodel)

> The following is a distinct list of tables captured by recursively evaluating tables that list ProductModel as a foreign key dependency.

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
* [Production.ProductModelIllustration](./ProductModelIllustration.md)
* [Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
