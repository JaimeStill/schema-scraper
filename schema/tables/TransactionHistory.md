# TransactionHistory

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
* **Dependencies** - foreign key relationships defined by `TransactionHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `TransactionHistory`.

### Dependencies
[Back to Top](#transactionhistory)

**Dependency Table** refers to the table that the foreign key defined by `TransactionHistory` maps to.

**Foreign Key Column** is the column in `TransactionHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_TransactionHistory_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#transactionhistory)

**Dependent Table** refers to the table that defines a foreign key mapping to TransactionHistory.

**Dependency Key Column** is the column in TransactionHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#transactionhistory)

TransactionHistory has no dependencies.
