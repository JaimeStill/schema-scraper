# Production.Document

**Schema**: Production
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#document)

Column | Type | Is Nullable
-------|------|------------
**DocumentNode** | `hierarchyid` | False
**DocumentLevel** | `smallint` | True
**Title** | `nvarchar` | False
**Owner** | `int` | False
**FolderFlag** | `bit` | False
**FileName** | `nvarchar` | False
**FileExtension** | `nvarchar` | False
**Revision** | `nchar` | False
**ChangeNumber** | `int` | False
**Status** | `tinyint` | False
**DocumentSummary** | `nvarchar` | True
**Document** | `varbinary` | True
**rowguid** | `uniqueidentifier` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#document)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Production.Document`.
* **Dependents** - foreign key relationships defined by other tables that reference `Production.Document`.

### Dependencies
[Back to Top](#document)


**Table** refers to the table that the foreign key defined by `Production.Document` maps to.

**Foreign Key** is the column in `Production.Document` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[HumanResources.Employee](../HumanResources/Employee.md) | `BusinessEntityID` | `Owner` | **FK_Document_Employee_Owner**

### Dependents
[Back to Top](#document)

**Table** refers to the table that defines a foreign key mapping to Document.

**Primary Key** is the column in Document that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.ProductDocument](./ProductDocument.md) | `DocumentNode` | `DocumentNode` | **FK_ProductDocument_Document_DocumentNode**

## Maps
[Back to Top](#document)

### Dependency Map
[Back to Top](#document)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Document.

* [HumanResources.Employee](../HumanResources/Employee.md)
* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
### Dependent Map
[Back to Top](#document)

> The following is a distinct list of tables captured by recursively evaluating tables that list Document as a foreign key dependency.

* [Production.ProductDocument](./ProductDocument.md)
