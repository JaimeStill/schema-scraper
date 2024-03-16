# HumanResources.EmployeeDepartmentHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesemployeedepartmenthistory)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**DepartmentID** | `smallint` | False
**ShiftID** | `tinyint` | False
**StartDate** | `date` | False
**EndDate** | `date` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesemployeedepartmenthistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.EmployeeDepartmentHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.EmployeeDepartmentHistory`.

### Dependencies
[Back to Top](#humanresourcesemployeedepartmenthistory)


**Table** refers to the table that the foreign key defined by `HumanResources.EmployeeDepartmentHistory` maps to.

**Foreign Key** is the column in `HumanResources.EmployeeDepartmentHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Department](./Department.md) | `DepartmentID` | `DepartmentID` | **FK_EmployeeDepartmentHistory_Department_DepartmentID**
[HumanResources.Employee](./Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmployeeDepartmentHistory_Employee_BusinessEntityID**
[HumanResources.Shift](./Shift.md) | `ShiftID` | `ShiftID` | **FK_EmployeeDepartmentHistory_Shift_ShiftID**

### Dependents
[Back to Top](#humanresourcesemployeedepartmenthistory)

No dependencies defined

## Maps
[Back to Top](#humanresourcesemployeedepartmenthistory)

### Dependency Map
[Back to Top](#humanresourcesemployeedepartmenthistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table HumanResources.EmployeeDepartmentHistory.

* [HumanResources.Department](./Department.md)
* [HumanResources.Employee](./Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [HumanResources.Shift](./Shift.md)
### Dependent Map
[Back to Top](#humanresourcesemployeedepartmenthistory)

HumanResources.EmployeeDepartmentHistory has no dependents
