# Purchasing.ShipMethod

**Schema**: Purchasing
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#shipmethod)

Column | Type | Is Nullable
-------|------|------------
**ShipMethodID** | `int` | False
**Name** | `nvarchar` | False
**ShipBase** | `money` | False
**ShipRate** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#shipmethod)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.ShipMethod`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.ShipMethod`.

### Dependencies
[Back to Top](#shipmethod)


No dependencies defined

### Dependents
[Back to Top](#shipmethod)

**Table** refers to the table that defines a foreign key mapping to ShipMethod.

**Primary Key** is the column in ShipMethod that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `ShipMethodID` | `ShipMethodID` | **FK_PurchaseOrderHeader_ShipMethod_ShipMethodID**
[Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md) | `ShipMethodID` | `ShipMethodID` | **FK_SalesOrderHeader_ShipMethod_ShipMethodID**

## Maps
[Back to Top](#shipmethod)

### Dependency Map
[Back to Top](#shipmethod)

ShipMethod has no dependencies
### Dependent Map
[Back to Top](#shipmethod)

> The following is a distinct list of tables captured by recursively evaluating tables that list ShipMethod as a foreign key dependency.

* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
