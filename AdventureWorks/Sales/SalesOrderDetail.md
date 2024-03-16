# Sales.SalesOrderDetail

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#salesorderdetail)

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
[Back to Top](#salesorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SalesOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SalesOrderDetail`.

### Dependencies
[Back to Top](#salesorderdetail)


**Table** refers to the table that the foreign key defined by `Sales.SalesOrderDetail` maps to.

**Foreign Key** is the column in `Sales.SalesOrderDetail` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID` | `SalesOrderID` | **FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID**
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**
[Sales.SpecialOfferProduct](./SpecialOfferProduct.md) | `ProductID` | `ProductID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**

### Dependents
[Back to Top](#salesorderdetail)

No dependencies defined

## Maps
[Back to Top](#salesorderdetail)

### Dependency Map
[Back to Top](#salesorderdetail)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesOrderDetail.

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
* [Sales.SpecialOfferProduct](./SpecialOfferProduct.md)
* [Production.Product](../Production/Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Sales.SpecialOffer](./SpecialOffer.md)
### Dependent Map
[Back to Top](#salesorderdetail)

SalesOrderDetail has no dependents
