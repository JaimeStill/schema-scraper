# Person.EmailAddress

**Schema**: Person
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#emailaddress)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**EmailAddressID** | `int` | False
**EmailAddress** | `nvarchar` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#emailaddress)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.EmailAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.EmailAddress`.

### Dependencies
[Back to Top](#emailaddress)


**Table** refers to the table that the foreign key defined by `Person.EmailAddress` maps to.

**Foreign Key** is the column in `Person.EmailAddress` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_EmailAddress_Person_BusinessEntityID**

### Dependents
[Back to Top](#emailaddress)

No dependencies defined

## Maps
[Back to Top](#emailaddress)

### Dependency Map
[Back to Top](#emailaddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table EmailAddress.

* [Person.Person](./Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#emailaddress)

EmailAddress has no dependents
