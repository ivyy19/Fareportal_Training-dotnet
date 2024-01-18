using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using mymvc.Models;
namespace mymvc.Controllers
{
    public class LoginController:Controller{
        public static Ace52024Context db;
        //Dependency Injection
        public LoginController(Ace52024Context _db)
        {
            db=_db;
        }
        public ActionResult GetAllEmployees()
        {
            ViewBag.UserName=HttpContext.Session.GetString("uname");
            if(ViewBag.Username!=null)
            {
                return View(db.Employeetables);
            }
            else 
            {
                return RedirectToAction("Login","Login");
            }
        }
    
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login(UsertblIvy u)
        {
            var result=(from i in db.UsertblIvies
                        where i.Email==u.Email && i.Password==u.Password
                        select i).SingleOrDefault();

           if(result!=null)
            {
                HttpContext.Session.SetString("uname",result.Username);
                return RedirectToAction("GetAllEmployees","Employee");
            }
            else{
                return View();
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("GetAllEmployees");
        }
    }
}
