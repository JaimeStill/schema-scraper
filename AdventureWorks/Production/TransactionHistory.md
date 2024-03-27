# Production.TransactionHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productiontransactionhistory)

Column | Type | Is Nullable
-------|------|------------
**TransactionID** | `int` | False
**ProductID** | `int` | False
**ReferenceOrderID** | `int` | False
**ReferenceOrderLineID** | `int` | False
**TransactionDate** | `datetime` | False
**TransactionType** | `nchar` | False
**Quantity** | `int` | False
**ActualCost** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productiontransactionhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.TransactionHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.TransactionHistory`.

### Dependencies
[Back to Top](#productiontransactionhistory)


**Table** refers to the table that the foreign key defined by `Production.TransactionHistory` maps to.

**Foreign Key** is the column in `Production.TransactionHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_TransactionHistory_Product_ProductID**

### Dependents
[Back to Top](#productiontransactionhistory)

No dependencies defined

## Maps
[Back to Top](#productiontransactionhistory)

### Dependency Map
[Back to Top](#productiontransactionhistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.TransactionHistory.

* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productiontransactionhistory)

Production.TransactionHistory has no dependents

