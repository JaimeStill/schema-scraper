# Sales.ShoppingCartItem

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#shoppingcartitem)

Column | Type | Is Nullable
-------|------|------------
**ShoppingCartItemID** | `int` | False
**ShoppingCartID** | `nvarchar` | False
**Quantity** | `int` | False
**ProductID** | `int` | False
**DateCreated** | `datetime` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#shoppingcartitem)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.ShoppingCartItem`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.ShoppingCartItem`.

### Dependencies
[Back to Top](#shoppingcartitem)


**Table** refers to the table that the foreign key defined by `Sales.ShoppingCartItem` maps to.

**Foreign Key** is the column in `Sales.ShoppingCartItem` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](../Production/Product.md) | `ProductID` | `ProductID` | **FK_ShoppingCartItem_Product_ProductID**

### Dependents
[Back to Top](#shoppingcartitem)

No dependencies defined

## Maps
[Back to Top](#shoppingcartitem)

### Dependency Map
[Back to Top](#shoppingcartitem)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ShoppingCartItem.

* [Production.Product](../Production/Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#shoppingcartitem)

ShoppingCartItem has no dependents
