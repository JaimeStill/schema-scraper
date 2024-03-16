# Person.BusinessEntityContact

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personbusinessentitycontact)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PersonID** | `int` | False
**ContactTypeID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personbusinessentitycontact)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntityContact`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntityContact`.

### Dependencies
[Back to Top](#personbusinessentitycontact)


**Table** refers to the table that the foreign key defined by `Person.BusinessEntityContact` maps to.

**Foreign Key** is the column in `Person.BusinessEntityContact` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](./BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityContact_BusinessEntity_BusinessEntityID**
[Person.ContactType](./ContactType.md) | `ContactTypeID` | `ContactTypeID` | **FK_BusinessEntityContact_ContactType_ContactTypeID**
[Person.Person](./Person.md) | `BusinessEntityID` | `PersonID` | **FK_BusinessEntityContact_Person_PersonID**

### Dependents
[Back to Top](#personbusinessentitycontact)

No dependencies defined

## Maps
[Back to Top](#personbusinessentitycontact)

### Dependency Map
[Back to Top](#personbusinessentitycontact)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.BusinessEntityContact.

* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.ContactType](./ContactType.md)
* [Person.Person](./Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#personbusinessentitycontact)

Person.BusinessEntityContact has no dependents
