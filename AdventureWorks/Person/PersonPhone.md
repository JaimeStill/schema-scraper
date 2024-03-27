# Person.PersonPhone

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personpersonphone)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PhoneNumber** | `nvarchar` | False
**PhoneNumberTypeID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personpersonphone)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.PersonPhone`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.PersonPhone`.

### Dependencies
[Back to Top](#personpersonphone)


**Table** refers to the table that the foreign key defined by `Person.PersonPhone` maps to.

**Foreign Key** is the column in `Person.PersonPhone` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonPhone_Person_BusinessEntityID**
[Person.PhoneNumberType](./PhoneNumberType.md) | `PhoneNumberTypeID` | `PhoneNumberTypeID` | **FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID**

### Dependents
[Back to Top](#personpersonphone)

No dependencies defined

## Maps
[Back to Top](#personpersonphone)

### Dependency Map
[Back to Top](#personpersonphone)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.PersonPhone.

* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.Person](./Person.md)
* [Person.PhoneNumberType](./PhoneNumberType.md)

### Dependent Map
[Back to Top](#personpersonphone)

Person.PersonPhone has no dependents

