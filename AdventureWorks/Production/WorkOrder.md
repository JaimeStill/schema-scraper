# Production.WorkOrder

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionworkorder)

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
[Back to Top](#productionworkorder)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.WorkOrder`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.WorkOrder`.

### Dependencies
[Back to Top](#productionworkorder)


**Table** refers to the table that the foreign key defined by `Production.WorkOrder` maps to.

**Foreign Key** is the column in `Production.WorkOrder` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_WorkOrder_Product_ProductID**
[Production.ScrapReason](./ScrapReason.md) | `ScrapReasonID` | `ScrapReasonID` | **FK_WorkOrder_ScrapReason_ScrapReasonID**

### Dependents
[Back to Top](#productionworkorder)

**Table** refers to the table that defines a foreign key mapping to Production.WorkOrder.

**Primary Key** is the column in Production.WorkOrder that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.WorkOrderRouting](./WorkOrderRouting.md) | `WorkOrderID` | `WorkOrderID` | **FK_WorkOrderRouting_WorkOrder_WorkOrderID**

## Maps
[Back to Top](#productionworkorder)

### Dependency Map
[Back to Top](#productionworkorder)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.WorkOrder.

* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ScrapReason](./ScrapReason.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productionworkorder)

> The following is a distinct list of tables captured by recursively evaluating tables that list Production.WorkOrder as a foreign key dependency.

* [Production.WorkOrderRouting](./WorkOrderRouting.md)

