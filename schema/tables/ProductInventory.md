# ProductInventory

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
* **Dependencies** - foreign key relationships defined by `ProductInventory`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductInventory`.

### Dependencies
[Back to Top](#productinventory)

**Dependency Table** refers to the table that the foreign key defined by `ProductInventory` maps to.

**Foreign Key Column** is the column in `ProductInventory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductInventory_Location_LocationID** | `LocationID` | [Location](./Location.md) | `LocationID`
**FK_ProductInventory_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#productinventory)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductInventory.

**Dependency Key Column** is the column in ProductInventory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productinventory)

ProductInventory has no dependencies.
