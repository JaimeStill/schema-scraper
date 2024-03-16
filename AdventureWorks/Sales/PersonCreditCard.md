# Sales.PersonCreditCard

* [Columns](#columns)
* [Relationships](#relationships)
    * [Dependencies](#dependencies)
    * [Dependents](#dependents)
* [Maps](#maps)
    * [Dependency Map](#dependency-map)
    * [Dependent Map](#dependent-map)

## Columns
[Back to Top](#salespersoncreditcard)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**CreditCardID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#salespersoncreditcard)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.PersonCreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.PersonCreditCard`.

### Dependencies
[Back to Top](#salespersoncreditcard)


**Table** refers to the table that the foreign key defined by `Sales.PersonCreditCard` maps to.

**Foreign Key** is the column in `Sales.PersonCreditCard` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](../Person/Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonCreditCard_Person_BusinessEntityID**
[Sales.CreditCard](./CreditCard.md) | `CreditCardID` | `CreditCardID` | **FK_PersonCreditCard_CreditCard_CreditCardID**

### Dependents
[Back to Top](#salespersoncreditcard)

No dependencies defined

## Maps
[Back to Top](#salespersoncreditcard)

### Dependency Map
[Back to Top](#salespersoncreditcard)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table Sales.PersonCreditCard.

* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.CreditCard](./CreditCard.md)
### Dependent Map
[Back to Top](#salespersoncreditcard)

Sales.PersonCreditCard has no dependents
