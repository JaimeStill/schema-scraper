# ProductReview

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
* **Dependencies** - foreign key relationships defined by `ProductReview`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductReview`.

### Dependencies
[Back to Top](#productreview)

**Dependency Table** refers to the table that the foreign key defined by `ProductReview` maps to.

**Foreign Key Column** is the column in `ProductReview` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductReview_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#productreview)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductReview.

**Dependency Key Column** is the column in ProductReview that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productreview)

ProductReview has no dependencies.
