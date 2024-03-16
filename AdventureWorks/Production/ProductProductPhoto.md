# Production.ProductProductPhoto

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productproductphoto)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**ProductPhotoID** | `int` | False
**Primary** | `bit` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productproductphoto)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductProductPhoto`.

### Dependencies
[Back to Top](#productproductphoto)


**Table** refers to the table that the foreign key defined by `Production.ProductProductPhoto` maps to.

**Foreign Key** is the column in `Production.ProductProductPhoto` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductProductPhoto_Product_ProductID**
[Production.ProductPhoto](./ProductPhoto.md) | `ProductPhotoID` | `ProductPhotoID` | **FK_ProductProductPhoto_ProductPhoto_ProductPhotoID**

### Dependents
[Back to Top](#productproductphoto)

No dependencies defined

## Maps
[Back to Top](#productproductphoto)

### Dependency Map
[Back to Top](#productproductphoto)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductProductPhoto.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Production.ProductPhoto](./ProductPhoto.md)
### Dependent Map
[Back to Top](#productproductphoto)

ProductProductPhoto has no dependents
