# Production.TransactionHistory

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#transactionhistory)

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
[Back to Top](#transactionhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.TransactionHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.TransactionHistory`.

### Dependencies
[Back to Top](#transactionhistory)


**Table** refers to the table that the foreign key defined by `Production.TransactionHistory` maps to.

**Foreign Key** is the column in `Production.TransactionHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_TransactionHistory_Product_ProductID**

### Dependents
[Back to Top](#transactionhistory)

No dependencies defined

## Maps
[Back to Top](#transactionhistory)

### Dependency Map
[Back to Top](#transactionhistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table TransactionHistory.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#transactionhistory)

TransactionHistory has no dependents
