# Sales.Customer

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salescustomer)

Column | Type | Is Nullable
-------|------|------------
**CustomerID** | `int` | False
**PersonID** | `int` | True
**StoreID** | `int` | True
**TerritoryID** | `int` | True
**AccountNumber** | `varchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salescustomer)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.Customer`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.Customer`.

### Dependencies
[Back to Top](#salescustomer)


**Table** refers to the table that the foreign key defined by `Sales.Customer` maps to.

**Foreign Key** is the column in `Sales.Customer` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](../Person/Person.md) | `BusinessEntityID` | `PersonID` | **FK_Customer_Person_PersonID**
[Sales.SalesTerritory](./SalesTerritory.md) | `TerritoryID` | `TerritoryID` | **FK_Customer_SalesTerritory_TerritoryID**
[Sales.Store](./Store.md) | `BusinessEntityID` | `StoreID` | **FK_Customer_Store_StoreID**

### Dependents
[Back to Top](#salescustomer)

**Table** refers to the table that defines a foreign key mapping to Sales.Customer.

**Primary Key** is the column in Sales.Customer that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `CustomerID` | `CustomerID` | **FK_SalesOrderHeader_Customer_CustomerID**

## Maps
[Back to Top](#salescustomer)

### Dependency Map
[Back to Top](#salescustomer)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.Customer.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.Person](../Person/Person.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Sales.Store](./Store.md)

### Dependent Map
[Back to Top](#salescustomer)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.Customer as a foreign key dependency.

* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)

