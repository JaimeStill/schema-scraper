# Person.BusinessEntityAddress

**Schema**: Person
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
* **Dependencies** - foreign key relationships defined by `Person.BusinessEntityAddress`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.BusinessEntityAddress`.

### Dependencies
[Back to Top](#businessentityaddress)


**Table** refers to the table that the foreign key defined by `Person.BusinessEntityAddress` maps to.

**Foreign Key** is the column in `Person.BusinessEntityAddress` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Address](./Address.md) | `AddressID` | `AddressID` | **FK_BusinessEntityAddress_Address_AddressID**
[Person.AddressType](./AddressType.md) | `AddressTypeID` | `AddressTypeID` | **FK_BusinessEntityAddress_AddressType_AddressTypeID**
[Person.BusinessEntity](./BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID**

### Dependents
[Back to Top](#businessentityaddress)

No dependencies defined

## Maps
[Back to Top](#businessentityaddress)

### Dependency Map
[Back to Top](#businessentityaddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table BusinessEntityAddress.

* [Person.Address](./Address.md)
* [Person.StateProvince](./StateProvince.md)
* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.AddressType](./AddressType.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#businessentityaddress)

BusinessEntityAddress has no dependents
