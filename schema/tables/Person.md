# Person

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#person)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PersonType** | `nchar` | False
**NameStyle** | `bit` | False
**Title** | `nvarchar` | True
**FirstName** | `nvarchar` | False
**MiddleName** | `nvarchar` | True
**LastName** | `nvarchar` | False
**Suffix** | `nvarchar` | True
**EmailPromotion** | `int` | False
**AdditionalContactInfo** | `xml` | True
**Demographics** | `xml` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#person)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person`.

### Dependencies
[Back to Top](#person)

**Dependency Table** refers to the table that the foreign key defined by `Person` maps to.

**Foreign Key Column** is the column in `Person` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Person_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | [BusinessEntity](./BusinessEntity.md) | `BusinessEntityID`

### Dependents
[Back to Top](#person)

**Dependent Table** refers to the table that defines a foreign key mapping to Person.

**Dependency Key Column** is the column in Person that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BusinessEntityContact](./BusinessEntityContact.md) | **FK_BusinessEntityContact_Person_PersonID** | `PersonID` | `BusinessEntityID`
[Customer](./Customer.md) | **FK_Customer_Person_PersonID** | `PersonID` | `BusinessEntityID`
[EmailAddress](./EmailAddress.md) | **FK_EmailAddress_Person_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Employee](./Employee.md) | **FK_Employee_Person_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[Password](./Password.md) | **FK_Password_Person_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[PersonCreditCard](./PersonCreditCard.md) | **FK_PersonCreditCard_Person_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[PersonPhone](./PersonPhone.md) | **FK_PersonPhone_Person_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#person)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.

* [BusinessEntityContact](./BusinessEntityContact.md)
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
* [Store](./Store.md)
* [Password](./Password.md)
* [PersonCreditCard](./PersonCreditCard.md)
* [PersonPhone](./PersonPhone.md)
