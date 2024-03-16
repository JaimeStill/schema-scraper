# Production.ProductInventory

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productinventory)

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
[Back to Top](#productinventory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductInventory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductInventory`.

### Dependencies
[Back to Top](#productinventory)


**Table** refers to the table that the foreign key defined by `Production.ProductInventory` maps to.

**Foreign Key** is the column in `Production.ProductInventory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Location](./Location.md) | `LocationID` | `LocationID` | **FK_ProductInventory_Location_LocationID**
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductInventory_Product_ProductID**

### Dependents
[Back to Top](#productinventory)

No dependencies defined

## Maps
[Back to Top](#productinventory)

### Dependency Map
[Back to Top](#productinventory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductInventory.

* [Production.Location](./Location.md)
* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productinventory)

ProductInventory has no dependents