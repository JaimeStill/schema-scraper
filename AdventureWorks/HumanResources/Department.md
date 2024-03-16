# HumanResources.Department

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesdepartment)

Column | Type | Is Nullable
-------|------|------------
**DepartmentID** | `smallint` | False
**Name** | `nvarchar` | False
**GroupName** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesdepartment)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.Department`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.Department`.

### Dependencies
[Back to Top](#humanresourcesdepartment)


No dependencies defined

### Dependents
[Back to Top](#humanresourcesdepartment)

**Table** refers to the table that defines a foreign key mapping to HumanResources.Department.

**Primary Key** is the column in HumanResources.Department that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | `DepartmentID` | `DepartmentID` | **FK_EmployeeDepartmentHistory_Department_DepartmentID**

## Maps
[Back to Top](#humanresourcesdepartment)

### Dependency Map
[Back to Top](#humanresourcesdepartment)

HumanResources.Department has no dependencies
### Dependent Map
[Back to Top](#humanresourcesdepartment)

> The following is a distinct list of tables captured by recursively evaluating tables that list HumanResources.Department as a foreign key dependency.

* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
