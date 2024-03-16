# Production.ProductReview

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productreview)

Column | Type | Is Nullable
-------|------|------------
**ProductReviewID** | `int` | False
**ProductID** | `int` | False
**ReviewerName** | `nvarchar` | False
**ReviewDate** | `datetime` | False
**EmailAddress** | `nvarchar` | False
**Rating** | `int` | False
**Comments** | `nvarchar` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productreview)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductReview`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductReview`.

### Dependencies
[Back to Top](#productreview)


**Table** refers to the table that the foreign key defined by `Production.ProductReview` maps to.

**Foreign Key** is the column in `Production.ProductReview` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductReview_Product_ProductID**

### Dependents
[Back to Top](#productreview)

No dependencies defined

## Maps
[Back to Top](#productreview)

### Dependency Map
[Back to Top](#productreview)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductReview.

* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productreview)

ProductReview has no dependents
