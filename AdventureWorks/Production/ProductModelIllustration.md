# Production.ProductModelIllustration

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productmodelillustration)

Column | Type | Is Nullable
-------|------|------------
**ProductModelID** | `int` | False
**IllustrationID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productmodelillustration)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductModelIllustration`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductModelIllustration`.

### Dependencies
[Back to Top](#productmodelillustration)


**Table** refers to the table that the foreign key defined by `Production.ProductModelIllustration` maps to.

**Foreign Key** is the column in `Production.ProductModelIllustration` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Illustration](./Illustration.md) | `IllustrationID` | `IllustrationID` | **FK_ProductModelIllustration_Illustration_IllustrationID**
[Production.ProductModel](./ProductModel.md) | `ProductModelID` | `ProductModelID` | **FK_ProductModelIllustration_ProductModel_ProductModelID**

### Dependents
[Back to Top](#productmodelillustration)

No dependencies defined

## Maps
[Back to Top](#productmodelillustration)

### Dependency Map
[Back to Top](#productmodelillustration)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductModelIllustration.

* [Production.Illustration](./Illustration.md)
* [Production.ProductModel](./ProductModel.md)
### Dependent Map
[Back to Top](#productmodelillustration)

ProductModelIllustration has no dependents
