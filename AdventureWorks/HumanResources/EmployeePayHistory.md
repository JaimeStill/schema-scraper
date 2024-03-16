# HumanResources.EmployeePayHistory

**Schema**: HumanResources
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#employeepayhistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**RateChangeDate** | `datetime` | False
**Rate** | `money` | False
**PayFrequency** | `tinyint` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#employeepayhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.EmployeePayHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.EmployeePayHistory`.

### Dependencies
[Back to Top](#employeepayhistory)


**Table** refers to the table that the foreign key defined by `HumanResources.EmployeePayHistory` maps to.

**Foreign Key** is the column in `HumanResources.EmployeePayHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](./Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmployeePayHistory_Employee_BusinessEntityID**

### Dependents
[Back to Top](#employeepayhistory)

No dependencies defined

## Maps
[Back to Top](#employeepayhistory)

### Dependency Map
[Back to Top](#employeepayhistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table EmployeePayHistory.

* [HumanResources.Employee](./Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#employeepayhistory)

EmployeePayHistory has no dependents
