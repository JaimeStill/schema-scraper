# Production.BillOfMaterials

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionbillofmaterials)

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
[Back to Top](#productionbillofmaterials)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.BillOfMaterials`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.BillOfMaterials`.

### Dependencies
[Back to Top](#productionbillofmaterials)


**Table** refers to the table that the foreign key defined by `Production.BillOfMaterials` maps to.

**Foreign Key** is the column in `Production.BillOfMaterials` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductAssemblyID` | **FK_BillOfMaterials_Product_ProductAssemblyID**
[Production.Product](./Product.md) | `ProductID` | `ComponentID` | **FK_BillOfMaterials_Product_ComponentID**
[Production.UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode` | `UnitMeasureCode` | **FK_BillOfMaterials_UnitMeasure_UnitMeasureCode**

### Dependents
[Back to Top](#productionbillofmaterials)

No dependencies defined

## Maps
[Back to Top](#productionbillofmaterials)

### Dependency Map
[Back to Top](#productionbillofmaterials)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.BillOfMaterials.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productionbillofmaterials)

Production.BillOfMaterials has no dependents
