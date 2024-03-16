# Person.ContactType

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#contacttype)

Column | Type | Is Nullable
-------|------|------------
**ContactTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#contacttype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.ContactType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.ContactType`.

### Dependencies
[Back to Top](#contacttype)


No dependencies defined

### Dependents
[Back to Top](#contacttype)

**Table** refers to the table that defines a foreign key mapping to ContactType.

**Primary Key** is the column in ContactType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityContact](./BusinessEntityContact.md) | `ContactTypeID` | `ContactTypeID` | **FK_BusinessEntityContact_ContactType_ContactTypeID**

## Maps
[Back to Top](#contacttype)

### Dependency Map
[Back to Top](#contacttype)

ContactType has no dependencies
### Dependent Map
[Back to Top](#contacttype)

> The following is a distinct list of tables captured by recursively evaluating tables that list ContactType as a foreign key dependency.

* [Person.BusinessEntityContact](./BusinessEntityContact.md)
