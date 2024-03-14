# ProductVendor

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
* **Dependencies** - foreign key relationships defined by `ProductVendor`.
* **Dependents** - foreign key relationships defined by other tables that reference `ProductVendor`.

### Dependencies
[Back to Top](#productvendor)

**Dependency Table** refers to the table that the foreign key defined by `ProductVendor` maps to.

**Foreign Key Column** is the column in `ProductVendor` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_ProductVendor_Product_ProductID** | `ProductID` | [Product](./Product.md) | `ProductID`
**FK_ProductVendor_UnitMeasure_UnitMeasureCode** | `UnitMeasureCode` | [UnitMeasure](./UnitMeasure.md) | `UnitMeasureCode`
**FK_ProductVendor_Vendor_BusinessEntityID** | `BusinessEntityID` | [Vendor](./Vendor.md) | `BusinessEntityID`

### Dependents
[Back to Top](#productvendor)

**Dependent Table** refers to the table that defines a foreign key mapping to ProductVendor.

**Dependency Key Column** is the column in ProductVendor that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#productvendor)

ProductVendor has no dependencies.
