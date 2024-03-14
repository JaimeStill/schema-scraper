# BusinessEntityContact

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
* **Dependencies** - foreign key relationships defined by `BusinessEntityContact`.
* **Dependents** - foreign key relationships defined by other tables that reference `BusinessEntityContact`.

### Dependencies
[Back to Top](#businessentitycontact)

**Dependency Table** refers to the table that the foreign key defined by `BusinessEntityContact` maps to.

**Foreign Key Column** is the column in `BusinessEntityContact` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_BusinessEntityContact_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | [BusinessEntity](./BusinessEntity.md) | `BusinessEntityID`
**FK_BusinessEntityContact_ContactType_ContactTypeID** | `ContactTypeID` | [ContactType](./ContactType.md) | `ContactTypeID`
**FK_BusinessEntityContact_Person_PersonID** | `PersonID` | [Person](./Person.md) | `BusinessEntityID`

### Dependents
[Back to Top](#businessentitycontact)

**Dependent Table** refers to the table that defines a foreign key mapping to BusinessEntityContact.

**Dependency Key Column** is the column in BusinessEntityContact that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#businessentitycontact)

BusinessEntityContact has no dependencies.
