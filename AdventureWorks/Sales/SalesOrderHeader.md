# Sales.SalesOrderHeader

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesorderheader)

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
[Back to Top](#salessalesorderheader)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesOrderHeader`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesOrderHeader`.

### Dependencies
[Back to Top](#salessalesorderheader)


**Table** refers to the table that the foreign key defined by `Sales.SalesOrderHeader` maps to.

**Foreign Key** is the column in `Sales.SalesOrderHeader` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Address](../Person/Address.md) | `AddressID` | `BillToAddressID` | **FK_SalesOrderHeader_Address_BillToAddressID**
[Person.Address](../Person/Address.md) | `AddressID` | `ShipToAddressID` | **FK_SalesOrderHeader_Address_ShipToAddressID**
[Purchasing.ShipMethod](../Purchasing/ShipMethod.md) | `ShipMethodID` | `ShipMethodID` | **FK_SalesOrderHeader_ShipMethod_ShipMethodID**
[Sales.CreditCard](./CreditCard.md) | `CreditCardID` | `CreditCardID` | **FK_SalesOrderHeader_CreditCard_CreditCardID**
[Sales.CurrencyRate](./CurrencyRate.md) | `CurrencyRateID` | `CurrencyRateID` | **FK_SalesOrderHeader_CurrencyRate_CurrencyRateID**
[Sales.Customer](./Customer.md) | `CustomerID` | `CustomerID` | **FK_SalesOrderHeader_Customer_CustomerID**
[Sales.SalesPerson](./SalesPerson.md) | `BusinessEntityID` | `SalesPersonID` | **FK_SalesOrderHeader_SalesPerson_SalesPersonID**
[Sales.SalesTerritory](./SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_SalesOrderHeader_SalesTerritory_TerritoryID**

### Dependents
[Back to Top](#salessalesorderheader)

**Table** refers to the table that defines a foreign key mapping to Sales.SalesOrderHeader.

**Primary Key** is the column in Sales.SalesOrderHeader that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderDetail](./SalesOrderDetail.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID**
[Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID**

## Maps
[Back to Top](#salessalesorderheader)

### Dependency Map
[Back to Top](#salessalesorderheader)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesOrderHeader.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Address](../Person/Address.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.Person](../Person/Person.md)
* [Person.StateProvince](../Person/StateProvince.md)
* [Purchasing.ShipMethod](../Purchasing/ShipMethod.md)
* [Sales.CreditCard](./CreditCard.md)
* [Sales.Currency](./Currency.md)
* [Sales.CurrencyRate](./CurrencyRate.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Sales.Store](./Store.md)

### Dependent Map
[Back to Top](#salessalesorderheader)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.SalesOrderHeader as a foreign key dependency.

* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)

