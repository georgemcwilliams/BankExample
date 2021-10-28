# BankExample - For AutoVin interview

There was no interface provided. To exercise the code simply run the test "BankTest".

## Task
Write an object-oriented program, preferably using C#, adhering to the simple requirements listed
below. This program should require no input to run and should not have a user interface. To
demonstrate the functionality of your application, please write test classes that invoke a deposit, a
withdrawal, and a transfer.


## Built to the following requiremnts:

* A bank has a name.
* A bank also has several accounts.
* An account has an owner and a balance.
* Account types include: Checking, Investment.
* There are two types of Investment accounts: Individual, Corporate.
* Individual accounts have a withdrawal limit of 500 dollars.
* Transactions are made on accounts.
* Transaction types include: Deposit, Withdraw, and Transfer

## Is this solution SOLID?

* Single Responsibility Principle: Each class is related to a single purpose. There are no "Swiss Army knife" classes.
* Open/Closed Principle: Account does not need to be modified if additional types are added later.
* Liskov Substitution Principle: CheckingAccount and InvestmentAccount can be used in place of Account without breaking any functionality.
* Interface Segregation Principle: The client is not required to implement an interface that is to broad for it's needs. In fact no interface was added.
* Dependency Inversion Principle: If the scope of this assignment were a little larger this might come into play. Common areas for DI are logging, databases, email, etc.  
