# HumanResources.Shift

**Schema**: HumanResources
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
* **Dependencies** - foreign key relationships defined by `HumanResources.Shift`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.Shift`.

### Dependencies
[Back to Top](#shift)


No dependencies defined

### Dependents
[Back to Top](#shift)

**Table** refers to the table that defines a foreign key mapping to Shift.

**Primary Key** is the column in Shift that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | `ShiftID` | `ShiftID` | **FK_EmployeeDepartmentHistory_Shift_ShiftID**

## Maps
[Back to Top](#shift)

### Dependency Map
[Back to Top](#shift)

Shift has no dependencies
### Dependent Map
[Back to Top](#shift)

> The following is a distinct list of tables captured by recursively evaluating tables that list Shift as a foreign key dependency.

* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)
