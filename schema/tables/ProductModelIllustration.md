# ProductModelIllustration

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
* **Dependencies** - foreign key relationships defined by `ProductModelIllustration`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductModelIllustration`.

### Dependencies
[Back to Top](#productmodelillustration)

**Dependency Table** refers to the table that the foreign key defined by `ProductModelIllustration` maps to.

**Foreign Key Column** is the column in `ProductModelIllustration` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductModelIllustration_Illustration_IllustrationID** | `IllustrationID` | [Illustration](./Illustration.md) | `IllustrationID`
**FK_ProductModelIllustration_ProductModel_ProductModelID** | `ProductModelID` | [ProductModel](./ProductModel.md) | `ProductModelID`

### Dependents
[Back to Top](#productmodelillustration)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductModelIllustration.

**Dependency Key Column** is the column in ProductModelIllustration that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productmodelillustration)

ProductModelIllustration has no dependencies.
