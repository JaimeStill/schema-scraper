# ProductPhoto

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
* **Dependencies** - foreign key relationships defined by `ProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductPhoto`.

### Dependencies
[Back to Top](#productphoto)

**Dependency Table** refers to the table that the foreign key defined by `ProductPhoto` maps to.

**Foreign Key Column** is the column in `ProductPhoto` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#productphoto)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductPhoto.

**Dependency Key Column** is the column in ProductPhoto that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductProductPhoto](./ProductProductPhoto.md) | **FK_ProductProductPhoto_ProductPhoto_ProductPhotoID** | `ProductPhotoID` | `ProductPhotoID`

## Dependency Map
[Back to Top](#productphoto)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductPhoto.

* [ProductProductPhoto](./ProductProductPhoto.md)
