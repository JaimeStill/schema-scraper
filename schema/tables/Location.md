# Location

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#location)

Column | Type | Is Nullable
-------|------|------------
**LocationID** | `smallint` | False
**Name** | `nvarchar` | False
**CostRate** | `smallmoney` | False
**Availability** | `decimal` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#location)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Location`.
* **Dependents** - foreign key relationships defined by other tables that reference `Location`.

### Dependencies
[Back to Top](#location)

**Dependency Table** refers to the table that the foreign key defined by `Location` maps to.

**Foreign Key Column** is the column in `Location` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#location)

**Dependent Table** refers to the table that defines a foreign key mapping to Location.

**Dependency Key Column** is the column in Location that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductInventory](./ProductInventory.md) | **FK_ProductInventory_Location_LocationID** | `LocationID` | `LocationID`
[WorkOrderRouting](./WorkOrderRouting.md) | **FK_WorkOrderRouting_Location_LocationID** | `LocationID` | `LocationID`

## Dependency Map
[Back to Top](#location)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Location.

* [ProductInventory](./ProductInventory.md)
* [WorkOrderRouting](./WorkOrderRouting.md)
