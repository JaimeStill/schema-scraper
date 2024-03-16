# Production.ProductPhoto

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productphoto)

Column | Type | Is Nullable
-------|------|------------
**ProductPhotoID** | `int` | False
**ThumbNailPhoto** | `varbinary` | True
**ThumbnailPhotoFileName** | `nvarchar` | True
**LargePhoto** | `varbinary` | True
**LargePhotoFileName** | `nvarchar` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productphoto)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductPhoto`.

### Dependencies
[Back to Top](#productphoto)


No dependencies defined

### Dependents
[Back to Top](#productphoto)

**Table** refers to the table that defines a foreign key mapping to ProductPhoto.

**Primary Key** is the column in ProductPhoto that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductProductPhoto](./ProductProductPhoto.md) | `ProductPhotoID` | `ProductPhotoID` | **FK_ProductProductPhoto_ProductPhoto_ProductPhotoID**

## Maps
[Back to Top](#productphoto)

### Dependency Map
[Back to Top](#productphoto)

ProductPhoto has no dependencies
### Dependent Map
[Back to Top](#productphoto)

> The following is a distinct list of tables captured by recursively evaluating tables that list ProductPhoto as a foreign key dependency.

* [Production.ProductProductPhoto](./ProductProductPhoto.md)
