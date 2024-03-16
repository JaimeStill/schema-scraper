# Production.ProductDescription

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.ProductDescription`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductDescription`.

### Dependencies
[Back to Top](#productdescription)


No dependencies defined

### Dependents
[Back to Top](#productdescription)

**Table** refers to the table that defines a foreign key mapping to ProductDescription.

**Primary Key** is the column in ProductDescription that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md) | `ProductDescriptionID` | `ProductDescriptionID` | **FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID**

## Maps
[Back to Top](#productdescription)

### Dependency Map
[Back to Top](#productdescription)

ProductDescription has no dependencies
### Dependent Map
[Back to Top](#productdescription)

> The following is a distinct list of tables captured by recursively evaluating tables that list ProductDescription as a foreign key dependency.

* [Production.ProductModelProductDescriptionCulture](./ProductModelProductDescriptionCulture.md)
