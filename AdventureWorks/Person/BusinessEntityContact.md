# Person.BusinessEntityContact

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#businessentitycontact)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PersonID** | `int` | False
**ContactTypeID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#businessentitycontact)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntityContact`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntityContact`.

### Dependencies
[Back to Top](#businessentitycontact)


**Table** refers to the table that the foreign key defined by `Person.BusinessEntityContact` maps to.

**Foreign Key** is the column in `Person.BusinessEntityContact` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](./BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityContact_BusinessEntity_BusinessEntityID**
[Person.ContactType](./ContactType.md) | `ContactTypeID` | `ContactTypeID` | **FK_BusinessEntityContact_ContactType_ContactTypeID**
[Person.Person](./Person.md) | `BusinessEntityID` | `PersonID` | **FK_BusinessEntityContact_Person_PersonID**

### Dependents
[Back to Top](#businessentitycontact)

No dependencies defined

## Maps
[Back to Top](#businessentitycontact)

### Dependency Map
[Back to Top](#businessentitycontact)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table BusinessEntityContact.

* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.ContactType](./ContactType.md)
* [Person.Person](./Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#businessentitycontact)

BusinessEntityContact has no dependents
