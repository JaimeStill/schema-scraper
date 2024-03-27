# HumanResources.Employee

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesemployee)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**NationalIDNumber** | `nvarchar` | False
**LoginID** | `nvarchar` | False
**OrganizationNode** | `hierarchyid` | True
**OrganizationLevel** | `smallint` | True
**JobTitle** | `nvarchar` | False
**BirthDate** | `date` | False
**MaritalStatus** | `nchar` | False
**Gender** | `nchar` | False
**HireDate** | `date` | False
**SalariedFlag** | `bit` | False
**VacationHours** | `smallint` | False
**SickLeaveHours** | `smallint` | False
**CurrentFlag** | `bit` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesemployee)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.Employee`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.Employee`.

### Dependencies
[Back to Top](#humanresourcesemployee)


**Table** refers to the table that the foreign key defined by `HumanResources.Employee` maps to.

**Foreign Key** is the column in `HumanResources.Employee` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](../Person/Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Employee_Person_BusinessEntityID**

### Dependents
[Back to Top](#humanresourcesemployee)

**Table** refers to the table that defines a foreign key mapping to HumanResources.Employee.

**Primary Key** is the column in HumanResources.Employee that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmployeeDepartmentHistory_Employee_BusinessEntityID**
[HumanResources.EmployeePayHistory](./EmployeePayHistory.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmployeePayHistory_Employee_BusinessEntityID**
[HumanResources.JobCandidate](./JobCandidate.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_JobCandidate_Employee_BusinessEntityID**
[Production.Document](../Production/Document.md) | `BusinessEntityID` | `Owner` | **FK_Document_Employee_Owner**
[Purchasing.PurchaseOrderHeader](../Purchasing/PurchaseOrderHeader.md) | `BusinessEntityID` | `EmployeeID` | **FK_PurchaseOrderHeader_Employee_EmployeeID**
[Sales.SalesPerson](../Sales/SalesPerson.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_SalesPerson_Employee_BusinessEntityID**

## Maps
[Back to Top](#humanresourcesemployee)

### Dependency Map
[Back to Top](#humanresourcesemployee)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table HumanResources.Employee.

* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)

### Dependent Map
[Back to Top](#humanresourcesemployee)

> The following is a distinct list of tables captured by recursively evaluating tables that list HumanResources.Employee as a foreign key dependency.

* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
* [HumanResources.EmployeePayHistory](./EmployeePayHistory.md)
* [HumanResources.JobCandidate](./JobCandidate.md)
* [Production.Document](../Production/Document.md)
* [Production.ProductDocument](../Production/ProductDocument.md)
* [Purchasing.PurchaseOrderDetail](../Purchasing/PurchaseOrderDetail.md)
* [Purchasing.PurchaseOrderHeader](../Purchasing/PurchaseOrderHeader.md)
* [Sales.Customer](../Sales/Customer.md)
* [Sales.SalesOrderDetail](../Sales/SalesOrderDetail.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](../Sales/SalesOrderHeaderSalesReason.md)
* [Sales.SalesPerson](../Sales/SalesPerson.md)
* [Sales.SalesPersonQuotaHistory](../Sales/SalesPersonQuotaHistory.md)
* [Sales.SalesTerritoryHistory](../Sales/SalesTerritoryHistory.md)
* [Sales.Store](../Sales/Store.md)

