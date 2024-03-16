# Person.BusinessEntity

**Schema**: Person
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
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntity`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntity`.

### Dependencies
[Back to Top](#businessentity)


No dependencies defined

### Dependents
[Back to Top](#businessentity)

**Table** refers to the table that defines a foreign key mapping to BusinessEntity.

**Primary Key** is the column in BusinessEntity that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityAddress](./BusinessEntityAddress.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID**
[Person.BusinessEntityContact](./BusinessEntityContact.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityContact_BusinessEntity_BusinessEntityID**
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Person_BusinessEntity_BusinessEntityID**
[Purchasing.Vendor](../Purchasing/Vendor.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Vendor_BusinessEntity_BusinessEntityID**
[Sales.Store](../Sales/Store.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Store_BusinessEntity_BusinessEntityID**

## Maps
[Back to Top](#businessentity)

### Dependency Map
[Back to Top](#businessentity)

BusinessEntity has no dependencies
### Dependent Map
[Back to Top](#businessentity)

> The following is a distinct list of tables captured by recursively evaluating tables that list BusinessEntity as a foreign key dependency.

* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Person.BusinessEntityContact](./BusinessEntityContact.md)
* [Person.Person](./Person.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
* [HumanResources.EmployeePayHistory](./EmployeePayHistory.md)
* [HumanResources.JobCandidate](./JobCandidate.md)
* [Production.Document](../Production/Document.md)
* [Production.ProductDocument](./ProductDocument.md)
* [Purchasing.PurchaseOrderHeader](../Purchasing/PurchaseOrderHeader.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [Sales.SalesPerson](../Sales/SalesPerson.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.SalesPersonQuotaHistory](./SalesPersonQuotaHistory.md)
* [Sales.SalesTerritoryHistory](./SalesTerritoryHistory.md)
* [Sales.Store](./Store.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Person.BusinessEntityContact](./BusinessEntityContact.md)
* [Person.EmailAddress](./EmailAddress.md)
* [Person.Password](./Password.md)
* [Person.PersonPhone](./PersonPhone.md)
* [Sales.Customer](../Sales/Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
* [Sales.PersonCreditCard](../Sales/PersonCreditCard.md)
* [Purchasing.Vendor](../Purchasing/Vendor.md)
* [Purchasing.ProductVendor](./ProductVendor.md)
* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [Sales.Store](../Sales/Store.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
