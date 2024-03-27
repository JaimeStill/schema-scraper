# Production.ProductInventory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductinventory)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**LocationID** | `smallint` | False
**Shelf** | `nvarchar` | False
**Bin** | `tinyint` | False
**Quantity** | `smallint` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductinventory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductInventory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductInventory`.

### Dependencies
[Back to Top](#productionproductinventory)


**Table** refers to the table that the foreign key defined by `Production.ProductInventory` maps to.

**Foreign Key** is the column in `Production.ProductInventory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Location](./Location.md) | `LocationID` | `LocationID` | **FK_ProductInventory_Location_LocationID**
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductInventory_Product_ProductID**

### Dependents
[Back to Top](#productionproductinventory)

No dependencies defined

## Maps
[Back to Top](#productionproductinventory)

### Dependency Map
[Back to Top](#productionproductinventory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductInventory.

* [Production.Location](./Location.md)
* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productionproductinventory)

Production.ProductInventory has no dependents

