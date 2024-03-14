# Illustration

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#illustration)

Column | Type | Is Nullable
-------|------|------------
**IllustrationID** | `int` | False
**Diagram** | `xml` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#illustration)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Illustration`.
* **Dependents** - foreign key relationships defined by other tables that reference `Illustration`.

### Dependencies
[Back to Top](#illustration)

**Dependency Table** refers to the table that the foreign key defined by `Illustration` maps to.

**Foreign Key Column** is the column in `Illustration` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#illustration)

**Dependent Table** refers to the table that defines a foreign key mapping to Illustration.

**Dependency Key Column** is the column in Illustration that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductModelIllustration](./ProductModelIllustration.md) | **FK_ProductModelIllustration_Illustration_IllustrationID** | `IllustrationID` | `IllustrationID`

## Dependency Map
[Back to Top](#illustration)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Illustration.

* [ProductModelIllustration](./ProductModelIllustration.md)
