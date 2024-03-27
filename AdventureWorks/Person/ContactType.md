# Person.ContactType

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personcontacttype)

Column | Type | Is Nullable
-------|------|------------
**ContactTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personcontacttype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.ContactType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.ContactType`.

### Dependencies
[Back to Top](#personcontacttype)


No dependencies defined

### Dependents
[Back to Top](#personcontacttype)

**Table** refers to the table that defines a foreign key mapping to Person.ContactType.

**Primary Key** is the column in Person.ContactType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityContact](./BusinessEntityContact.md) | `ContactTypeID` | `ContactTypeID` | **FK_BusinessEntityContact_ContactType_ContactTypeID**

## Maps
[Back to Top](#personcontacttype)

### Dependency Map
[Back to Top](#personcontacttype)

Person.ContactType has no dependencies

### Dependent Map
[Back to Top](#personcontacttype)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.ContactType as a foreign key dependency.

* [Person.BusinessEntityContact](./BusinessEntityContact.md)

