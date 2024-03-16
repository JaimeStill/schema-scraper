# Purchasing.Vendor

**Schema**: Purchasing
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
* **Dependencies** - foreign key relationships defined by `Purchasing.Vendor`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.Vendor`.

### Dependencies
[Back to Top](#vendor)


**Table** refers to the table that the foreign key defined by `Purchasing.Vendor` maps to.

**Foreign Key** is the column in `Purchasing.Vendor` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](../Person/BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Vendor_BusinessEntity_BusinessEntityID**

### Dependents
[Back to Top](#vendor)

**Table** refers to the table that defines a foreign key mapping to Vendor.

**Primary Key** is the column in Vendor that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.ProductVendor](./ProductVendor.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_ProductVendor_Vendor_BusinessEntityID**
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `BusinessEntityID` | `VendorID` | **FK_PurchaseOrderHeader_Vendor_VendorID**

## Maps
[Back to Top](#vendor)

### Dependency Map
[Back to Top](#vendor)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Vendor.

* [Person.BusinessEntity](../Person/BusinessEntity.md)
### Dependent Map
[Back to Top](#vendor)

> The following is a distinct list of tables captured by recursively evaluating tables that list Vendor as a foreign key dependency.

* [Purchasing.ProductVendor](./ProductVendor.md)
* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
