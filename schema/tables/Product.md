# Product

* [Relationships](#relationships)
* [Columns](#columns)
* [Dependency Map](#dependency-map)

## Relationships
[Back to Top](#product)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Product_ProductCategory_ProductCategoryID** | `ProductCategoryID` | [ProductCategory](./ProductCategory.md) | `ProductCategoryID`
**FK_Product_ProductModel_ProductModelID** | `ProductModelID` | [ProductModel](./ProductModel.md) | `ProductModelID`

## Columns
[Back to Top](#product)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**Name** | `nvarchar` | False
**ProductNumber** | `nvarchar` | False
**Color** | `nvarchar` | True
**StandardCost** | `money` | False
**ListPrice** | `money` | False
**Size** | `nvarchar` | True
**Weight** | `decimal` | True
**ProductCategoryID** | `int` | True
**ProductModelID** | `int` | True
**SellStartDate** | `datetime` | False
**SellEndDate** | `datetime` | True
**DiscontinuedDate** | `datetime` | True
**ThumbNailPhoto** | `varbinary` | True
**ThumbnailPhotoFileName** | `nvarchar` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#product)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Product.

* [ProductCategory](./ProductCategory.md)
* [ProductModel](./ProductModel.md)
