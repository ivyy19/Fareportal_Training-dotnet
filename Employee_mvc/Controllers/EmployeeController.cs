using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using mymvc.Models;

namespace mymvc.Controllers{
    public class EmployeeController:Controller{
        public static Ace52024Context db;
        //Dependency Injection
        public EmployeeController(Ace52024Context _db)
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
            else{
                return RedirectToAction("Login","Login");
            }
            return View(db.Employeetables);

        }
    
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]//button click logic
        public ActionResult AddEmployee(Employeetable e1)
        {
            db.Employeetables.Add(e1);
            db.SaveChanges();
            return RedirectToAction("GetAllEmployees");

        }
        public ActionResult Details(int id)
        {
            Employeetable e1=db.Employeetables.Find(id);
            return View(e1);
        }
        public ActionResult Edit(int id)
        {
            Employeetable e1=db.Employeetables.Find(id);
            return View(e1);
        }
        [HttpPost]
        public ActionResult Edit(Employeetable e1)
        {
            db.Employeetables.Update(e1);
            db.SaveChanges();
            return RedirectToAction("GetAllEmployees");
        }

        public ActionResult Delete(int id)
        {
            Employeetable e1=db.Employeetables.Find(id);
            return View(e1);

        }
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteConf(int id)
        {
            Employeetable e1=db.Employeetables.Find(id);
            db.Employeetables.Remove(e1);
            db.SaveChanges();
            return RedirectToAction("GetAllEmployees");
        }
        

/*        public ActionResult ShowDet()
        {
            List<Employeetable> emps= new List<Employeetable>();
        Employeetable e=new Employeetable();
        e.Eid=201;
        e.Ename="Ivy";
        e.Salary=4000;
        //return View(e);

        Employeetable e1=new Employeetable();
        e1.Eid=500;
        e1.Ename="Dia";
        e1.Salary=600;
        emps.Add(e);
        emps.Add(e1);


        return View(emps);
        }
        public ActionResult GetAllEmployees()
        {
            List<Employeetable> emps= new List<Employeetable>();
        Employeetable e=new Employeetable();
        e.Eid=201;
        e.Ename="Ivy";
        e.Salary=4000;
        //return View(e);

        Employeetable e1=new Employeetable();
        e1.Eid=500;
        e1.Ename="Dia";
        e1.Salary=600;
        emps.Add(e);
        emps.Add(e1);


        return View(emps);

            /*List<Employee> emps= new List<Employee>();
        Employee e=new Employee();
        e.Eid=201;
        e.Name="Ivy";
        e.Salary=4000;
        //return View(e);

        Employee e1=new Employee();
        e1.Eid=500;
        e1.Name="Dia";
        e1.Salary=600;
        emps.Add(e);
        emps.Add(e1);


        return View(emps);*/
        }

    }
