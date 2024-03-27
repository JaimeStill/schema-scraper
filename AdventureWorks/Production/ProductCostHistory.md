# Production.ProductCostHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductcosthistory)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**StandardCost** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductcosthistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductCostHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductCostHistory`.

### Dependencies
[Back to Top](#productionproductcosthistory)


**Table** refers to the table that the foreign key defined by `Production.ProductCostHistory` maps to.

**Foreign Key** is the column in `Production.ProductCostHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductCostHistory_Product_ProductID**

### Dependents
[Back to Top](#productionproductcosthistory)

No dependencies defined

## Maps
[Back to Top](#productionproductcosthistory)

### Dependency Map
[Back to Top](#productionproductcosthistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductCostHistory.

* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productionproductcosthistory)

Production.ProductCostHistory has no dependents

