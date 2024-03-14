# Customer

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#customer)

Column | Type | Is Nullable
-------|------|------------
**CustomerID** | `int` | False
**PersonID** | `int` | True
**StoreID** | `int` | True
**TerritoryID** | `int` | True
**AccountNumber** | `varchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#customer)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Customer`.
* **Dependents** - foreign key relationships defined by other tables that reference `Customer`.

### Dependencies
[Back to Top](#customer)

**Dependency Table** refers to the table that the foreign key defined by `Customer` maps to.

**Foreign Key Column** is the column in `Customer` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Customer_Person_PersonID** | `PersonID` | [Person](./Person.md) | `BusinessEntityID`
**FK_Customer_SalesTerritory_TerritoryID** | `TerritoryID` | [SalesTerritory](./SalesTerritory.md) | `TerritoryID`
**FK_Customer_Store_StoreID** | `StoreID` | [Store](./Store.md) | `BusinessEntityID`

### Dependents
[Back to Top](#customer)

**Dependent Table** refers to the table that defines a foreign key mapping to Customer.

**Dependency Key Column** is the column in Customer that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_Customer_CustomerID** | `CustomerID` | `CustomerID`

## Dependency Map
[Back to Top](#customer)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Customer.

* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
