# Person.EmailAddress

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personemailaddress)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**EmailAddressID** | `int` | False
**EmailAddress** | `nvarchar` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personemailaddress)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.EmailAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.EmailAddress`.

### Dependencies
[Back to Top](#personemailaddress)


**Table** refers to the table that the foreign key defined by `Person.EmailAddress` maps to.

**Foreign Key** is the column in `Person.EmailAddress` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmailAddress_Person_BusinessEntityID**

### Dependents
[Back to Top](#personemailaddress)

No dependencies defined

## Maps
[Back to Top](#personemailaddress)

### Dependency Map
[Back to Top](#personemailaddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.EmailAddress.

* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.Person](./Person.md)

### Dependent Map
[Back to Top](#personemailaddress)

Person.EmailAddress has no dependents

