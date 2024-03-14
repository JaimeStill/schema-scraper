# BillOfMaterials

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#billofmaterials)

Column | Type | Is Nullable
-------|------|------------
**BillOfMaterialsID** | `int` | False
**ProductAssemblyID** | `int` | True
**ComponentID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**UnitMeasureCode** | `nchar` | False
**BOMLevel** | `smallint` | False
**PerAssemblyQty** | `decimal` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#billofmaterials)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `BillOfMaterials`.
* **Dependents** - foreign key relationships defined by other tables that reference `BillOfMaterials`.

### Dependencies
[Back to Top](#billofmaterials)

**Dependency Table** refers to the table that the foreign key defined by `BillOfMaterials` maps to.

**Foreign Key Column** is the column in `BillOfMaterials` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_BillOfMaterials_Product_ProductAssemblyID** | `ProductAssemblyID` | [Product](./Product.md) | `ProductID`
**FK_BillOfMaterials_Product_ComponentID** | `ComponentID` | [Product](./Product.md) | `ProductID`
**FK_BillOfMaterials_UnitMeasure_UnitMeasureCode** | `UnitMeasureCode` | [UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode`

### Dependents
[Back to Top](#billofmaterials)

**Dependent Table** refers to the table that defines a foreign key mapping to BillOfMaterials.

**Dependency Key Column** is the column in BillOfMaterials that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#billofmaterials)

BillOfMaterials has no dependencies.
