# Purchasing.Vendor

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#purchasingvendor)

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
[Back to Top](#purchasingvendor)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Purchasing.Vendor`.
* **Dependents** - foreign key relationships defined by other tables that reference `Purchasing.Vendor`.

### Dependencies
[Back to Top](#purchasingvendor)


**Table** refers to the table that the foreign key defined by `Purchasing.Vendor` maps to.

**Foreign Key** is the column in `Purchasing.Vendor` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.BusinessEntity](../Person/BusinessEntity.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_Vendor_BusinessEntity_BusinessEntityID**

### Dependents
[Back to Top](#purchasingvendor)

**Table** refers to the table that defines a foreign key mapping to Purchasing.Vendor.

**Primary Key** is the column in Purchasing.Vendor that maps to **Foreign Key** in **Table**.

Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Purchasing.ProductVendor](./ProductVendor.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_ProductVendor_Vendor_BusinessEntityID**
[Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md) | `BusinessEntityID` | `VendorID` | **FK_PurchaseOrderHeader_Vendor_VendorID**

## Maps
[Back to Top](#purchasingvendor)

### Dependency Map
[Back to Top](#purchasingvendor)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Purchasing.Vendor.

* [Person.BusinessEntity](../Person/BusinessEntity.md)

### Dependent Map
[Back to Top](#purchasingvendor)

> The following is a distinct list of tables captured by recursively evaluating tables that list Purchasing.Vendor as a foreign key dependency.

* [Purchasing.ProductVendor](./ProductVendor.md)
* [Purchasing.PurchaseOrderDetail](./PurchaseOrderDetail.md)
* [Purchasing.PurchaseOrderHeader](./PurchaseOrderHeader.md)

