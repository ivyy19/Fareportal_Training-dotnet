using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using mvcfirst.Models;

namespace mvcfirst.Controllers
{
    public class BankController:Controller{
        readonly Ace52024Context db=new();

        public IActionResult Showw()
        {
           List<Sbaccountivy> sbaccounts =[..db.Sbaccountivies.Where(x=> true)];
           return View(sbaccounts);
        }
        public IActionResult Showtrans()
        {
            List<Sbtransactionsivy>sbt=[..db.Sbtransactionsivies.Where(x=> true)];
            return View(sbt);

        }
    }
}