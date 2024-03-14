# Document

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
* **Dependencies** - foreign key relationships defined by `Document`.
* **Dependents** - foreign key relationships defined by other tables that reference `Document`.

### Dependencies
[Back to Top](#document)

**Dependency Table** refers to the table that the foreign key defined by `Document` maps to.

**Foreign Key Column** is the column in `Document` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Document_Employee_Owner** | `Owner` | [Employee](./Employee.md) | `BusinessEntityID`

### Dependents
[Back to Top](#document)

**Dependent Table** refers to the table that defines a foreign key mapping to Document.

**Dependency Key Column** is the column in Document that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductDocument](./ProductDocument.md) | **FK_ProductDocument_Document_DocumentNode** | `DocumentNode` | `DocumentNode`

## Dependency Map
[Back to Top](#document)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Document.

* [ProductDocument](./ProductDocument.md)
