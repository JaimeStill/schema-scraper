# Sales.Store

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salesstore)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**Name** | `nvarchar` | False
**SalesPersonID** | `int` | True
**Demographics** | `xml` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salesstore)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.Store`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.Store`.

### Dependencies
[Back to Top](#salesstore)


**Table** refers to the table that the foreign key defined by `Sales.Store` maps to.

**Foreign Key** is the column in `Sales.Store` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](../Person/BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Store_BusinessEntity_BusinessEntityID**
[Sales.SalesPerson](./SalesPerson.md) | `BusinessEntityID` | `SalesPersonID` | **FK_Store_SalesPerson_SalesPersonID**

### Dependents
[Back to Top](#salesstore)

**Table** refers to the table that defines a foreign key mapping to Sales.Store.

**Primary Key** is the column in Sales.Store that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.Customer](./Customer.md) | `BusinessEntityID` | `StoreID` | **FK_Customer_Store_StoreID**

## Maps
[Back to Top](#salesstore)

### Dependency Map
[Back to Top](#salesstore)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.Store.

* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
### Dependent Map
[Back to Top](#salesstore)

> The following is a distinct list of tables captured by recursively evaluating tables that list Sales.Store as a foreign key dependency.

* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesOrderDetail](./SalesOrderDetail.md)
* [Sales.SalesOrderHeaderSalesReason](./SalesOrderHeaderSalesReason.md)
