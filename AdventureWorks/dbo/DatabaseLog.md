# dbo.DatabaseLog

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#dbodatabaselog)

Column | Type | Is Nullable
-------|------|------------
**DatabaseLogID** | `int` | False
**PostTime** | `datetime` | False
**DatabaseUser** | `nvarchar` | False
**Event** | `nvarchar` | False
**Schema** | `nvarchar` | True
**Object** | `nvarchar` | True
**TSQL** | `nvarchar` | False
**XmlEvent** | `xml` | False

## Relationships
[Back to Top](#dbodatabaselog)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `dbo.DatabaseLog`.
* **Dependents** - foreign key relationships defined by other tables that reference `dbo.DatabaseLog`.

### Dependencies
[Back to Top](#dbodatabaselog)


No dependencies defined

### Dependents
[Back to Top](#dbodatabaselog)

No dependencies defined

## Maps
[Back to Top](#dbodatabaselog)

### Dependency Map
[Back to Top](#dbodatabaselog)

dbo.DatabaseLog has no dependencies
### Dependent Map
[Back to Top](#dbodatabaselog)

dbo.DatabaseLog has no dependents
