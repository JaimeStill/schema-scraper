# dbo.DatabaseLog

**Schema**: dbo
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#databaselog)

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
[Back to Top](#databaselog)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `dbo.DatabaseLog`.
* **Dependents** - foreign key relationships defined by other tables that reference `dbo.DatabaseLog`.

### Dependencies
[Back to Top](#databaselog)


No dependencies defined

### Dependents
[Back to Top](#databaselog)

No dependencies defined

## Maps
[Back to Top](#databaselog)

### Dependency Map
[Back to Top](#databaselog)

DatabaseLog has no dependencies
### Dependent Map
[Back to Top](#databaselog)

DatabaseLog has no dependents
