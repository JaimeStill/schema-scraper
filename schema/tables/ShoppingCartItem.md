# ShoppingCartItem

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
* **Dependencies** - foreign key relationships defined by `ShoppingCartItem`.
* **Dependents** - foreign key relationships defined by other tables that reference `ShoppingCartItem`.

### Dependencies
[Back to Top](#shoppingcartitem)

**Dependency Table** refers to the table that the foreign key defined by `ShoppingCartItem` maps to.

**Foreign Key Column** is the column in `ShoppingCartItem` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ShoppingCartItem_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#shoppingcartitem)

**Dependent Table** refers to the table that defines a foreign key mapping to ShoppingCartItem.

**Dependency Key Column** is the column in ShoppingCartItem that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#shoppingcartitem)

ShoppingCartItem has no dependencies.
