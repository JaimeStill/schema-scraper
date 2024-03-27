# Sales.SalesOrderDetail

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salessalesorderdetail)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesOrderDetailID** | `int` | False
**CarrierTrackingNumber** | `nvarchar` | True
**OrderQty** | `smallint` | False
**ProductID** | `int` | False
**SpecialOfferID** | `int` | False
**UnitPrice** | `money` | False
**UnitPriceDiscount** | `money` | False
**LineTotal** | `numeric` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salessalesorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesOrderDetail`.

### Dependencies
[Back to Top](#salessalesorderdetail)


**Table** refers to the table that the foreign key defined by `Sales.SalesOrderDetail` maps to.

**Foreign Key** is the column in `Sales.SalesOrderDetail` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID**
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `ProductID` | `ProductID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**

### Dependents
[Back to Top](#salessalesorderdetail)

No dependencies defined

## Maps
[Back to Top](#salessalesorderdetail)

### Dependency Map
[Back to Top](#salessalesorderdetail)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.SalesOrderDetail.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Address](../Person/Address.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.CountryRegion](../Person/CountryRegion.md)
* [Person.Person](../Person/Person.md)
* [Person.StateProvince](../Person/StateProvince.md)
* [Production.Product](../Production/Product.md)
* [Production.ProductCategory](../Production/ProductCategory.md)
* [Production.ProductModel](../Production/ProductModel.md)
* [Production.ProductSubcategory](../Production/ProductSubcategory.md)
* [Production.UnitMeasure](../Production/UnitMeasure.md)
* [Purchasing.ShipMethod](../Purchasing/ShipMethod.md)
* [Sales.CreditCard](./CreditCard.md)
* [Sales.Currency](./Currency.md)
* [Sales.CurrencyRate](./CurrencyRate.md)
* [Sales.Customer](./Customer.md)
* [Sales.SalesOrderHeader](./SalesOrderHeader.md)
* [Sales.SalesPerson](./SalesPerson.md)
* [Sales.SalesTerritory](./SalesTerritory.md)
* [Sales.SpecialOffer](./SpecialOffer.md)
* [Sales.SpecialOfferProduct](./SpecialOfferProduct.md)
* [Sales.Store](./Store.md)

### Dependent Map
[Back to Top](#salessalesorderdetail)

Sales.SalesOrderDetail has no dependents

