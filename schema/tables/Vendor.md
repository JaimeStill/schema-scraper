# Vendor

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#vendor)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**AccountNumber** | `nvarchar` | False
**Name** | `nvarchar` | False
**CreditRating** | `tinyint` | False
**PreferredVendorStatus** | `bit` | False
**ActiveFlag** | `bit` | False
**PurchasingWebServiceURL** | `nvarchar` | True
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#vendor)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Vendor`.
* **Dependents** - foreign key relationships defined by other tables that reference `Vendor`.

### Dependencies
[Back to Top](#vendor)

**Dependency Table** refers to the table that the foreign key defined by `Vendor` maps to.

**Foreign Key Column** is the column in `Vendor` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_Vendor_BusinessEntity_BusinessEntityID** | `BusinessEntityID` | [BusinessEntity](./BusinessEntity.md) | `BusinessEntityID`

### Dependents
[Back to Top](#vendor)

**Dependent Table** refers to the table that defines a foreign key mapping to Vendor.

**Dependency Key Column** is the column in Vendor that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[ProductVendor](./ProductVendor.md) | **FK_ProductVendor_Vendor_BusinessEntityID** | `BusinessEntityID` | `BusinessEntityID`
[PurchaseOrderHeader](./PurchaseOrderHeader.md) | **FK_PurchaseOrderHeader_Vendor_VendorID** | `VendorID` | `BusinessEntityID`

## Dependency Map
[Back to Top](#vendor)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Vendor.

* [ProductVendor](./ProductVendor.md)
* [PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [PurchaseOrderDetail](./PurchaseOrderDetail.md)
