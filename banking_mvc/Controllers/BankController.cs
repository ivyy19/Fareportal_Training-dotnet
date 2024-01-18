using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using mvcfirst.Models;

namespace mvcfirst.Controllers
{
    public class BankController(Ace52024Context db1):Controller{
        readonly Ace52024Context db=db1;

        public IActionResult Showw()
        {
           List<Sbaccountivy> sbaccounts =[..db.Sbaccountivies];
           return View(sbaccounts);
        }
       
        public IActionResult Showtrans()
        {
            List<Sbtransactionsivy>sbt=[..db.Sbtransactionsivies];
            return View(sbt);

        }
        [HttpGet]
        public IActionResult AddSBTrans()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddSBAcct(Sbaccountivy account)
        {
            db.Sbaccountivies.Add(account);
            db.SaveChanges();
            return RedirectToAction("ShowSbAccounts");
        }

        [HttpPost]

        public IActionResult AddSBTrans(Sbtransactionsivy tx)
        {
            Sbaccountivy? account =db.Sbaccountivies.Find(tx.AccountNumber);
            if(account!=null)
            {
                if(tx.TransactionType=="Withdraw") account.CurrentBalance-=tx.Amount;
                else if (tx.TransactionType=="Deposit") account.CurrentBalance+=tx.Amount;
                else return RedirectToAction("ShowSBTransactions");

                db.Sbaccountivies.Update(account);
                db.Sbtransactionsivies.Add(tx);
                db.SaveChanges();
            

            }
            return RedirectToAction("ShowSBTransactions");
        }


        [HttpGet]
        public IActionResult UpdateSbAccount(int id)
        {
            Sbaccountivy? account = db.Sbaccountivies.Find(id);
            return View(account);
        }

        [HttpPost]
        public IActionResult UpdateSbAccount(Sbaccountivy account)
        {
            db.Sbaccountivies.Update(account);
            db.SaveChanges();
            return RedirectToAction("ShowSbAccounts");
        }

        [HttpGet]

        public IActionResult UpdateSbTransaction(int id)
        {
            Sbtransactionsivy? tx= db.Sbtransactionsivies.Find(id);
            return View(tx);
        }

        [HttpPost]
        public IActionResult UpdateSbTransaction(Sbtransactionsivy tx)
        {
            db.Sbtransactionsivies.Update(tx);
            db.SaveChanges();
            return RedirectToAction("ShowSBTransactions");
        }

        [HttpGet]

        public IActionResult GetSbTransactions(int id)
        {
            Sbtransactionsivy? tx=db.Sbtransactionsivies.Find(id);
            return View(tx);
        }

        [HttpGet]
        public IActionResult DeleteAccount(int id)
        {
            Sbaccountivy? account =db.Sbaccountivies.Find(id);
            return View(account);
        }

        [HttpPost]
        [ActionName("DeleteAccount")]
        
        public IActionResult DeleteAccountConfirmed(int id)
        {
            Sbaccountivy? account =db.Sbaccountivies.Find(id);
            if(account!=null) db.Sbaccountivies.Remove(account);
            db.SaveChanges();
            return RedirectToAction("ShowSbAccounts");
        }

        [HttpGet]

        public IActionResult DeleteTransaction(int id)
        {
            Sbtransactionsivy? tx=db.Sbtransactionsivies.Find(id);
            return View(tx);
        }

        [HttpPost]
        [ActionName("DeleteTransaction")]

        public IActionResult DeleteTransactionConfirmed(int id)
        {
            Sbtransactionsivy? tx=db.Sbtransactionsivies.Find(id);
            if(tx!=null) db.Sbtransactionsivies.Remove(tx);
            db.SaveChanges();
            return RedirectToAction("ShowSbTransactions");
        }
    }
}