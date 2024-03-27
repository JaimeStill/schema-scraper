# Person.BusinessEntityAddress

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personbusinessentityaddress)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**AddressID** | `int` | False
**AddressTypeID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personbusinessentityaddress)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntityAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntityAddress`.

### Dependencies
[Back to Top](#personbusinessentityaddress)


**Table** refers to the table that the foreign key defined by `Person.BusinessEntityAddress` maps to.

**Foreign Key** is the column in `Person.BusinessEntityAddress` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Address](./Address.md) | `AddressID` | `AddressID` | **FK_BusinessEntityAddress_Address_AddressID**
[Person.AddressType](./AddressType.md) | `AddressTypeID` | `AddressTypeID` | **FK_BusinessEntityAddress_AddressType_AddressTypeID**
[Person.BusinessEntity](./BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID**

### Dependents
[Back to Top](#personbusinessentityaddress)

No dependencies defined

## Maps
[Back to Top](#personbusinessentityaddress)

### Dependency Map
[Back to Top](#personbusinessentityaddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.BusinessEntityAddress.

* [Person.Address](./Address.md)
* [Person.AddressType](./AddressType.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Person.CountryRegion](./CountryRegion.md)
* [Person.StateProvince](./StateProvince.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)

### Dependent Map
[Back to Top](#personbusinessentityaddress)

Person.BusinessEntityAddress has no dependents

