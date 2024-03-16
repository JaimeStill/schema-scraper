# Production.ProductModelProductDescriptionCulture

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productmodelproductdescriptionculture)

Column | Type | Is Nullable
-------|------|------------
**ProductModelID** | `int` | False
**ProductDescriptionID** | `int` | False
**CultureID** | `nchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productmodelproductdescriptionculture)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductModelProductDescriptionCulture`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductModelProductDescriptionCulture`.

### Dependencies
[Back to Top](#productmodelproductdescriptionculture)


**Table** refers to the table that the foreign key defined by `Production.ProductModelProductDescriptionCulture` maps to.

**Foreign Key** is the column in `Production.ProductModelProductDescriptionCulture` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Culture](./Culture.md) | `CultureID` | `CultureID` | **FK_ProductModelProductDescriptionCulture_Culture_CultureID**
[Production.ProductDescription](./ProductDescription.md) | `ProductDescriptionID` | `ProductDescriptionID` | **FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID**
[Production.ProductModel](./ProductModel.md) | `ProductModelID` | `ProductModelID` | **FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID**

### Dependents
[Back to Top](#productmodelproductdescriptionculture)

No dependencies defined

## Maps
[Back to Top](#productmodelproductdescriptionculture)

### Dependency Map
[Back to Top](#productmodelproductdescriptionculture)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductModelProductDescriptionCulture.

* [Production.Culture](./Culture.md)
* [Production.ProductDescription](./ProductDescription.md)
* [Production.ProductModel](./ProductModel.md)
### Dependent Map
[Back to Top](#productmodelproductdescriptionculture)

ProductModelProductDescriptionCulture has no dependents
