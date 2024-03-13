# SalesOrderHeader

[Relationships](#relationships)
[Columns](#columns)
[Dependency Map](#dependency-map)

## Relationships
[Back to Top](#salesorderheader)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesOrderHeader_Address_ShipTo_AddressID** | `ShipToAddressID` | [Address](./Address.md) | `AddressID`
**FK_SalesOrderHeader_Address_BillTo_AddressID** | `BillToAddressID` | [Address](./Address.md) | `AddressID`
**FK_SalesOrderHeader_Customer_CustomerID** | `CustomerID` | [Customer](./Customer.md) | `CustomerID`

## Columns
[Back to Top](#salesorderheader)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**RevisionNumber** | `tinyint` | False
**OrderDate** | `datetime` | False
**DueDate** | `datetime` | False
**ShipDate** | `datetime` | True
**Status** | `tinyint` | False
**OnlineOrderFlag** | `bit` | False
**SalesOrderNumber** | `nvarchar` | False
**PurchaseOrderNumber** | `nvarchar` | True
**AccountNumber** | `nvarchar` | True
**CustomerID** | `int` | False
**ShipToAddressID** | `int` | True
**BillToAddressID** | `int` | True
**ShipMethod** | `nvarchar` | False
**CreditCardApprovalCode** | `varchar` | True
**SubTotal** | `money` | False
**TaxAmt** | `money` | False
**Freight** | `money` | False
**TotalDue** | `money` | False
**Comment** | `nvarchar` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#salesorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesOrderHeader.

* [Address](./Address.md)
* [Address](./Address.md)
* [Customer](./Customer.md)
