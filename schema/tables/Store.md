# Store

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#store)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**Name** | `nvarchar` | False
**SalesPersonID** | `int` | True
**Demographics** | `xml` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#store)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Store`.
* **Dependents** - foreign key relationships defined by other tables that reference `Store`.

### Dependencies
[Back to Top](#store)

**Dependency Table** refers to the table that the foreign key defined by `Store` maps to.

**Foreign Key Column** is the column in `Store` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Store_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | [BusinessEntity](./BusinessEntity.md) | `BusinessEntityID`
**FK_Store_SalesPerson_SalesPersonID** | `SalesPersonID` | [SalesPerson](./SalesPerson.md) | `BusinessEntityID`

### Dependents
[Back to Top](#store)

**Dependent Table** refers to the table that defines a foreign key mapping to Store.

**Dependency Key Column** is the column in Store that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Customer](./Customer.md) | **FK_Customer_Store_StoreID** | `StoreID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#store)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Store.

* [Customer](./Customer.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
