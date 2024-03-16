# Person.AddressType

**Schema**: Person
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
* **Dependencies** - foreign key relationships defined by `Person.AddressType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.AddressType`.

### Dependencies
[Back to Top](#addresstype)


No dependencies defined

### Dependents
[Back to Top](#addresstype)

**Table** refers to the table that defines a foreign key mapping to AddressType.

**Primary Key** is the column in AddressType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityAddress](./BusinessEntityAddress.md) | `AddressTypeID` | `AddressTypeID` | **FK_BusinessEntityAddress_AddressType_AddressTypeID**

## Maps
[Back to Top](#addresstype)

### Dependency Map
[Back to Top](#addresstype)

AddressType has no dependencies
### Dependent Map
[Back to Top](#addresstype)

> The following is a distinct list of tables captured by recursively evaluating tables that list AddressType as a foreign key dependency.

* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
