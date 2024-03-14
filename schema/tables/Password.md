# Password

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#password)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**PasswordHash** | `varchar` | False
**PasswordSalt** | `varchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#password)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Password`.
* **Dependents** - foreign key relationships defined by other tables that reference `Password`.

### Dependencies
[Back to Top](#password)

**Dependency Table** refers to the table that the foreign key defined by `Password` maps to.

**Foreign Key Column** is the column in `Password` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Password_Person_BusinessEntityID** | `BusinessEntityID` | [Person](./Person.md) | `BusinessEntityID`

### Dependents
[Back to Top](#password)

**Dependent Table** refers to the table that defines a foreign key mapping to Password.

**Dependency Key Column** is the column in Password that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#password)

Password has no dependencies.
