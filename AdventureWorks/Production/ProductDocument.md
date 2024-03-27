# Production.ProductDocument

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#productionproductdocument)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**DocumentNode** | `hierarchyid` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productionproductdocument)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.ProductDocument`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.ProductDocument`.

### Dependencies
[Back to Top](#productionproductdocument)


**Table** refers to the table that the foreign key defined by `Production.ProductDocument` maps to.

**Foreign Key** is the column in `Production.ProductDocument` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Document](./Document.md) | `DocumentNode` | `DocumentNode` | **FK_ProductDocument_Document_DocumentNode**
[Production.Product](./Product.md) | `ProductID` | `ProductID` | **FK_ProductDocument_Product_ProductID**

### Dependents
[Back to Top](#productionproductdocument)

No dependencies defined

## Maps
[Back to Top](#productionproductdocument)

### Dependency Map
[Back to Top](#productionproductdocument)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Production.ProductDocument.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
* [Person.Person](../Person/Person.md)
* [Production.Document](./Document.md)
* [Production.Product](./Product.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)

### Dependent Map
[Back to Top](#productionproductdocument)

Production.ProductDocument has no dependents

