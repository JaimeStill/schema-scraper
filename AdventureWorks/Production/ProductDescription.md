# Production.ProductDescription

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductdescription)

Column | Type | Is Nullable
-------|------|------------
**ProductDescriptionID** | `int` | False
**Description** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductdescription)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductDescription`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductDescription`.

### Dependencies
[Back to Top](#productionproductdescription)


No dependencies defined

### Dependents
[Back to Top](#productionproductdescription)

**Table** refers to the table that defines a foreign key mapping to Production.ProductDescription.

**Primary Key** is the column in Production.ProductDescription that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | `ProductDescriptionID` | `ProductDescriptionID` | **FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID**

## Maps
[Back to Top](#productionproductdescription)

### Dependency Map
[Back to Top](#productionproductdescription)

Production.ProductDescription has no dependencies

### Dependent Map
[Back to Top](#productionproductdescription)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.ProductDescription as a foreign key dependency.

* [Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)

