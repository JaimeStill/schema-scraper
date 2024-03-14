# TransactionHistoryArchive

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#transactionhistoryarchive)

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
[Back to Top](#transactionhistoryarchive)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `TransactionHistoryArchive`.
* **Dependents** - foreign key relationships defined by other tables that reference `TransactionHistoryArchive`.

### Dependencies
[Back to Top](#transactionhistoryarchive)

**Dependency Table** refers to the table that the foreign key defined by `TransactionHistoryArchive` maps to.

**Foreign Key Column** is the column in `TransactionHistoryArchive` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#transactionhistoryarchive)

**Dependent Table** refers to the table that defines a foreign key mapping to TransactionHistoryArchive.

**Dependency Key Column** is the column in TransactionHistoryArchive that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#transactionhistoryarchive)

TransactionHistoryArchive has no dependencies.
