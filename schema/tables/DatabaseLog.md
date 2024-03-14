# DatabaseLog

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
* **Dependencies** - foreign key relationships defined by `DatabaseLog`.
* **Dependents** - foreign key relationships defined by other tables that reference `DatabaseLog`.

### Dependencies
[Back to Top](#databaselog)

**Dependency Table** refers to the table that the foreign key defined by `DatabaseLog` maps to.

**Foreign Key Column** is the column in `DatabaseLog` that maps to **Dependency Key Column** in **Dependency Table**.

No dependencies defined

### Dependents
[Back to Top](#databaselog)

**Dependent Table** refers to the table that defines a foreign key mapping to DatabaseLog.

**Dependency Key Column** is the column in DatabaseLog that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#databaselog)

DatabaseLog has no dependencies.
