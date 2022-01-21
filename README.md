# CodeChallengeApi
## Setup
_(ETA: 25~30 mins)_
* Use [Visual Studio Code](https://code.visualstudio.com/). You can also use Visual Studio 2022 if you have it, but here I will cover VS Code.
* Install the official [C#](https://code.visualstudio.com/docs/languages/csharp) extension from Microsoft for VS Code. This is available from the 'Extensions' tab in VS Code.
* Install the latest version of the .NET 6 SDK from this link: https://dotnet.microsoft.com/en-us/download/dotnet/6.0
  * Verify the installation with `dotnet --list-sdks`
* Download the code from this repository as a ZIP. You can also clone it or make your own fork, but it's not necessary.
* Open the root folder in VS Code, and start debugging by pressing "F5".
* In a browser, navigate to the URL https://localhost:7008/swagger
* If the Swagger UI now renders, you are good to go.

## Introduction
The solution contains the following C# code files:
```C#
Program.cs 
CustomersController.cs
Account.cs
Customer.cs
AccountRepository.cs
CustomerRepository.cs
ExampleData.cs
```

The data model represents a very simple financial system with Customers that can have any number of Accounts.

All data is stored in memory, no database or files are needed to complete the challenges.

You should only have to make changes in the files listed above. No additional classes are needed to complete the challenges.

## Challenge 1
Implement the `GET '/customers/{customerId}'` API method so that it works as expected.

## Challenge 2
Add a new API method at `'/customers/{customerId}/balance'` that should return the balance, i.e. the sum of all accounts for a customer.

## Challenge 3 
Add an API method for adding a new customer

## Challenge 4
Add an API method for returning all customers

## Challenge 5
Change the code so that newly added customers are persisted in the App's memory and returned when you call the "return all" method. 

**Hint:** You should only have to change one line of code in order to achieve this.
