# CodeChallengeApi
## Setup
_(ETA: 25~30 mins)_
1. Use [Visual Studio Code](https://code.visualstudio.com/). You can also use Visual Studio 2022 if you have it, but here I will cover VS Code.
2. Install the official [C#](https://code.visualstudio.com/docs/languages/csharp) extension from Microsoft for VS Code. This is available from the 'Extensions' tab in VS Code.
3. Install the latest version of the .NET 6 SDK from this link: https://dotnet.microsoft.com/en-us/download/dotnet/6.0 
4. Verify the installation with `dotnet --list-sdks`
5. Download the code from this repository as a ZIP. You can also clone it or make your own fork, but it's not necessary.
6. Open the root folder in VS Code, and start debugging by pressing "F5".
7. In a browser, navigate to the URL https://localhost:7008/swagger
8. If the Swagger UI page now renders, you are good to go.

**Note:** If you for some reason are unable to complete the setup, the challenges can also be attempted without executing the code. Allthough it will be more difficult.

## Introduction
The solution is split into three main folders:
```
Api
  - CustomersController.cs
  - Program.cs
  - Data repositories
DataModel
  - Customer
  - Account
  - Transaction
  - ExampleData class containing test data to be used throughout the challenges
Tests
  - Unit tests for verifying that challenges has been completed
```
**Please note**
* You should only make changes to files in the **Api** folder.
* All data is stored in memory, no database or files are needed.
* No additional files or classes are needed.

The program defines a data model which represents a very simple financial system with Customers, Accounts and Transactions. The end goal of the challenges is to create a REST API with various operations and methods that utilizes this data model.

## Challenges 

### Challenge 1
In `CustomerController.cs`, implement the empty `Customer? Get(string customerId)` method. 

Verify by running the unit tests in `Tests/Challenge1_Tests.cs`.

### Challenge 2
Implement `Account? Get(string customerId, int accountId)`.

Verify by running the unit tests in `Tests/Challenge2_Tests.cs`.

### Challenge 3 
Implement `decimal? GetTotalBalance(string customerId)`.

Verify by running the unit tests in `Tests/Challenge3_Tests.cs`.

### Challenge 4
Add the following functionality:
1. An API method for adding a new customer.
2. An API method for returning a list of all customers.

The added customers does not have to be persisted, this comes in the next challenge.

### Challenge 5
Make sure newly added customers are persisted in the App's memory and returned when you call the "return all" method. 
