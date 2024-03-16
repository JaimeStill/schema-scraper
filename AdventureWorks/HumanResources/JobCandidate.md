# HumanResources.JobCandidate

**Schema**: HumanResources
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
* **Dependencies** - foreign key relationships defined by `HumanResources.JobCandidate`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.JobCandidate`.

### Dependencies
[Back to Top](#jobcandidate)


**Table** refers to the table that the foreign key defined by `HumanResources.JobCandidate` maps to.

**Foreign Key** is the column in `HumanResources.JobCandidate` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](./Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_JobCandidate_Employee_BusinessEntityID**

### Dependents
[Back to Top](#jobcandidate)

No dependencies defined

## Maps
[Back to Top](#jobcandidate)

### Dependency Map
[Back to Top](#jobcandidate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table JobCandidate.

* [HumanResources.Employee](./Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#jobcandidate)

JobCandidate has no dependents
