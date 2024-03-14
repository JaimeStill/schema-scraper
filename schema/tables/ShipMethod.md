# ShipMethod

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
* **Dependencies** - foreign key relationships defined by `ShipMethod`.
* **Dependents** - foreign key relationships defined by other tables that reference `ShipMethod`.

### Dependencies
[Back to Top](#shipmethod)

**Dependency Table** refers to the table that the foreign key defined by `ShipMethod` maps to.

**Foreign Key Column** is the column in `ShipMethod` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#shipmethod)

**Dependent Table** refers to the table that defines a foreign key mapping to ShipMethod.

**Dependency Key Column** is the column in ShipMethod that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[PurchaseOrderHeader](./PurchaseOrderHeader.md) | **FK_PurchaseOrderHeader_ShipMethod_ShipMethodID** | `ShipMethodID` | `ShipMethodID`
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_ShipMethod_ShipMethodID** | `ShipMethodID` | `ShipMethodID`

## Dependency Map
[Back to Top](#shipmethod)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ShipMethod.

* [PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
