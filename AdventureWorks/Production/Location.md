# Production.Location

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionlocation)

Column | Type | Is Nullable
-------|------|------------
**LocationID** | `smallint` | False
**Name** | `nvarchar` | False
**CostRate** | `smallmoney` | False
**Availability** | `decimal` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionlocation)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.Location`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Location`.

### Dependencies
[Back to Top](#productionlocation)


No dependencies defined

### Dependents
[Back to Top](#productionlocation)

**Table** refers to the table that defines a foreign key mapping to Production.Location.

**Primary Key** is the column in Production.Location that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductInventory](./ProductInventory.md) | `LocationID` | `LocationID` | **FK_ProductInventory_Location_LocationID**
[Production.WorkOrderRouting](./WorkOrderRouting.md) | `LocationID` | `LocationID` | **FK_WorkOrderRouting_Location_LocationID**

## Maps
[Back to Top](#productionlocation)

### Dependency Map
[Back to Top](#productionlocation)

Production.Location has no dependencies
### Dependent Map
[Back to Top](#productionlocation)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.Location as a foreign key dependency.

* [Production.ProductInventory](./ProductInventory.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
