# Person.PhoneNumberType

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personphonenumbertype)

Column | Type | Is Nullable
-------|------|------------
**PhoneNumberTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personphonenumbertype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.PhoneNumberType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.PhoneNumberType`.

### Dependencies
[Back to Top](#personphonenumbertype)


No dependencies defined

### Dependents
[Back to Top](#personphonenumbertype)

**Table** refers to the table that defines a foreign key mapping to Person.PhoneNumberType.

**Primary Key** is the column in Person.PhoneNumberType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.PersonPhone](./PersonPhone.md) | `PhoneNumberTypeID` | `PhoneNumberTypeID` | **FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID**

## Maps
[Back to Top](#personphonenumbertype)

### Dependency Map
[Back to Top](#personphonenumbertype)

Person.PhoneNumberType has no dependencies
### Dependent Map
[Back to Top](#personphonenumbertype)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.PhoneNumberType as a foreign key dependency.

* [Person.PersonPhone](./PersonPhone.md)
