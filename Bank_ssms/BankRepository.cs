using System.Security.Cryptography;
using ssmsbank.Models;

namespace ssmsbank.Models
{
    public class BankRepository : IBankRepository
    {
        public List<Sbaccountivy> SBAccounts = [];
        public List<Sbtransactionsivy> SBTransactions = [];
        public readonly Ace52024Context db = new();

        public void NewAccount(Sbaccountivy sBAccount)
        {
            db.Sbaccountivies.Add(sBAccount);
            db.SaveChanges();
        }

        public Sbaccountivy? GetAccountDetails(int accno)
        {
            Sbaccountivy? sbaccountivy = db.Sbaccountivies.Find(accno);
            return sbaccountivy;
        }

        public List<Sbaccountivy> GetAllAccounts()
        {
            return [.. db.Sbaccountivies.Where(x => true)];
        }

        public void DepositAmount(int accno, decimal amt)
        {
            Sbaccountivy? account = db.Sbaccountivies.Find(accno);
            if (account != null)
            {
                account.CurrentBalance += amt;
                db.Sbaccountivies.Update(account);

                Sbtransactionsivy sBTransaction = new()
                {
                    TransactionType = "Deposit",
                    TransactionDate = DateTime.Now,
                    AccountNumber = accno,
                    Amount = amt
                };

                db.Sbtransactionsivies.Add(sBTransaction);
                db.SaveChanges();
                Console.WriteLine("Transaction successfull");
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
        public void WithDrawAmount(int accno, decimal amt)
        {
            Sbaccountivy? account = db.Sbaccountivies.Find(accno);
            if (account != null)
            {
                account.CurrentBalance -= amt;
                db.Sbaccountivies.Update(account);

                Sbtransactionsivy sBTransaction = new()
                {
                    TransactionType = "Withdraw",
                    TransactionDate = DateTime.Now,
                    AccountNumber = accno,
                    Amount = amt
                };

                db.Sbtransactionsivies.Add(sBTransaction);
                db.SaveChanges();
                Console.WriteLine("Transaction successfull");
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
        public List<Sbtransactionsivy>? GetTransactions(int accno)
        {
            return [.. db.Sbtransactionsivies.Where(x => x.AccountNumber == accno)];
        }
    }
}