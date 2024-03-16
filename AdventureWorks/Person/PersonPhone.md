# Person.PersonPhone

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#personphone)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PhoneNumber** | `nvarchar` | False
**PhoneNumberTypeID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personphone)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.PersonPhone`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.PersonPhone`.

### Dependencies
[Back to Top](#personphone)


**Table** refers to the table that the foreign key defined by `Person.PersonPhone` maps to.

**Foreign Key** is the column in `Person.PersonPhone` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonPhone_Person_BusinessEntityID**
[Person.PhoneNumberType](./PhoneNumberType.md) | `PhoneNumberTypeID` | `PhoneNumberTypeID` | **FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID**

### Dependents
[Back to Top](#personphone)

No dependencies defined

## Maps
[Back to Top](#personphone)

### Dependency Map
[Back to Top](#personphone)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PersonPhone.

* [Person.Person](./Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.PhoneNumberType](./PhoneNumberType.md)
### Dependent Map
[Back to Top](#personphone)

PersonPhone has no dependents
