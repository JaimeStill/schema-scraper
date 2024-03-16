# Production.ScrapReason

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#scrapreason)

Column | Type | Is Nullable
-------|------|------------
**ScrapReasonID** | `smallint` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#scrapreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ScrapReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ScrapReason`.

### Dependencies
[Back to Top](#scrapreason)


No dependencies defined

### Dependents
[Back to Top](#scrapreason)

**Table** refers to the table that defines a foreign key mapping to ScrapReason.

**Primary Key** is the column in ScrapReason that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.WorkOrder](./WorkOrder.md) | `ScrapReasonID` | `ScrapReasonID` | **FK_WorkOrder_ScrapReason_ScrapReasonID**

## Maps
[Back to Top](#scrapreason)

### Dependency Map
[Back to Top](#scrapreason)

ScrapReason has no dependencies
### Dependent Map
[Back to Top](#scrapreason)

> The following is a distinct list of tables captured by recursively evaluating tables that list ScrapReason as a foreign key dependency.

* [Production.WorkOrder](./WorkOrder.md)
* [Production.WorkOrderRouting](./WorkOrderRouting.md)
