# PersonCreditCard

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
* **Dependencies** - foreign key relationships defined by `PersonCreditCard`.
* **Dependents** - foreign key relationships defined by other tables that reference `PersonCreditCard`.

### Dependencies
[Back to Top](#personcreditcard)

**Dependency Table** refers to the table that the foreign key defined by `PersonCreditCard` maps to.

**Foreign Key Column** is the column in `PersonCreditCard` that maps to **Dependency Key Column** in **Dependency Table**.

Foreign Key Name | Foreign Key Column | Dependency Table | Dependency Key Column
-----------------|--------------------|------------------|----------------------
**FK_PersonCreditCard_CreditCard_CreditCardID** | `CreditCardID` | [CreditCard](./CreditCard.md) | `CreditCardID`
**FK_PersonCreditCard_Person_BusinessEntityID** | `BusinessEntityID` | [Person](./Person.md) | `BusinessEntityID`

### Dependents
[Back to Top](#personcreditcard)

**Dependent Table** refers to the table that defines a foreign key mapping to PersonCreditCard.

**Dependency Key Column** is the column in PersonCreditCard that maps to **Foreign Key Column** in **Dependent Table**.

No dependencies defined

## Dependency Map
[Back to Top](#personcreditcard)

PersonCreditCard has no dependencies.
