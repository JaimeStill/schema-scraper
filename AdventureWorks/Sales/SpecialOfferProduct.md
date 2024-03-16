# Sales.SpecialOfferProduct

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#specialofferproduct)

Column | Type | Is Nullable
-------|------|------------
**SpecialOfferID** | `int` | False
**ProductID** | `int` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#specialofferproduct)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.SpecialOfferProduct`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.SpecialOfferProduct`.

### Dependencies
[Back to Top](#specialofferproduct)


**Table** refers to the table that the foreign key defined by `Sales.SpecialOfferProduct` maps to.

**Foreign Key** is the column in `Sales.SpecialOfferProduct` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](../Production/Product.md) | `ProductID` | `ProductID` | **FK_SpecialOfferProduct_Product_ProductID**
[Sales.SpecialOffer](./SpecialOffer.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID**

### Dependents
[Back to Top](#specialofferproduct)

**Table** refers to the table that defines a foreign key mapping to SpecialOfferProduct.

**Primary Key** is the column in SpecialOfferProduct that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Sales.SalesOrderDetail](./SalesOrderDetail.md) | `SpecialOfferID` | `SpecialOfferID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**
[Sales.SalesOrderDetail](./SalesOrderDetail.md) | `ProductID` | `ProductID` | **FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID**

## Maps
[Back to Top](#specialofferproduct)

### Dependency Map
[Back to Top](#specialofferproduct)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table SpecialOfferProduct.

* [Production.Product](../Production/Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Sales.SpecialOffer](./SpecialOffer.md)
### Dependent Map
[Back to Top](#specialofferproduct)

> The following is a distinct list of tables captured by recursively evaluating tables that list SpecialOfferProduct as a foreign key dependency.

* [Sales.SalesOrderDetail](./SalesOrderDetail.md)