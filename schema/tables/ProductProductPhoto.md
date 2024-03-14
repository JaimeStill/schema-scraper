# ProductProductPhoto

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
* **Dependencies** - foreign key relationships defined by `ProductProductPhoto`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductProductPhoto`.

### Dependencies
[Back to Top](#productproductphoto)

**Dependency Table** refers to the table that the foreign key defined by `ProductProductPhoto` maps to.

**Foreign Key Column** is the column in `ProductProductPhoto` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductProductPhoto_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_ProductProductPhoto_ProductPhoto_ProductPhotoID** | `ProductPhotoID` | [ProductPhoto](./ProductPhoto.md) | `ProductPhotoID`

### Dependents
[Back to Top](#productproductphoto)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductProductPhoto.

**Dependency Key Column** is the column in ProductProductPhoto that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productproductphoto)

ProductProductPhoto has no dependencies.
