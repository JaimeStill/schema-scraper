# PersonPhone

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
* **Dependencies** - foreign key relationships defined by `PersonPhone`.
* **Dependents** - foreign key relationships defined by other tables that reference `PersonPhone`.

### Dependencies
[Back to Top](#personphone)

**Dependency Table** refers to the table that the foreign key defined by `PersonPhone` maps to.

**Foreign Key Column** is the column in `PersonPhone` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_PersonPhone_Person_BusinessEntityID** | `BusinessEntityID` | [Person](./Person.md) | `BusinessEntityID`
**FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID** | `PhoneNumberTypeID` | [PhoneNumberType](./PhoneNumberType.md) | `PhoneNumberTypeID`

### Dependents
[Back to Top](#personphone)

**Dependent Table** refers to the table that defines a foreign key mapping to PersonPhone.

**Dependency Key Column** is the column in PersonPhone that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#personphone)

PersonPhone has no dependencies.
