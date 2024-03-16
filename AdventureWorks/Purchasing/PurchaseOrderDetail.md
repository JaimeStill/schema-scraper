# Purchasing.PurchaseOrderDetail

**Schema**: Purchasing
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#purchaseorderdetail)

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
[Back to Top](#purchaseorderdetail)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.PurchaseOrderDetail`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.PurchaseOrderDetail`.

### Dependencies
[Back to Top](#purchaseorderdetail)


**Table** refers to the table that the foreign key defined by `Purchasing.PurchaseOrderDetail` maps to.

**Foreign Key** is the column in `Purchasing.PurchaseOrderDetail` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](../Production/Product.md) | `ProductID` | `ProductID` | **FK_PurchaseOrderDetail_Product_ProductID**
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `PurchaseOrderID` | `PurchaseOrderID` | **FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID**

### Dependents
[Back to Top](#purchaseorderdetail)

No dependencies defined

## Maps
[Back to Top](#purchaseorderdetail)

### Dependency Map
[Back to Top](#purchaseorderdetail)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PurchaseOrderDetail.

* [Production.Product](../Production/Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Purchasing.ShipMethod](./ShipMethod.md)
* [Purchasing.Vendor](./Vendor.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
### Dependent Map
[Back to Top](#purchaseorderdetail)

PurchaseOrderDetail has no dependents
