# Production.Culture

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.Culture`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Culture`.

### Dependencies
[Back to Top](#culture)


No dependencies defined

### Dependents
[Back to Top](#culture)

**Table** refers to the table that defines a foreign key mapping to Culture.

**Primary Key** is the column in Culture that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | `CultureID` | `CultureID` | **FK_ProductModelProductDescriptionCulture_Culture_CultureID**

## Maps
[Back to Top](#culture)

### Dependency Map
[Back to Top](#culture)

Culture has no dependencies
### Dependent Map
[Back to Top](#culture)

> The following is a distinct list of tables captured by recursively evaluating tables that list Culture as a foreign key dependency.

* [Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
