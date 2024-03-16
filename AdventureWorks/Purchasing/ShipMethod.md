# Purchasing.ShipMethod

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#purchasingshipmethod)

Column | Type | Is Nullable
-------|------|------------
**ShipMethodID** | `int` | False
**Name** | `nvarchar` | False
**ShipBase** | `money` | False
**ShipRate** | `money` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#purchasingshipmethod)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.ShipMethod`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.ShipMethod`.

### Dependencies
[Back to Top](#purchasingshipmethod)


No dependencies defined

### Dependents
[Back to Top](#purchasingshipmethod)

**Table** refers to the table that defines a foreign key mapping to Purchasing.ShipMethod.

**Primary Key** is the column in Purchasing.ShipMethod that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `ShipMethodID` | `ShipMethodID` | **FK_PurchaseOrderHeader_ShipMethod_ShipMethodID**
[Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md) | `ShipMethodID` | `ShipMethodID` | **FK_SalesOrderHeader_ShipMethod_ShipMethodID**

## Maps
[Back to Top](#purchasingshipmethod)

### Dependency Map
[Back to Top](#purchasingshipmethod)

Purchasing.ShipMethod has no dependencies
### Dependent Map
[Back to Top](#purchasingshipmethod)

> The following is a distinct list of tables captured by recursively evaluating tables that list Purchasing.ShipMethod as a foreign key dependency.

* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
