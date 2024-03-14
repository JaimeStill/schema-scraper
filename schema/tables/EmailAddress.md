# EmailAddress

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
* **Dependencies** - foreign key relationships defined by `EmailAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `EmailAddress`.

### Dependencies
[Back to Top](#emailaddress)

**Dependency Table** refers to the table that the foreign key defined by `EmailAddress` maps to.

**Foreign Key Column** is the column in `EmailAddress` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_EmailAddress_Person_BusinessEntityID** | `BusinessEntityID` | [Person](./Person.md) | `BusinessEntityID`

### Dependents
[Back to Top](#emailaddress)

**Dependent Table** refers to the table that defines a foreign key mapping to EmailAddress.

**Dependency Key Column** is the column in EmailAddress that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#emailaddress)

EmailAddress has no dependencies.
