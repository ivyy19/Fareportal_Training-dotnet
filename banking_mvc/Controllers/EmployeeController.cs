/*using Microsoft.AspNetCore.Mvc;
using mvcfirst.Models;
namespace mvcfirst.Controllers
{
    public class EmployeeController:Controller{
        public static Ace52024Context ac =new Ace52024Context();
        public ActionResult GetAllEmployees()
        {
            return View(ac.Employee);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee( Employee e)

        {
            ac.Employees.Add(e);
            ac.SaveChanges();
            return RedirectToAction("GetAllEmployees");

        }
        public ActionResult Details(int id)
        {
            Employee e= ac.Employees.Find(id);
            return View(e);
        }
    }
}*/