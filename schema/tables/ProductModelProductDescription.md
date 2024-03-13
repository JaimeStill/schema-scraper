# ProductModelProductDescription

* [Relationships](#relationships)
* [Columns](#columns)
* [Dependency Map](#dependency-map)

## Relationships
[Back to Top](#productmodelproductdescription)

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductModelProductDescription_ProductDescription_ProductDescriptionID** | `ProductDescriptionID` | [ProductDescription](./ProductDescription.md) | `ProductDescriptionID`
**FK_ProductModelProductDescription_ProductModel_ProductModelID** | `ProductModelID` | [ProductModel](./ProductModel.md) | `ProductModelID`

## Columns
[Back to Top](#productmodelproductdescription)

Column | Type | Is Nullable
-------|------|------------
**ProductModelID** | `int` | False
**ProductDescriptionID** | `int` | False
**Culture** | `nchar` | False
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Dependency Map
[Back to Top](#productmodelproductdescription)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductModelProductDescription.

* [ProductDescription](./ProductDescription.md)
* [ProductModel](./ProductModel.md)
