# Purchasing.PurchaseOrderHeader

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#purchasingpurchaseorderheader)

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
[Back to Top](#purchasingpurchaseorderheader)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.PurchaseOrderHeader`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.PurchaseOrderHeader`.

### Dependencies
[Back to Top](#purchasingpurchaseorderheader)


**Table** refers to the table that the foreign key defined by `Purchasing.PurchaseOrderHeader` maps to.

**Foreign Key** is the column in `Purchasing.PurchaseOrderHeader` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `EmployeeID` | **FK_PurchaseOrderHeader_Employee_EmployeeID**
[Purchasing.ShipMethod](./ShipMethod.md) | `ShipMethodID` | `ShipMethodID` | **FK_PurchaseOrderHeader_ShipMethod_ShipMethodID**
[Purchasing.Vendor](./Vendor.md) | `BusinessEntityID` | `VendorID` | **FK_PurchaseOrderHeader_Vendor_VendorID**

### Dependents
[Back to Top](#purchasingpurchaseorderheader)

**Table** refers to the table that defines a foreign key mapping to Purchasing.PurchaseOrderHeader.

**Primary Key** is the column in Purchasing.PurchaseOrderHeader that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md) | `PurchaseOrderID` | `PurchaseOrderID` | **FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID**

## Maps
[Back to Top](#purchasingpurchaseorderheader)

### Dependency Map
[Back to Top](#purchasingpurchaseorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Purchasing.PurchaseOrderHeader.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)
* [Purchasing.ShipMethod](./ShipMethod.md)
* [Purchasing.Vendor](./Vendor.md)

### Dependent Map
[Back to Top](#purchasingpurchaseorderheader)

> The following is a distinct list of tables captured by recursively evaluating tables that list Purchasing.PurchaseOrderHeader as a foreign key dependency.

* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)

