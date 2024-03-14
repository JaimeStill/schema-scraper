# Culture

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#culture)

Column | Type | Is Nullable
-------|------|------------
**CultureID** | `nchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#culture)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Culture`.
* **Dependents** - foreign key relationships defined by other tables that reference `Culture`.

### Dependencies
[Back to Top](#culture)

**Dependency Table** refers to the table that the foreign key defined by `Culture` maps to.

**Foreign Key Column** is the column in `Culture` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#culture)

**Dependent Table** refers to the table that defines a foreign key mapping to Culture.

**Dependency Key Column** is the column in Culture that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | **FK_ProductModelProductDescriptionCulture_Culture_CultureID** | `CultureID` | `CultureID`

## Dependency Map
[Back to Top](#culture)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Culture.

* [ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
