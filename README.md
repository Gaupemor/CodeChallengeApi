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
The solution contains the following C# code files:
```C#
Program.cs*
CustomersController.cs*
AccountRepository.cs*
CustomerRepository.cs*
Account.cs
Customer.cs
Transaction.cs
TransactionType.cs
ExampleData.cs
```
**Please note:**
* The marked files are the only ones that should require any changes.
* All data is stored in memory, no database or files are needed.
* No additional files or classes to the ones above are needed.

The program defines a data model which represents a very simple financial system with Customers, Accounts and Transactions. The end goal of the challenges is to create a REST API with various operations and methods that utilizes this data model.

## Challenges 
Challenge **1-3** aims to test basic programming skills. 

Challenge **4-5** aims to test basic skills and knowledge in working with Web based API's.

### Challenge 1
In `CustomerController.cs`, implement the empty `Customer Get(string customerId)` method so that it works as one would expect. 

You can test the method by calling its corresponding endpoint in the Swagger UI.

### Challenge 2
Add a new API method at `'/customers/{customerId}/balance'` that should return the balance, i.e. the sum of all accounts for a customer.

### Challenge 3 
Add an API method for adding a new customer

### Challenge 4
Add an API method for returning all customers

### Challenge 5
Change the code so that newly added customers are persisted in the App's memory and returned when you call the "return all" method. 

**Hint:** You should only have to change one line of code in order to achieve this.
