# WorkOrder

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#workorder)

Column | Type | Is Nullable
-------|------|------------
**WorkOrderID** | `int` | False
**ProductID** | `int` | False
**OrderQty** | `int` | False
**StockedQty** | `int` | False
**ScrappedQty** | `smallint` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**DueDate** | `datetime` | False
**ScrapReasonID** | `smallint` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#workorder)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `WorkOrder`.
* **Dependents** - foreign key relationships defined by other tables that reference `WorkOrder`.

### Dependencies
[Back to Top](#workorder)

**Dependency Table** refers to the table that the foreign key defined by `WorkOrder` maps to.

**Foreign Key Column** is the column in `WorkOrder` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_WorkOrder_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_WorkOrder_ScrapReason_ScrapReasonID** | `ScrapReasonID` | [ScrapReason](./ScrapReason.md) | `ScrapReasonID`

### Dependents
[Back to Top](#workorder)

**Dependent Table** refers to the table that defines a foreign key mapping to WorkOrder.

**Dependency Key Column** is the column in WorkOrder that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[WorkOrderRouting](./WorkOrderRouting.md) | **FK_WorkOrderRouting_WorkOrder_WorkOrderID** | `WorkOrderID` | `WorkOrderID`

## Dependency Map
[Back to Top](#workorder)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table WorkOrder.

* [WorkOrderRouting](./WorkOrderRouting.md)
