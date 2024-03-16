# Sales.PersonCreditCard

**Schema**: Sales
* [Columns](#columns)
* [Relationships](#relationships)
* [Dependency Map](#dependency-map)

## Columns
[Back to Top](#personcreditcard)

Column | Type | Is Nullable
-------|------|------------
**BusinessEntityID** | `int` | False
**CreditCardID** | `int` | False
**ModifiedDate** | `datetime` | False

## Relationships
[Back to Top](#personcreditcard)


The sections that follow define:
* **Dependencies** - foreign key relationships defined by `Sales.PersonCreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `Sales.PersonCreditCard`.

### Dependencies
[Back to Top](#personcreditcard)


**Table** refers to the table that the foreign key defined by `Sales.PersonCreditCard` maps to.

**Foreign Key** is the column in `Sales.PersonCreditCard` that maps to **Primary Key** in **Table**.
Table | Primary Key | Foreign Key | Foreign Key Name
------|-------------|-------------|-----------------
[Person.Person](../Person/Person.md) | `BusinessEntityID` | `BusinessEntityID` | **FK_PersonCreditCard_Person_BusinessEntityID**
[Sales.CreditCard](./CreditCard.md) | `CreditCardID` | `CreditCardID` | **FK_PersonCreditCard_CreditCard_CreditCardID**

### Dependents
[Back to Top](#personcreditcard)

No dependencies defined

## Maps
[Back to Top](#personcreditcard)

### Dependency Map
[Back to Top](#personcreditcard)

> The following is a distinct list of tables captured by recursively evaluating the foreign key dependency tree for table PersonCreditCard.

* [Person.Person](../Person/Person.md)
* [Person.BusinessEntity](./BusinessEntity.md)
* [Sales.CreditCard](./CreditCard.md)
### Dependent Map
[Back to Top](#personcreditcard)

PersonCreditCard has no dependents
