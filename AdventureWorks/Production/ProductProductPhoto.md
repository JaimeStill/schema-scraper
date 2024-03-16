# Production.ProductProductPhoto

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductproductphoto)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**ProductPhotoID** | `int` | False
**Primary** | `bit` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductproductphoto)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductProductPhoto`.

### Dependencies
[Back to Top](#productionproductproductphoto)


**Table** refers to the table that the foreign key defined by `Production.ProductProductPhoto` maps to.

**Foreign Key** is the column in `Production.ProductProductPhoto` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductProductPhoto_Product_ProductID**
[Production.ProductPhoto](./ProductPhoto.md) | `ProductPhotoID` | `ProductPhotoID` | **FK_ProductProductPhoto_ProductPhoto_ProductPhotoID**

### Dependents
[Back to Top](#productionproductproductphoto)

No dependencies defined

## Maps
[Back to Top](#productionproductproductphoto)

### Dependency Map
[Back to Top](#productionproductproductphoto)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductProductPhoto.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Production.ProductPhoto](./ProductPhoto.md)
### Dependent Map
[Back to Top](#productionproductproductphoto)

Production.ProductProductPhoto has no dependents
