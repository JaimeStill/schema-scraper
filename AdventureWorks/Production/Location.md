# Production.Location

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.Location`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Location`.

### Dependencies
[Back to Top](#location)


No dependencies defined

### Dependents
[Back to Top](#location)

**Table** refers to the table that defines a foreign key mapping to Location.

**Primary Key** is the column in Location that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductInventory](./ProductInventory.md) | `LocationID` | `LocationID` | **FK_ProductInventory_Location_LocationID**
[Production.WorkOrderRouting](./WorkOrderRouting.md) | `LocationID` | `LocationID` | **FK_WorkOrderRouting_Location_LocationID**

## Maps
[Back to Top](#location)

### Dependency Map
[Back to Top](#location)

Location has no dependencies
### Dependent Map
[Back to Top](#location)

> The following is a distinct list of tables captured by recursively evaluating tables that list Location as a foreign key dependency.

* [Production.ProductInventory](./ProductInventory.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
