# ContactType

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#contacttype)

Column | Type | Is Nullable
-------|------|------------
**ContactTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#contacttype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `ContactType`.
* **Dependents** - foreign key relationships defined by other tables that reference `ContactType`.

### Dependencies
[Back to Top](#contacttype)

**Dependency Table** refers to the table that the foreign key defined by `ContactType` maps to.

**Foreign Key Column** is the column in `ContactType` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#contacttype)

**Dependent Table** refers to the table that defines a foreign key mapping to ContactType.

**Dependency Key Column** is the column in ContactType that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BusinessEntityContact](./BusinessEntityContact.md) | **FK_BusinessEntityContact_ContactType_ContactTypeID** | `ContactTypeID` | `ContactTypeID`

## Dependency Map
[Back to Top](#contacttype)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ContactType.

* [BusinessEntityContact](./BusinessEntityContact.md)
