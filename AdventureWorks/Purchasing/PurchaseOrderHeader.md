# Purchasing.PurchaseOrderHeader

**Schema**: Purchasing
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
* **Dependencies** - foreign key relationships defined by `Purchasing.PurchaseOrderHeader`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.PurchaseOrderHeader`.

### Dependencies
[Back to Top](#purchaseorderheader)


**Table** refers to the table that the foreign key defined by `Purchasing.PurchaseOrderHeader` maps to.

**Foreign Key** is the column in `Purchasing.PurchaseOrderHeader` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `EmployeeID` | **FK_PurchaseOrderHeader_Employee_EmployeeID**
[Purchasing.ShipMethod](./ShipMethod.md) | `ShipMethodID` | `ShipMethodID` | **FK_PurchaseOrderHeader_ShipMethod_ShipMethodID**
[Purchasing.Vendor](./Vendor.md) | `BusinessEntityID` | `VendorID` | **FK_PurchaseOrderHeader_Vendor_VendorID**

### Dependents
[Back to Top](#purchaseorderheader)

**Table** refers to the table that defines a foreign key mapping to PurchaseOrderHeader.

**Primary Key** is the column in PurchaseOrderHeader that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md) | `PurchaseOrderID` | `PurchaseOrderID` | **FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID**

## Maps
[Back to Top](#purchaseorderheader)

### Dependency Map
[Back to Top](#purchaseorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PurchaseOrderHeader.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Purchasing.ShipMethod](./ShipMethod.md)
* [Purchasing.Vendor](./Vendor.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
### Dependent Map
[Back to Top](#purchaseorderheader)

> The following is a distinct list of tables captured by recursively evaluating tables that list PurchaseOrderHeader as a foreign key dependency.

* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
