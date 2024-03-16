# Production.ProductListPriceHistory

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productlistpricehistory)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**StartDate** | `datetime` | False
**EndDate** | `datetime` | True
**ListPrice** | `money` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productlistpricehistory)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductListPriceHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductListPriceHistory`.

### Dependencies
[Back to Top](#productlistpricehistory)


**Table** refers to the table that the foreign key defined by `Production.ProductListPriceHistory` maps to.

**Foreign Key** is the column in `Production.ProductListPriceHistory` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductListPriceHistory_Product_ProductID**

### Dependents
[Back to Top](#productlistpricehistory)

No dependencies defined

## Maps
[Back to Top](#productlistpricehistory)

### Dependency Map
[Back to Top](#productlistpricehistory)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductListPriceHistory.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productlistpricehistory)

ProductListPriceHistory has no dependents
