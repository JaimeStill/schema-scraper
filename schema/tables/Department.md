# Department

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
* **Dependencies** - foreign key relationships defined by `Department`.
* **Dependents** - foreign key relationships defined by other tables that reference `Department`.

### Dependencies
[Back to Top](#department)

**Dependency Table** refers to the table that the foreign key defined by `Department` maps to.

**Foreign Key Column** is the column in `Department` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#department)

**Dependent Table** refers to the table that defines a foreign key mapping to Department.

**Dependency Key Column** is the column in Department that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | **FK_EmployeeDepartmentHistory_Department_DepartmentID** | `DepartmentID` | `DepartmentID`

## Dependency Map
[Back to Top](#department)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Department.

* [EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
