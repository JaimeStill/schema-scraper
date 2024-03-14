# ScrapReason

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
* **Dependencies** - foreign key relationships defined by `ScrapReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `ScrapReason`.

### Dependencies
[Back to Top](#scrapreason)

**Dependency Table** refers to the table that the foreign key defined by `ScrapReason` maps to.

**Foreign Key Column** is the column in `ScrapReason` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#scrapreason)

**Dependent Table** refers to the table that defines a foreign key mapping to ScrapReason.

**Dependency Key Column** is the column in ScrapReason that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[WorkOrder](./WorkOrder.md) | **FK_WorkOrder_ScrapReason_ScrapReasonID** | `ScrapReasonID` | `ScrapReasonID`

## Dependency Map
[Back to Top](#scrapreason)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ScrapReason.

* [WorkOrder](./WorkOrder.md)
* [WorkOrderRouting](./WorkOrderRouting.md)
