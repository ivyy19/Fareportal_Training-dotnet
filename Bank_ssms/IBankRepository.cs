using ssmsbank.Models;

namespace ssmsbank.Models
{
    interface IBankRepository
    {
        void NewAccount(Sbaccountivy acc);
        List<Sbaccountivy>? GetAllAccounts();
        Sbaccountivy? GetAccountDetails(int accno);
        void DepositAmount(int accno, decimal amt);
        void WithDrawAmount(int accno, decimal amt);
        List<Sbtransactionsivy>? GetTransactions(int accno);
    }
}