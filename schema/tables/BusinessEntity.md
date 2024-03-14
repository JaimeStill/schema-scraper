# BusinessEntity

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#businessentity)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#businessentity)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `BusinessEntity`.
* **Dependents** - foreign key relationships defined by other tables that reference `BusinessEntity`.

### Dependencies
[Back to Top](#businessentity)

**Dependency Table** refers to the table that the foreign key defined by `BusinessEntity` maps to.

**Foreign Key Column** is the column in `BusinessEntity` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#businessentity)

**Dependent Table** refers to the table that defines a foreign key mapping to BusinessEntity.

**Dependency Key Column** is the column in BusinessEntity that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BusinessEntityAddress](./BusinessEntityAddress.md) | **FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[BusinessEntityContact](./BusinessEntityContact.md) | **FK_BusinessEntityContact_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Person](./Person.md) | **FK_Person_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Store](./Store.md) | **FK_Store_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Vendor](./Vendor.md) | **FK_Vendor_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#businessentity)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table BusinessEntity.

* [BusinessEntityAddress](./BusinessEntityAddress.md)
* [BusinessEntityContact](./BusinessEntityContact.md)
* [Person](./Person.md)
* [Customer](./Customer.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [EmailAddress](./EmailAddress.md)
* [Employee](./Employee.md)
* [Document](./Document.md)
* [ProductDocument](./ProductDocument.md)
* [EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
* [EmployeePayHistory](./EmployeePayHistory.md)
* [JobCandidate](./JobCandidate.md)
* [PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [SalesPerson](./SalesPerson.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [Password](./Password.md)
* [PersonCreditCard](./PersonCreditCard.md)
* [PersonPhone](./PersonPhone.md)
* [Store](./Store.md)
* [Customer](./Customer.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Vendor](./Vendor.md)
* [ProductVendor](./ProductVendor.md)
* [PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
