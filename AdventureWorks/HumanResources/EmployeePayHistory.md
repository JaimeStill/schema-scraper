# HumanResources.EmployeePayHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesemployeepayhistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**RateChangeDate** | `datetime` | False
**Rate** | `money` | False
**PayFrequency** | `tinyint` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesemployeepayhistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.EmployeePayHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.EmployeePayHistory`.

### Dependencies
[Back to Top](#humanresourcesemployeepayhistory)


**Table** refers to the table that the foreign key defined by `HumanResources.EmployeePayHistory` maps to.

**Foreign Key** is the column in `HumanResources.EmployeePayHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](./Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmployeePayHistory_Employee_BusinessEntityID**

### Dependents
[Back to Top](#humanresourcesemployeepayhistory)

No dependencies defined

## Maps
[Back to Top](#humanresourcesemployeepayhistory)

### Dependency Map
[Back to Top](#humanresourcesemployeepayhistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table HumanResources.EmployeePayHistory.

* [HumanResources.Employee](./Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)

### Dependent Map
[Back to Top](#humanresourcesemployeepayhistory)

HumanResources.EmployeePayHistory has no dependents

