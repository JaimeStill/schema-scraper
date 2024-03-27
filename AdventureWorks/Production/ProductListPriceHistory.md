# Production.ProductListPriceHistory

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductlistpricehistory)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**ListPrice** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductlistpricehistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductListPriceHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductListPriceHistory`.

### Dependencies
[Back to Top](#productionproductlistpricehistory)


**Table** refers to the table that the foreign key defined by `Production.ProductListPriceHistory` maps to.

**Foreign Key** is the column in `Production.ProductListPriceHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductListPriceHistory_Product_ProductID**

### Dependents
[Back to Top](#productionproductlistpricehistory)

No dependencies defined

## Maps
[Back to Top](#productionproductlistpricehistory)

### Dependency Map
[Back to Top](#productionproductlistpricehistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductListPriceHistory.

* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productionproductlistpricehistory)

Production.ProductListPriceHistory has no dependents

