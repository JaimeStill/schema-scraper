# Production.ProductCostHistory

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productcosthistory)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**StandardCost** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productcosthistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductCostHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductCostHistory`.

### Dependencies
[Back to Top](#productcosthistory)


**Table** refers to the table that the foreign key defined by `Production.ProductCostHistory` maps to.

**Foreign Key** is the column in `Production.ProductCostHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductCostHistory_Product_ProductID**

### Dependents
[Back to Top](#productcosthistory)

No dependencies defined

## Maps
[Back to Top](#productcosthistory)

### Dependency Map
[Back to Top](#productcosthistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductCostHistory.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productcosthistory)

ProductCostHistory has no dependents