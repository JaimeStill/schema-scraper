# PurchaseOrderHeader

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#purchaseorderheader)

Column | Type | Is Nullable
-------|------|------------
**PurchaseOrderID** | `int` | False
**RevisionNumber** | `tinyint` | False
**Status** | `tinyint` | False
**EmployeeID** | `int` | False
**VendorID** | `int` | False
**ShipMethodID** | `int` | False
**OrderDate** | `datetime` | False
**ShipDate** | `datetime` | True
**SubTotal** | `money` | False
**TaxAmt** | `money` | False
**Freight** | `money` | False
**TotalDue** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#purchaseorderheader)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `PurchaseOrderHeader`.
* **Dependents** - foreign key relationships defined by other tables that reference `PurchaseOrderHeader`.

### Dependencies
[Back to Top](#purchaseorderheader)

**Dependency Table** refers to the table that the foreign key defined by `PurchaseOrderHeader` maps to.

**Foreign Key Column** is the column in `PurchaseOrderHeader` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_PurchaseOrderHeader_Employee_EmployeeID** | `EmployeeID` | [Employee](./Employee.md) | `BusinessEntityID`
**FK_PurchaseOrderHeader_ShipMethod_ShipMethodID** | `ShipMethodID` | [ShipMethod](./ShipMethod.md) | `ShipMethodID`
**FK_PurchaseOrderHeader_Vendor_VendorID** | `VendorID` | [Vendor](./Vendor.md) | `BusinessEntityID`

### Dependents
[Back to Top](#purchaseorderheader)

**Dependent Table** refers to the table that defines a foreign key mapping to PurchaseOrderHeader.

**Dependency Key Column** is the column in PurchaseOrderHeader that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[PurchaseOrderDetail](./PurchaseOrderDetail.md) | **FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID** | `PurchaseOrderID` | `PurchaseOrderID`

## Dependency Map
[Back to Top](#purchaseorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PurchaseOrderHeader.

* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
