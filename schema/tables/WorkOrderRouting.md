# WorkOrderRouting

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#workorderrouting)

Column | Type | Is Nullable
-------|------|------------
**WorkOrderID** | `int` | False
**ProductID** | `int` | False
**OperationSequence** | `smallint` | False
**LocationID** | `smallint` | False
**ScheduledStartDate** | `datetime` | False
**ScheduledEndDate** | `datetime` | False
**ActualStartDate** | `datetime` | True
**ActualEndDate** | `datetime` | True
**ActualResourceHrs** | `decimal` | True
**PlannedCost** | `money` | False
**ActualCost** | `money` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#workorderrouting)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `WorkOrderRouting`.
* **Dependents** - foreign key relationships defined by other tables that reference `WorkOrderRouting`.

### Dependencies
[Back to Top](#workorderrouting)

**Dependency Table** refers to the table that the foreign key defined by `WorkOrderRouting` maps to.

**Foreign Key Column** is the column in `WorkOrderRouting` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_WorkOrderRouting_Location_LocationID** | `LocationID` | [Location](./Location.md) | `LocationID`
**FK_WorkOrderRouting_WorkOrder_WorkOrderID** | `WorkOrderID` | [WorkOrder](./WorkOrder.md) | `WorkOrderID`

### Dependents
[Back to Top](#workorderrouting)

**Dependent Table** refers to the table that defines a foreign key mapping to WorkOrderRouting.

**Dependency Key Column** is the column in WorkOrderRouting that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#workorderrouting)

WorkOrderRouting has no dependencies.
