# HumanResources.Department

**Schema**: HumanResources
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#department)

Column | Type | Is Nullable
-------|------|------------
**DepartmentID** | `smallint` | False
**Name** | `nvarchar` | False
**GroupName** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#department)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.Department`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.Department`.

### Dependencies
[Back to Top](#department)


No dependencies defined

### Dependents
[Back to Top](#department)

**Table** refers to the table that defines a foreign key mapping to Department.

**Primary Key** is the column in Department that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | `DepartmentID` | `DepartmentID` | **FK_EmployeeDepartmentHistory_Department_DepartmentID**

## Maps
[Back to Top](#department)

### Dependency Map
[Back to Top](#department)

Department has no dependencies
### Dependent Map
[Back to Top](#department)

> The following is a distinct list of tables captured by recursively evaluating tables that list Department as a foreign key dependency.

* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
