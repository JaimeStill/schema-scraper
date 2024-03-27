# Production.Illustration

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionillustration)

Column | Type | Is Nullable
-------|------|------------
**IllustrationID** | `int` | False
**Diagram** | `xml` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionillustration)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.Illustration`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Illustration`.

### Dependencies
[Back to Top](#productionillustration)


No dependencies defined

### Dependents
[Back to Top](#productionillustration)

**Table** refers to the table that defines a foreign key mapping to Production.Illustration.

**Primary Key** is the column in Production.Illustration that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelIllustration](./ProductModelIllustration.md) | `IllustrationID` | `IllustrationID` | **FK_ProductModelIllustration_Illustration_IllustrationID**

## Maps
[Back to Top](#productionillustration)

### Dependency Map
[Back to Top](#productionillustration)

Production.Illustration has no dependencies

### Dependent Map
[Back to Top](#productionillustration)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.Illustration as a foreign key dependency.

* [Production.ProductModelIllustration](./ProductModelIllustration.md)

