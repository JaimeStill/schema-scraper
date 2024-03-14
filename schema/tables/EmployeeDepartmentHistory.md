# EmployeeDepartmentHistory

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#employeedepartmenthistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**DepartmentID** | `smallint` | False
**ShiftID** | `tinyint` | False
**StartDate** | `date` | False
**EndDate** | `date` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#employeedepartmenthistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `EmployeeDepartmentHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `EmployeeDepartmentHistory`.

### Dependencies
[Back to Top](#employeedepartmenthistory)

**Dependency Table** refers to the table that the foreign key defined by `EmployeeDepartmentHistory` maps to.

**Foreign Key Column** is the column in `EmployeeDepartmentHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_EmployeeDepartmentHistory_Department_DepartmentID** | `DepartmentID` | [Department](./Department.md) | `DepartmentID`
**FK_EmployeeDepartmentHistory_Employee_BusinessEntityID** | `BusinessEntityID` | [Employee](./Employee.md) | `BusinessEntityID`
**FK_EmployeeDepartmentHistory_Shift_ShiftID** | `ShiftID` | [Shift](./Shift.md) | `ShiftID`

### Dependents
[Back to Top](#employeedepartmenthistory)

**Dependent Table** refers to the table that defines a foreign key mapping to EmployeeDepartmentHistory.

**Dependency Key Column** is the column in EmployeeDepartmentHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#employeedepartmenthistory)

EmployeeDepartmentHistory has no dependencies.
