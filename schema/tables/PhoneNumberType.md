# PhoneNumberType

* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#phonenumbertype)

Column | Type | Is Nullable
-------|------|------------
**PhoneNumberTypeID** | `int` | False
**Name** | `nvarchar` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#phonenumbertype)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `PhoneNumberType`.
* **Dependents** - foreign key relationships defined by other tables that reference `PhoneNumberType`.

### Dependencies
[Back to Top](#phonenumbertype)

**Dependency Table** refers to the table that the foreign key defined by `PhoneNumberType` maps to.

**Foreign Key Column** is the column in `PhoneNumberType` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#phonenumbertype)

**Dependent Table** refers to the table that defines a foreign key mapping to PhoneNumberType.

**Dependency Key Column** is the column in PhoneNumberType that maps to **Foreign Key Column** in **Dependent Table**.

Dependent Table | Foreign Key Name | Foreign Key Column | Dependency Key Column
----------------|------------------|--------------------|----------------------
[PersonPhone](./PersonPhone.md) | **FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID** | `PhoneNumberTypeID` | `PhoneNumberTypeID`

## Dependency Map
[Back to Top](#phonenumbertype)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PhoneNumberType.

* [PersonPhone](./PersonPhone.md)
