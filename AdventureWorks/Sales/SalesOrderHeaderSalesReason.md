# Sales.SalesOrderHeaderSalesReason

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesorderheadersalesreason)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesReasonID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesorderheadersalesreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesOrderHeaderSalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesOrderHeaderSalesReason`.

### Dependencies
[Back to Top](#salessalesorderheadersalesreason)


**Table** refers to the table that the foreign key defined by `Sales.SalesOrderHeaderSalesReason` maps to.

**Foreign Key** is the column in `Sales.SalesOrderHeaderSalesReason` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID**
[Sales.SalesReason](./SalesReason.md) | `SalesReasonID` | `SalesReasonID` | **FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID**

### Dependents
[Back to Top](#salessalesorderheadersalesreason)

No dependencies defined

## Maps
[Back to Top](#salessalesorderheadersalesreason)

### Dependency Map
[Back to Top](#salessalesorderheadersalesreason)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesOrderHeaderSalesReason.

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
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [Sales.SalesReason](./SalesReason.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Sales.Store](./Store.md)

### Dependent Map
[Back to Top](#salessalesorderheadersalesreason)

Sales.SalesOrderHeaderSalesReason has no dependents

