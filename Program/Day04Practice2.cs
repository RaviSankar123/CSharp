/*
In this assignment, you will create a simple banking system using C#. You will define classes to represent bank accounts and implement functionalities for deposit, withdrawal, and balance inquiry operations.

Task:

Define Account Class:
Create a class named Account to represent bank accounts.
Add properties to the class: AccountNumber (string type), Balance (decimal type), and OwnerName (string type).
Implement access modifiers to control access to account properties.
Implement Operations:
Add methods to the Account class for depositing funds, withdrawing funds, and checking account balance.
Use access modifiers to restrict access to sensitive operations like withdrawing funds.
Input Handling:
Prompt the user to enter account details (account number, owner name) when creating a new account or performing transactions.
Use appropriate data types for user input and validation.
Perform Transactions:
Allow users to deposit funds into their account by specifying the deposit amount.
Allow users to withdraw funds from their account by specifying the withdrawal amount.
Display the updated account balance after each transaction.
Instructions:

Write the C# code to implement the banking system as described above.
Ensure that access modifiers are used appropriately to maintain data privacy and security.
Test your program by creating accounts, depositing funds, and withdrawing funds to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the banking system.
Include any additional instructions or notes if necessary.

*/

using System;

class Account
{
    // Define properties
    // Complete Step 1:............
    private string AccountNumber;
    private double Balance;
    private string OwnerName;

    public Account(string AccountNumber,string OwnerName){
        this.AccountNumber=AccountNumber;
        this.OwnerName=OwnerName;
        Balance=0.00;

    }
    // Define methods
    // Complete Step 2:............
    public void DepositingFunds(double amount){
        if(amount>0){
            Balance=Balance+amount;
            Console.WriteLine("Deposited: $"+amount.ToString("0.00"));
            CheckingBalance();
        }
    }

    public void WithdrawFunds(double amount){
        if(amount>0 && amount<=Balance){
            Balance=Balance-amount;
            Console.WriteLine("Withdrew: $"+amount.ToString("0.00"));
            CheckingBalance();
        }
    }

    public void CheckingBalance(){
        Console.WriteLine("Account Balance: $"+Balance.ToString("0.00"));

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        string AccountNumber=Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        string OwnerName=Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............
        Account ac = new Account(AccountNumber, OwnerName);
        ac.DepositingFunds(100.00);
        ac.WithdrawFunds(50.00);

        // Perform transactions
        // Complete Step 6:............
    }
}