# ProductListPriceHistory

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
* **Dependencies** - foreign key relationships defined by `ProductListPriceHistory`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductListPriceHistory`.

### Dependencies
[Back to Top](#productlistpricehistory)

**Dependency Table** refers to the table that the foreign key defined by `ProductListPriceHistory` maps to.

**Foreign Key Column** is the column in `ProductListPriceHistory` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductListPriceHistory_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#productlistpricehistory)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductListPriceHistory.

**Dependency Key Column** is the column in ProductListPriceHistory that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productlistpricehistory)

ProductListPriceHistory has no dependencies.
