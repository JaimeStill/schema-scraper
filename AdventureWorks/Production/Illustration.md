# Production.Illustration

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.Illustration`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Illustration`.

### Dependencies
[Back to Top](#illustration)


No dependencies defined

### Dependents
[Back to Top](#illustration)

**Table** refers to the table that defines a foreign key mapping to Illustration.

**Primary Key** is the column in Illustration that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelIllustration](./ProductModelIllustration.md) | `IllustrationID` | `IllustrationID` | **FK_ProductModelIllustration_Illustration_IllustrationID**

## Maps
[Back to Top](#illustration)

### Dependency Map
[Back to Top](#illustration)

Illustration has no dependencies
### Dependent Map
[Back to Top](#illustration)

> The following is a distinct list of tables captured by recursively evaluating tables that list Illustration as a foreign key dependency.

* [Production.ProductModelIllustration](./ProductModelIllustration.md)
