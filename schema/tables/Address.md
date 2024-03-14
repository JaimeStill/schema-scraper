# Address

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#address)

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
[Back to Top](#address)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Address`.
* **Dependents** - foreign key relationships defined by other tables that reference `Address`.

### Dependencies
[Back to Top](#address)

**Dependency Table** refers to the table that the foreign key defined by `Address` maps to.

**Foreign Key Column** is the column in `Address` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Address_StateProvince_StateProvinceID** | `StateProvinceID` | [StateProvince](./StateProvince.md) | `StateProvinceID`

### Dependents
[Back to Top](#address)

**Dependent Table** refers to the table that defines a foreign key mapping to Address.

**Dependency Key Column** is the column in Address that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[BusinessEntityAddress](./BusinessEntityAddress.md) | **FK_BusinessEntityAddress_Address_AddressID** | `AddressID` | `AddressID`
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_Address_BillToAddressID** | `BillToAddressID` | `AddressID`
[SalesOrderHeader](./SalesOrderHeader.md) | **FK_SalesOrderHeader_Address_ShipToAddressID** | `ShipToAddressID` | `AddressID`

## Dependency Map
[Back to Top](#address)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Address.

* [BusinessEntityAddress](./BusinessEntityAddress.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
