# Person.Address

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#personaddress)

Column | Type | Is Nullable
-------|------|------------
**AddressID** | `int` | False
**AddressLine1** | `nvarchar` | False
**AddressLine2** | `nvarchar` | True
**City** | `nvarchar` | False
**StateProvinceID** | `int` | False
**PostalCode** | `nvarchar` | False
**SpatialLocation** | `geography` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personaddress)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Person.Address`.
* **Dependents** - foreign key relationships defined by other tables that reference `Person.Address`.

### Dependencies
[Back to Top](#personaddress)


**Table** refers to the table that the foreign key defined by `Person.Address` maps to.

**Foreign Key** is the column in `Person.Address` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.StateProvince](./StateProvince.md) | `StateProvinceID` | `StateProvinceID` | **FK_Address_StateProvince_StateProvinceID**

### Dependents
[Back to Top](#personaddress)

**Table** refers to the table that defines a foreign key mapping to Person.Address.

**Primary Key** is the column in Person.Address that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntityAddress](./BusinessEntityAddress.md) | `AddressID` | `AddressID` | **FK_BusinessEntityAddress_Address_AddressID**
[Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md) | `AddressID` | `BillToAddressID` | **FK_SalesOrderHeader_Address_BillToAddressID**
[Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md) | `AddressID` | `ShipToAddressID` | **FK_SalesOrderHeader_Address_ShipToAddressID**

## Maps
[Back to Top](#personaddress)

### Dependency Map
[Back to Top](#personaddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Person.Address.

* [Person.StateProvince](./StateProvince.md)
* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#personaddress)

> The following is a distinct list of tables captured by recursively evaluating tables that list Person.Address as a foreign key dependency.

* [Person.BusinessEntityAddress](./BusinessEntityAddress.md)
* [Sales.SalesOrderHeader](../Sales/SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
