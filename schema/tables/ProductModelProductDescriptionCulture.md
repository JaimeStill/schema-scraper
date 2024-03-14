# ProductModelProductDescriptionCulture

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
* **Dependencies** - foreign key relationships defined by `ProductModelProductDescriptionCulture`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductModelProductDescriptionCulture`.

### Dependencies
[Back to Top](#productmodelproductdescriptionculture)

**Dependency Table** refers to the table that the foreign key defined by `ProductModelProductDescriptionCulture` maps to.

**Foreign Key Column** is the column in `ProductModelProductDescriptionCulture` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductModelProductDescriptionCulture_Culture_CultureID** | `CultureID` | [Culture](./Culture.md) | `CultureID`
**FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID** | `ProductDescriptionID` | [ProductDescription](./ProductDescription.md) | `ProductDescriptionID`
**FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID** | `ProductModelID` | [ProductModel](./ProductModel.md) | `ProductModelID`

### Dependents
[Back to Top](#productmodelproductdescriptionculture)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductModelProductDescriptionCulture.

**Dependency Key Column** is the column in ProductModelProductDescriptionCulture that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productmodelproductdescriptionculture)

ProductModelProductDescriptionCulture has no dependencies.
