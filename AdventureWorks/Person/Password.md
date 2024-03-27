# Person.Password

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personpassword)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PasswordHash** | `varchar` | False
**PasswordSalt** | `varchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personpassword)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.Password`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.Password`.

### Dependencies
[Back to Top](#personpassword)


**Table** refers to the table that the foreign key defined by `Person.Password` maps to.

**Foreign Key** is the column in `Person.Password` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](./Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Password_Person_BusinessEntityID**

### Dependents
[Back to Top](#personpassword)

No dependencies defined

## Maps
[Back to Top](#personpassword)

### Dependency Map
[Back to Top](#personpassword)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.Password.

* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.Person](./Person.md)

### Dependent Map
[Back to Top](#personpassword)

Person.Password has no dependents

