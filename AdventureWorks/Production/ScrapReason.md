# Production.ScrapReason

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionscrapreason)

Column | Type | Is Nullable
-------|------|------------
**ScrapReasonID** | `smallint` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionscrapreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ScrapReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ScrapReason`.

### Dependencies
[Back to Top](#productionscrapreason)


No dependencies defined

### Dependents
[Back to Top](#productionscrapreason)

**Table** refers to the table that defines a foreign key mapping to Production.ScrapReason.

**Primary Key** is the column in Production.ScrapReason that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.WorkOrder](./WorkOrder.md) | `ScrapReasonID` | `ScrapReasonID` | **FK_WorkOrder_ScrapReason_ScrapReasonID**

## Maps
[Back to Top](#productionscrapreason)

### Dependency Map
[Back to Top](#productionscrapreason)

Production.ScrapReason has no dependencies
### Dependent Map
[Back to Top](#productionscrapreason)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.ScrapReason as a foreign key dependency.

* [Production.WorkOrder](./WorkOrder.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
