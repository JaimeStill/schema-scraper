# Employee

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#employee)

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
[Back to Top](#employee)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Employee`.
* **Dependents** - foreign key relationships defined by other tables that reference `Employee`.

### Dependencies
[Back to Top](#employee)

**Dependency Table** refers to the table that the foreign key defined by `Employee` maps to.

**Foreign Key Column** is the column in `Employee` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Employee_Person_BusinessEntityID** | `BusinessEntityID` | [Person](./Person.md) | `BusinessEntityID`

### Dependents
[Back to Top](#employee)

**Dependent Table** refers to the table that defines a foreign key mapping to Employee.

**Dependency Key Column** is the column in Employee that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[Document](./Document.md) | **FK_Document_Employee_Owner** | `Owner` | `BusinessEntityID`
[EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | **FK_EmployeeDepartmentHistory_Employee_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[EmployeePayHistory](./EmployeePayHistory.md) | **FK_EmployeePayHistory_Employee_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[JobCandidate](./JobCandidate.md) | **FK_JobCandidate_Employee_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[PurchaseOrderHeader](./PurchaseOrderHeader.md) | **FK_PurchaseOrderHeader_Employee_EmployeeID** | `EmployeeID` | `BusinessEntityID`
[SalesPerson](./SalesPerson.md) | **FK_SalesPerson_Employee_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#employee)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Employee.

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
* [Store](./Store.md)
* [Customer](./Customer.md)
