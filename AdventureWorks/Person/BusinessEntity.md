# Person.BusinessEntity

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personbusinessentity)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personbusinessentity)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntity`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntity`.

### Dependencies
[Back to Top](#personbusinessentity)


No dependencies defined

### Dependents
[Back to Top](#personbusinessentity)

**Table** refers to the table that defines a foreign key mapping to Person.BusinessEntity.

**Primary Key** is the column in Person.BusinessEntity that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityAddress](./BusinessEntityAddress.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID**
[Person.BusinessEntityContact](./BusinessEntityContact.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityContact_BusinessEntity_BusinessEntityID**
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Person_BusinessEntity_BusinessEntityID**
[Purchasing.Vendor](../Purchasing/Vendor.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Vendor_BusinessEntity_BusinessEntityID**
[Sales.Store](../Sales/Store.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Store_BusinessEntity_BusinessEntityID**

## Maps
[Back to Top](#personbusinessentity)

### Dependency Map
[Back to Top](#personbusinessentity)

Person.BusinessEntity has no dependencies

### Dependent Map
[Back to Top](#personbusinessentity)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.BusinessEntity as a foreign key dependency.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [HumanResources.EmployeeDepartmentHistory](../HumanResources/EmployeeDepartmentHistory.md)
* [HumanResources.EmployeePayHistory](../HumanResources/EmployeePayHistory.md)
* [HumanResources.JobCandidate](../HumanResources/JobCandidate.md)
* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Person.BusinessEntityContact](./BusinessEntityContact.md)
* [Person.EmailAddress](./EmailAddress.md)
* [Person.Password](./Password.md)
* [Person.Person](./Person.md)
* [Person.PersonPhone](./PersonPhone.md)
* [Production.Document](../Production/Document.md)
* [Production.ProductDocument](../Production/ProductDocument.md)
* [Purchasing.ProductVendor](../Purchasing/ProductVendor.md)
* [Purchasing.PurchaseOrderDetail](../Purchasing/PurchaseOrderDetail.md)
* [Purchasing.PurchaseOrderHeader](../Purchasing/PurchaseOrderHeader.md)
* [Purchasing.Vendor](../Purchasing/Vendor.md)
* [Sales.Customer](../Sales/Customer.md)
* [Sales.PersonCreditCard](../Sales/PersonCreditCard.md)
* [Sales.SalesOrderDetail](../Sales/SalesOrderDetail.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](../Sales/SalesOrderHeaderSalesReason.md)
* [Sales.SalesPerson](../Sales/SalesPerson.md)
* [Sales.SalesPersonQuotaHistory](../Sales/SalesPersonQuotaHistory.md)
* [Sales.SalesTerritoryHistory](../Sales/SalesTerritoryHistory.md)
* [Sales.Store](../Sales/Store.md)

