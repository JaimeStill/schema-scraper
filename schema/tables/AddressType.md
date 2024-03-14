# AddressType

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#addresstype)

Column | Type | Is Nullable
-------|------|------------
**AddressTypeID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#addresstype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `AddressType`.
* **Dependents** - foreign key relationships defined by other tables that reference `AddressType`.

### Dependencies
[Back to Top](#addresstype)

**Dependency Table** refers to the table that the foreign key defined by `AddressType` maps to.

**Foreign Key Column** is the column in `AddressType` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#addresstype)

**Dependent Table** refers to the table that defines a foreign key mapping to AddressType.

**Dependency Key Column** is the column in AddressType that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BusinessEntityAddress](./BusinessEntityAddress.md) | **FK_BusinessEntityAddress_AddressType_AddressTypeID** | `AddressTypeID` | `AddressTypeID`

## Dependency Map
[Back to Top](#addresstype)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table AddressType.

* [BusinessEntityAddress](./BusinessEntityAddress.md)
