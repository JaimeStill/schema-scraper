# HumanResources.Shift

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesshift)

Column | Type | Is Nullable
-------|------|------------
**ShiftID** | `tinyint` | False
**Name** | `nvarchar` | False
**StartTime** | `time` | False
**EndTime** | `time` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesshift)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.Shift`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.Shift`.

### Dependencies
[Back to Top](#humanresourcesshift)


No dependencies defined

### Dependents
[Back to Top](#humanresourcesshift)

**Table** refers to the table that defines a foreign key mapping to HumanResources.Shift.

**Primary Key** is the column in HumanResources.Shift that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md) | `ShiftID` | `ShiftID` | **FK_EmployeeDepartmentHistory_Shift_ShiftID**

## Maps
[Back to Top](#humanresourcesshift)

### Dependency Map
[Back to Top](#humanresourcesshift)

HumanResources.Shift has no dependencies

### Dependent Map
[Back to Top](#humanresourcesshift)

> The following is a distinct list of tables captured by recursively evaluating tables that list HumanResources.Shift as a foreign key dependency.

* [HumanResources.EmployeeDepartmentHistory](./EmployeeDepartmentHistory.md)

