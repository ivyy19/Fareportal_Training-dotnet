using flightmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace flightmvc.Controllers
{
    public class LoginController:Controller{
        private readonly Ace52024Context db;
        private readonly ISession session;

        public LoginController(Ace52024Context _db,IHttpContextAccessor HttpContextAccessor)
        {
            db=_db;
            session=HttpContextAccessor.HttpContext.Session;

        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IvyUser v)
        {
            var result=(from i in db.IvyUsers where i.Email==v.Email && i.Password==v.Password select i).SingleOrDefault();
            if(result!=null)
            {
                HttpContext.Session.SetString("Username",result.Username);
                return RedirectToAction("BookIndex","Booking");
            }
            else
                return View();

            }
            [HttpGet]
            public IActionResult Register()
            {
                return View();

            }

            [HttpPost]

            public IActionResult Register(IvyUser v)
            {
                if(ModelState.IsValid)
                {
                    db.IvyUsers.Add(v);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
                else{
                    return View();
                }
            }
            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
        }

    }
