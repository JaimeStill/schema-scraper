# Purchasing.ProductVendor

**Schema**: Purchasing
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#productvendor)

Column | Type | Is Nullable
-------|------|------------
**ProductID** | `int` | False
**BusinessEntityID** | `int` | False
**AverageLeadTime** | `int` | False
**StandardPrice** | `money` | False
**LastReceiptCost** | `money` | True
**LastReceiptDate** | `datetime` | True
**MinOrderQty** | `int` | False
**MaxOrderQty** | `int` | False
**OnOrderQty** | `int` | True
**UnitMeasureCode** | `nchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#productvendor)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.ProductVendor`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.ProductVendor`.

### Dependencies
[Back to Top](#productvendor)


**Table** refers to the table that the foreign key defined by `Purchasing.ProductVendor` maps to.

**Foreign Key** is the column in `Purchasing.ProductVendor` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Production.Product](../Production/Product.md) | `ProductID` | `ProductID` | **FK_ProductVendor_Product_ProductID**
[Production.UnitMeasure](../Production/UnitMeasure.md) | `UnitMeasureCode` | `UnitMeasureCode` | **FK_ProductVendor_UnitMeasure_UnitMeasureCode**
[Purchasing.Vendor](./Vendor.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_ProductVendor_Vendor_BusinessEntityID**

### Dependents
[Back to Top](#productvendor)

No dependencies defined

## Maps
[Back to Top](#productvendor)

### Dependency Map
[Back to Top](#productvendor)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table ProductVendor.

* [Production.Product](../Production/Product.md)
* [Production.ProductModel](./ProductModel.md)
* [Production.ProductSubcategory](./ProductSubcategory.md)
* [Production.ProductCategory](./ProductCategory.md)
* [Production.UnitMeasure](./UnitMeasure.md)
* [Production.UnitMeasure](../Production/UnitMeasure.md)
* [Purchasing.Vendor](./Vendor.md)
* [Person.BusinessEntity](../Person/BusinessEntity.md)
### Dependent Map
[Back to Top](#productvendor)

ProductVendor has no dependents