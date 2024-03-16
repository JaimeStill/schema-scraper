# Person.AddressType

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personaddresstype)

Column | Type | Is Nullable
-------|------|------------
**AddressTypeID** | `int` | False
**Name** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personaddresstype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.AddressType`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.AddressType`.

### Dependencies
[Back to Top](#personaddresstype)


No dependencies defined

### Dependents
[Back to Top](#personaddresstype)

**Table** refers to the table that defines a foreign key mapping to Person.AddressType.

**Primary Key** is the column in Person.AddressType that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityAddress](./BusinessEntityAddress.md) | `AddressTypeID` | `AddressTypeID` | **FK_BusinessEntityAddress_AddressType_AddressTypeID**

## Maps
[Back to Top](#personaddresstype)

### Dependency Map
[Back to Top](#personaddresstype)

Person.AddressType has no dependencies
### Dependent Map
[Back to Top](#personaddresstype)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.AddressType as a foreign key dependency.

* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
