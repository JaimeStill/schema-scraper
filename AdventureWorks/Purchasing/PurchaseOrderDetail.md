# Purchasing.PurchaseOrderDetail

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#purchasingpurchaseorderdetail)

Column | Type | Is Nullable
-------|------|------------
**PurchaseOrderID** | `int` | False
**PurchaseOrderDetailID** | `int` | False
**DueDate** | `datetime` | False
**OrderQty** | `smallint` | False
**ProductID** | `int` | False
**UnitPrice** | `money` | False
**LineTotal** | `money` | False
**ReceivedQty** | `decimal` | False
**RejectedQty** | `decimal` | False
**StockedQty** | `decimal` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#purchasingpurchaseorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.PurchaseOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.PurchaseOrderDetail`.

### Dependencies
[Back to Top](#purchasingpurchaseorderdetail)


**Table** refers to the table that the foreign key defined by `Purchasing.PurchaseOrderDetail` maps to.

**Foreign Key** is the column in `Purchasing.PurchaseOrderDetail` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](../Production/Product.md) | `ProductID` | `ProductID` | **FK_PurchaseOrderDetail_Product_ProductID**
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `PurchaseOrderID` | `PurchaseOrderID` | **FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID**

### Dependents
[Back to Top](#purchasingpurchaseorderdetail)

No dependencies defined

## Maps
[Back to Top](#purchasingpurchaseorderdetail)

### Dependency Map
[Back to Top](#purchasingpurchaseorderdetail)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Purchasing.PurchaseOrderDetail.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)
* [Production.Product](../Production/Product.md)
* [Production.ProductCategory](../Production/ProductCategory.md)
* [Production.ProductModel](../Production/ProductModel.md)
* [Production.ProductSubcategory](../Production/ProductSubcategory.md)
* [Production.UnitMeasure](../Production/UnitMeasure.md)
* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [Purchasing.ShipMethod](./ShipMethod.md)
* [Purchasing.Vendor](./Vendor.md)

### Dependent Map
[Back to Top](#purchasingpurchaseorderdetail)

Purchasing.PurchaseOrderDetail has no dependents

