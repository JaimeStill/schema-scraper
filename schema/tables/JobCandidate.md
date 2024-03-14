# JobCandidate

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#jobcandidate)

Column | Type | Is Nullable
-------|------|------------
**JobCandidateID** | `int` | False
**BusinessEntityID** | `int` | True
**Resume** | `xml` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#jobcandidate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `JobCandidate`.
* **Dependents** - foreign key relationships defined by other tables that reference `JobCandidate`.

### Dependencies
[Back to Top](#jobcandidate)

**Dependency Table** refers to the table that the foreign key defined by `JobCandidate` maps to.

**Foreign Key Column** is the column in `JobCandidate` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_JobCandidate_Employee_BusinessEntityID** | `BusinessEntityID` | [Employee](./Employee.md) | `BusinessEntityID`

### Dependents
[Back to Top](#jobcandidate)

**Dependent Table** refers to the table that defines a foreign key mapping to JobCandidate.

**Dependency Key Column** is the column in JobCandidate that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#jobcandidate)

JobCandidate has no dependencies.
