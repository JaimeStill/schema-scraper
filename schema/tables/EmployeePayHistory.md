# EmployeePayHistory

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
* **Dependencies** - foreign key relationships defined by `EmployeePayHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `EmployeePayHistory`.

### Dependencies
[Back to Top](#employeepayhistory)

**Dependency Table** refers to the table that the foreign key defined by `EmployeePayHistory` maps to.

**Foreign Key Column** is the column in `EmployeePayHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_EmployeePayHistory_Employee_BusinessEntityID** | `BusinessEntityID` | [Employee](./Employee.md) | `BusinessEntityID`

### Dependents
[Back to Top](#employeepayhistory)

**Dependent Table** refers to the table that defines a foreign key mapping to EmployeePayHistory.

**Dependency Key Column** is the column in EmployeePayHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#employeepayhistory)

EmployeePayHistory has no dependencies.
