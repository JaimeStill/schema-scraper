# ProductCostHistory

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
* **Dependencies** - foreign key relationships defined by `ProductCostHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductCostHistory`.

### Dependencies
[Back to Top](#productcosthistory)

**Dependency Table** refers to the table that the foreign key defined by `ProductCostHistory` maps to.

**Foreign Key Column** is the column in `ProductCostHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductCostHistory_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#productcosthistory)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductCostHistory.

**Dependency Key Column** is the column in ProductCostHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productcosthistory)

ProductCostHistory has no dependencies.
