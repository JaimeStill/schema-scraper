# SalesOrderHeader

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

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
**SalesPersonID** | `int` | True
**TerritoryID** | `int` | True
**BillToAddressID** | `int` | False
**ShipToAddressID** | `int` | False
**ShipMethodID** | `int` | False
**CreditCardID** | `int` | True
**CreditCardApprovalCode** | `varchar` | True
**CurrencyRateID** | `int` | True
**SubTotal** | `money` | False
**TaxAmt** | `money` | False
**Freight** | `money` | False
**TotalDue** | `money` | False
**Comment** | `nvarchar` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesorderheader)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `SalesOrderHeader`.
* **Dependents** - foreign key relationships defined by other tables that reference `SalesOrderHeader`.

### Dependencies
[Back to Top](#salesorderheader)

**Dependency Table** refers to the table that the foreign key defined by `SalesOrderHeader` maps to.

**Foreign Key Column** is the column in `SalesOrderHeader` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesOrderHeader_Address_BillToAddressID** | `BillToAddressID` | [Address](./Address.md) | `AddressID`
**FK_SalesOrderHeader_Address_ShipToAddressID** | `ShipToAddressID` | [Address](./Address.md) | `AddressID`
**FK_SalesOrderHeader_CreditCard_CreditCardID** | `CreditCardID` | [CreditCard](./CreditCard.md) | `CreditCardID`
**FK_SalesOrderHeader_CurrencyRate_CurrencyRateID** | `CurrencyRateID` | [CurrencyRate](./CurrencyRate.md) | `CurrencyRateID`
**FK_SalesOrderHeader_Customer_CustomerID** | `CustomerID` | [Customer](./Customer.md) | `CustomerID`
**FK_SalesOrderHeader_SalesPerson_SalesPersonID** | `SalesPersonID` | [SalesPerson](./SalesPerson.md) | `BusinessEntityID`
**FK_SalesOrderHeader_SalesTerritory_TerritoryID** | `TerritoryID` | [SalesTerritory](./SalesTerritory.md) | `TerritoryID`
**FK_SalesOrderHeader_ShipMethod_ShipMethodID** | `ShipMethodID` | [ShipMethod](./ShipMethod.md) | `ShipMethodID`

### Dependents
[Back to Top](#salesorderheader)

**Dependent Table** refers to the table that defines a foreign key mapping to SalesOrderHeader.

**Dependency Key Column** is the column in SalesOrderHeader that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[SalesOrderDetail](./SalesOrderDetail.md) | **FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID** | `SalesOrderID` | `SalesOrderID`
[SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md) | **FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID** | `SalesOrderID` | `SalesOrderID`

## Dependency Map
[Back to Top](#salesorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesOrderHeader.

* [SalesOrderDetail](./SalesOrderDetail.md)
* [SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
