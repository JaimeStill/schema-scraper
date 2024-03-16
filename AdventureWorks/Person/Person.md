# Person.Person

**Schema**: Person
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
* **Dependencies** - foreign key relationships defined by `Person.Person`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.Person`.

### Dependencies
[Back to Top](#person)


**Table** refers to the table that the foreign key defined by `Person.Person` maps to.

**Foreign Key** is the column in `Person.Person` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](./BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Person_BusinessEntity_BusinessEntityID**

### Dependents
[Back to Top](#person)

**Table** refers to the table that defines a foreign key mapping to Person.

**Primary Key** is the column in Person that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Employee_Person_BusinessEntityID**
[Person.BusinessEntityContact](./BusinessEntityContact.md) | `BusinessEntityID` | `PersonID` | **FK_BusinessEntityContact_Person_PersonID**
[Person.EmailAddress](./EmailAddress.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmailAddress_Person_BusinessEntityID**
[Person.Password](./Password.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Password_Person_BusinessEntityID**
[Person.PersonPhone](./PersonPhone.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonPhone_Person_BusinessEntityID**
[Sales.Customer](../Sales/Customer.md) | `BusinessEntityID` | `PersonID` | **FK_Customer_Person_PersonID**
[Sales.PersonCreditCard](../Sales/PersonCreditCard.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonCreditCard_Person_BusinessEntityID**

## Maps
[Back to Top](#person)

### Dependency Map
[Back to Top](#person)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.

* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#person)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person as a foreign key dependency.

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
