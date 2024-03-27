# HumanResources.JobCandidate

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#humanresourcesjobcandidate)

Column | Type | Is Nullable
-------|------|------------
**JobCandidateID** | `int` | False
**BusinessEntityID** | `int` | True
**Resume** | `xml` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#humanresourcesjobcandidate)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `HumanResources.JobCandidate`.
* **Dependents** - foreign key relationships defined by other tables that reference `HumanResources.JobCandidate`.

### Dependencies
[Back to Top](#humanresourcesjobcandidate)


**Table** refers to the table that the foreign key defined by `HumanResources.JobCandidate` maps to.

**Foreign Key** is the column in `HumanResources.JobCandidate` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](./Employee.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_JobCandidate_Employee_BusinessEntityID**

### Dependents
[Back to Top](#humanresourcesjobcandidate)

No dependencies defined

## Maps
[Back to Top](#humanresourcesjobcandidate)

### Dependency Map
[Back to Top](#humanresourcesjobcandidate)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table HumanResources.JobCandidate.

* [HumanResources.Employee](./Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)

### Dependent Map
[Back to Top](#humanresourcesjobcandidate)

HumanResources.JobCandidate has no dependents

