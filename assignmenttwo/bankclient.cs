using System;
using System.Collections.Generic;
namespace assignmenttwo;
class BankClient
{
    public static void Main()
    {
        IBankRepository bankRepository = new BankRepository();

        Console.WriteLine("Options:");
        Console.WriteLine("1. Create New Account");
        Console.WriteLine("2. Deposit Amount");
        Console.WriteLine("3. Withdraw Amount");
        Console.WriteLine("4. Get Account Details");
        Console.WriteLine("5. Get All Accounts");
        Console.WriteLine("6. Get Transactions");
        Console.WriteLine("7. Exit");

        while (true)
        {
            Console.Write("Enter your choice: ");
            string? choiceString=Console.ReadLine();

            if(int.TryParse(choiceString,out int choice))
            {
            //int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Account Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine() ?? string.Empty;
                    Console.Write("Enter Customer Address: ");
                    string customerAddress = Console.ReadLine() ?? string.Empty;
                    Console.Write("Enter Initial Deposit Amount: ");
                    string? initialDepositString = Console.ReadLine();
                    if (decimal.TryParse(initialDepositString, out decimal initialDeposit))
                    {
                    SBAccount newAccount = new SBAccount
                    {
                        AccountNumber = accountNumber,
                        CustomerName = customerName,
                        CustomerAddress = customerAddress,
                        CurrentBalance = initialDeposit
                    };

                    bankRepository.NewAccount(newAccount);
                    Console.WriteLine("Account created successfully.");
                    }
                        else
                        {
                            Console.WriteLine("Invalid input for deposit amount.");
                        }
                    break;

                case 2:
                    Console.Write("Enter Account Number: ");
                    int depositAccNo = int.Parse(Console.ReadLine());
                    Console.Write("Enter Deposit Amount: ");
                    decimal depositAmt = decimal.Parse(Console.ReadLine());
                    bankRepository.DepositAmount(depositAccNo, depositAmt);
                    Console.WriteLine("Amount deposited ");
                    break;

                case 3:
                    Console.Write("Enter Account Number: ");
                    int withdrawAccNo = int.Parse(Console.ReadLine());
                    Console.Write("Enter Withdrawal Amount: ");
                    decimal withdrawAmt = decimal.Parse(Console.ReadLine());
                    try
                    {
                        bankRepository.WithdrawAmount(withdrawAccNo, withdrawAmt);
                        Console.WriteLine("Amount withdrawn .");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                case 4:
                    Console.Write("Enter Account Number: ");
                    int accDetailsAccNo = int.Parse(Console.ReadLine());
                    try
                    {
                        SBAccount accDetails = bankRepository.GetAccountDetails(accDetailsAccNo);
                        Console.WriteLine($"Account Details: {accDetails.CustomerName}, {accDetails.CustomerAddress}, Balance: {accDetails.CurrentBalance}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                case 5:
                    List<SBAccount> allAccounts = bankRepository.GetAllAccounts();
                    Console.WriteLine("All Accounts:");
                    foreach (SBAccount acc in allAccounts)
                    {
                        Console.WriteLine($"Account Number: {acc.AccountNumber}, Customer Name: {acc.CustomerName}, Balance: {acc.CurrentBalance}");
                    }
                    break;

                case 6:
                    Console.Write("Enter Account Number: ");
                    int transactionsAccNo = int.Parse(Console.ReadLine());
                    List<SBTransaction> transactions = bankRepository.GetTransactions(transactionsAccNo);
                    Console.WriteLine("Transactions:");
                    foreach (SBTransaction transaction in transactions)
                    {
                        Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Amount: {transaction.Amount}, Type: {transaction.TransactionType}");
                    }
                    break;

                case 7:
                    Console.WriteLine("Exited!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            
            }
        }
        else
        {
            Console.WriteLine("Invalid case. enter number");
        }
        }
    }
}
