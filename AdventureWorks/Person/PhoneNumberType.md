# Person.PhoneNumberType

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#phonenumbertype)

Column | Type | Is Nullable
-------|------|------------
**PhoneNumberTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#phonenumbertype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.PhoneNumberType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.PhoneNumberType`.

### Dependencies
[Back to Top](#phonenumbertype)


No dependencies defined

### Dependents
[Back to Top](#phonenumbertype)

**Table** refers to the table that defines a foreign key mapping to PhoneNumberType.

**Primary Key** is the column in PhoneNumberType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.PersonPhone](./PersonPhone.md) | `PhoneNumberTypeID` | `PhoneNumberTypeID` | **FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID**

## Maps
[Back to Top](#phonenumbertype)

### Dependency Map
[Back to Top](#phonenumbertype)

PhoneNumberType has no dependencies
### Dependent Map
[Back to Top](#phonenumbertype)

> The following is a distinct list of tables captured by recursively evaluating tables that list PhoneNumberType as a foreign key dependency.

* [Person.PersonPhone](./PersonPhone.md)
