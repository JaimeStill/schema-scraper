# Production.WorkOrderRouting

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionworkorderrouting)

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
[Back to Top](#productionworkorderrouting)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.WorkOrderRouting`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.WorkOrderRouting`.

### Dependencies
[Back to Top](#productionworkorderrouting)


**Table** refers to the table that the foreign key defined by `Production.WorkOrderRouting` maps to.

**Foreign Key** is the column in `Production.WorkOrderRouting` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Location](./Location.md) | `LocationID` | `LocationID` | **FK_WorkOrderRouting_Location_LocationID**
[Production.WorkOrder](./WorkOrder.md) | `WorkOrderID` | `WorkOrderID` | **FK_WorkOrderRouting_WorkOrder_WorkOrderID**

### Dependents
[Back to Top](#productionworkorderrouting)

No dependencies defined

## Maps
[Back to Top](#productionworkorderrouting)

### Dependency Map
[Back to Top](#productionworkorderrouting)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.WorkOrderRouting.

* [Production.Location](./Location.md)
* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ScrapReason](./ScrapReason.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Production.WorkOrder](./WorkOrder.md)

### Dependent Map
[Back to Top](#productionworkorderrouting)

Production.WorkOrderRouting has no dependents

