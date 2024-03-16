# Production.Culture

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionculture)

Column | Type | Is Nullable
-------|------|------------
**CultureID** | `nchar` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionculture)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.Culture`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Culture`.

### Dependencies
[Back to Top](#productionculture)


No dependencies defined

### Dependents
[Back to Top](#productionculture)

**Table** refers to the table that defines a foreign key mapping to Production.Culture.

**Primary Key** is the column in Production.Culture that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | `CultureID` | `CultureID` | **FK_ProductModelProductDescriptionCulture_Culture_CultureID**

## Maps
[Back to Top](#productionculture)

### Dependency Map
[Back to Top](#productionculture)

Production.Culture has no dependencies
### Dependent Map
[Back to Top](#productionculture)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.Culture as a foreign key dependency.

* [Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
