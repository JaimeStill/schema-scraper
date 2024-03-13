# ProductCategory

* [Relationships](#relationships)
* [Columns](#columns)
* [Dependency Map](#dependency-map)

## Relationships
[Back to Top](#productcategory)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID** | `ParentProductCategoryID` | ProductCategory | `ProductCategoryID`

## Columns
[Back to Top](#productcategory)

Column | Type | Is Nullable
-------|------|------------
**ProductCategoryID** | `int` | False
**ParentProductCategoryID** | `int` | True
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#productcategory)

ProductCategory has no dependencies.
