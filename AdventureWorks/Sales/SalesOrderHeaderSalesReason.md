# Sales.SalesOrderHeaderSalesReason

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesorderheadersalesreason)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesReasonID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesorderheadersalesreason)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesOrderHeaderSalesReason`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesOrderHeaderSalesReason`.

### Dependencies
[Back to Top](#salesorderheadersalesreason)


**Table** refers to the table that the foreign key defined by `Sales.SalesOrderHeaderSalesReason` maps to.

**Foreign Key** is the column in `Sales.SalesOrderHeaderSalesReason` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID**
[Sales.SalesReason](./SalesReason.md) | `SalesReasonID` | `SalesReasonID` | **FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID**

### Dependents
[Back to Top](#salesorderheadersalesreason)

No dependencies defined

## Maps
[Back to Top](#salesorderheadersalesreason)

### Dependency Map
[Back to Top](#salesorderheadersalesreason)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesOrderHeaderSalesReason.

* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Person.Address](../Person/Address.md)
* [Person.StateProvince](./StateProvince.md)
* [Person.CountryRegion](./CountryRegion.md)
* [Sales.SalesTerritory](../Sales/SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Purchasing.ShipMethod](../Purchasing/ShipMethod.md)
* [Sales.CreditCard](./CreditCard.md)
* [Sales.CurrencyRate](./CurrencyRate.md)
* [Sales.Currency](./Currency.md)
* [Sales.Customer](./Customer.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.Store](./Store.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Sales.SalesReason](./SalesReason.md)
### Dependent Map
[Back to Top](#salesorderheadersalesreason)

SalesOrderHeaderSalesReason has no dependents
