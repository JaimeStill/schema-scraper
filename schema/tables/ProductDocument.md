# ProductDocument

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productdocument)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**DocumentNode** | `hierarchyid` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productdocument)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `ProductDocument`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductDocument`.

### Dependencies
[Back to Top](#productdocument)

**Dependency Table** refers to the table that the foreign key defined by `ProductDocument` maps to.

**Foreign Key Column** is the column in `ProductDocument` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductDocument_Document_DocumentNode** | `DocumentNode` | [Document](./Document.md) | `DocumentNode`
**FK_ProductDocument_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`

### Dependents
[Back to Top](#productdocument)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductDocument.

**Dependency Key Column** is the column in ProductDocument that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productdocument)

ProductDocument has no dependencies.
