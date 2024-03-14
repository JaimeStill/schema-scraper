# Shift

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#shift)

Column | Type | Is Nullable
-------|------|------------
**ShiftID** | `tinyint` | False
**Name** | `nvarchar` | False
**StartTime** | `time` | False
**EndTime** | `time` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#shift)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Shift`.
* **Dependents** - foreign key relationships defined by other tables that reference `Shift`.

### Dependencies
[Back to Top](#shift)

**Dependency Table** refers to the table that the foreign key defined by `Shift` maps to.

**Foreign Key Column** is the column in `Shift` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#shift)

**Dependent Table** refers to the table that defines a foreign key mapping to Shift.

**Dependency Key Column** is the column in Shift that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | **FK_EmployeeDepartmentHistory_Shift_ShiftID** | `ShiftID` | `ShiftID`

## Dependency Map
[Back to Top](#shift)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Shift.

* [EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
