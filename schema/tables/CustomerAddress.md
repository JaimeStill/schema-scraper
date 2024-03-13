# CustomerAddress

* [Relationships](#relationships)
* [Columns](#columns)
* [Dependency Map](#dependency-map)

## Relationships
[Back to Top](#customeraddress)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_CustomerAddress_Address_AddressID** | `AddressID` | [Address](./Address.md) | `AddressID`
**FK_CustomerAddress_Customer_CustomerID** | `CustomerID` | [Customer](./Customer.md) | `CustomerID`

## Columns
[Back to Top](#customeraddress)

Column | Type | Is Nullable
-------|------|------------
**CustomerID** | `int` | False
**AddressID** | `int` | False
**AddressType** | `nvarchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#customeraddress)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table CustomerAddress.

* [Address](./Address.md)
* [Customer](./Customer.md)
