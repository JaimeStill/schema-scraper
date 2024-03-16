# Production.ProductPhoto

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductphoto)

Column | Type | Is Nullable
-------|------|------------
**ProductPhotoID** | `int` | False
**ThumbNailPhoto** | `varbinary` | True
**ThumbnailPhotoFileName** | `nvarchar` | True
**LargePhoto** | `varbinary` | True
**LargePhotoFileName** | `nvarchar` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductphoto)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductPhoto`.

### Dependencies
[Back to Top](#productionproductphoto)


No dependencies defined

### Dependents
[Back to Top](#productionproductphoto)

**Table** refers to the table that defines a foreign key mapping to Production.ProductPhoto.

**Primary Key** is the column in Production.ProductPhoto that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductProductPhoto](./ProductProductPhoto.md) | `ProductPhotoID` | `ProductPhotoID` | **FK_ProductProductPhoto_ProductPhoto_ProductPhotoID**

## Maps
[Back to Top](#productionproductphoto)

### Dependency Map
[Back to Top](#productionproductphoto)

Production.ProductPhoto has no dependencies
### Dependent Map
[Back to Top](#productionproductphoto)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.ProductPhoto as a foreign key dependency.

* [Production.ProductProductPhoto](./ProductProductPhoto.md)
