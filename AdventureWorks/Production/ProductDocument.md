# Production.ProductDocument

**Schema**: Production
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
* **Dependencies** - foreign key relationships defined by `Production.ProductDocument`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductDocument`.

### Dependencies
[Back to Top](#productdocument)


**Table** refers to the table that the foreign key defined by `Production.ProductDocument` maps to.

**Foreign Key** is the column in `Production.ProductDocument` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Document](./Document.md) | `DocumentNode` | `DocumentNode` | **FK_ProductDocument_Document_DocumentNode**
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductDocument_Product_ProductID**

### Dependents
[Back to Top](#productdocument)

No dependencies defined

## Maps
[Back to Top](#productdocument)

### Dependency Map
[Back to Top](#productdocument)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductDocument.

* [Production.Document](./Document.md)
* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Production.Product](./Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
### Dependent Map
[Back to Top](#productdocument)

ProductDocument has no dependents
