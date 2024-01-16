using System;
using System.Collections.Generic;
namespace assignmenttwo;

public class BankRepository : IBankRepository
{
    private List<SBAccount> accounts =new List<SBAccount>();
    private List<SBTransaction> transactions=new List<SBTransaction>();

    public void NewAccount(SBAccount acc)
    {
        if (accounts.Any(a => a.AccountNumber == acc.AccountNumber))
    {
        throw new Exception("Error: Account number already in use.");
    }
        accounts.Add(acc);
        Console.WriteLine("Account Number: " + acc.AccountNumber);
    }
    public List<SBAccount> GetAllAccounts()
    {
        return accounts;
    }

    public SBAccount GetAccountDetails(int accno)
    {
        SBAccount? account = accounts.Find(a => a.AccountNumber == accno);
        if (account == null)
        {
            throw new Exception("Account not found.");
        }
        return account;
    }

    public void DepositAmount(int accno, decimal amt)
    {
        SBAccount account = GetAccountDetails(accno);
        if(account!=null)
        {

        
        account.CurrentBalance += amt;

        transactions.Add(new SBTransaction
        {
            TransactionId = transactions.Count + 1,
            TransactionDate = DateTime.Now,
            AccountNumber = accno,
            Amount = amt,
            TransactionType = "Deposit"
        });
    //Console.WriteLine("Amount deposited");
        }
        else{
            Console.WriteLine("Error");
        }
    }
    public void WithdrawAmount(int accno, decimal amt)
    {
        SBAccount account = GetAccountDetails(accno);
        if (account.CurrentBalance < amt)
        {
            throw new Exception("Insufficient balance.");
        }

        account.CurrentBalance -= amt;

        transactions.Add(new SBTransaction
        {
            TransactionId = transactions.Count + 1,
            TransactionDate = DateTime.Now,
            AccountNumber = accno,
            Amount = amt,
            TransactionType = "Withdrawal"
        });
    }

    public List<SBTransaction> GetTransactions(int accno)
    {
        return transactions.FindAll(t => t.AccountNumber == accno);
    }
}




