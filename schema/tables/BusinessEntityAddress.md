# BusinessEntityAddress

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#businessentityaddress)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**AddressID** | `int` | False
**AddressTypeID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#businessentityaddress)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `BusinessEntityAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `BusinessEntityAddress`.

### Dependencies
[Back to Top](#businessentityaddress)

**Dependency Table** refers to the table that the foreign key defined by `BusinessEntityAddress` maps to.

**Foreign Key Column** is the column in `BusinessEntityAddress` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_BusinessEntityAddress_Address_AddressID** | `AddressID` | [Address](./Address.md) | `AddressID`
**FK_BusinessEntityAddress_AddressType_AddressTypeID** | `AddressTypeID` | [AddressType](./AddressType.md) | `AddressTypeID`
**FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | [BusinessEntity](./BusinessEntity.md) | `BusinessEntityID`

### Dependents
[Back to Top](#businessentityaddress)

**Dependent Table** refers to the table that defines a foreign key mapping to BusinessEntityAddress.

**Dependency Key Column** is the column in BusinessEntityAddress that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#businessentityaddress)

BusinessEntityAddress has no dependencies.
