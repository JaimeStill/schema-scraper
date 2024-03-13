# SalesOrderDetail

* [Relationships](#relationships)
* [Columns](#columns)
* [Dependency Map](#dependency-map)

## Relationships
[Back to Top](#salesorderdetail)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_SalesOrderDetail_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID** | `SalesOrderID` | [SalesOrderHeader](./SalesOrderHeader.md) | `SalesOrderID`

## Columns
[Back to Top](#salesorderdetail)

Column | Type | Is Nullable
-------|------|------------
**SalesOrderID** | `int` | False
**SalesOrderDetailID** | `int` | False
**OrderQty** | `smallint` | False
**ProductID** | `int` | False
**UnitPrice** | `money` | False
**UnitPriceDiscount** | `money` | False
**LineTotal** | `numeric` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#salesorderdetail)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SalesOrderDetail.

* [Product](./Product.md)
* [ProductCategory](./ProductCategory.md)
* [ProductModel](./ProductModel.md)
* [SalesOrderHeader](./SalesOrderHeader.md)
* [Address](./Address.md)
* [Customer](./Customer.md)
