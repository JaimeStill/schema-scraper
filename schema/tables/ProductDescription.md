# ProductDescription

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productdescription)

Column | Type | Is Nullable
-------|------|------------
**ProductDescriptionID** | `int` | False
**Description** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productdescription)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `ProductDescription`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductDescription`.

### Dependencies
[Back to Top](#productdescription)

**Dependency Table** refers to the table that the foreign key defined by `ProductDescription` maps to.

**Foreign Key Column** is the column in `ProductDescription` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#productdescription)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductDescription.

**Dependency Key Column** is the column in ProductDescription that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | **FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID** | `ProductDescriptionID` | `ProductDescriptionID`

## Dependency Map
[Back to Top](#productdescription)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductDescription.

* [ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
