using flightmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace flightmvc.Controllers
{
    public class CustomerController: Controller{
        private readonly Ace52024Context db;

        public CustomerController(Ace52024Context _db)
        {
            db=_db;
        }

        public ActionResult CustomIndex()
        {
            List<CustomerIvy> customers =[..db.CustomerIvies.Where(x=>true)];
            return View(customers);
        }

        
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
       

        public ActionResult Create(CustomerIvy customer)
        {
            if(ModelState.IsValid)
            {
                db.CustomerIvies.Add(customer);
                db.SaveChanges();
                return RedirectToAction("BookIndex","Booking");
            }
            return View(customer);
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("CustomIndex");
            }
            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            return View(customer);

            
        }

        [HttpPost]
       

        public ActionResult Edit(CustomerIvy customer)
             {
            

            if(ModelState.IsValid)
            {
            customer.CustomerId=Convert.ToInt32(TempData["custid"]);
                db.CustomerIvies.Update(customer);
                db.SaveChanges();
                return RedirectToAction("CustomIndex");
            }
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            return View(customer);
        }

        [HttpPost]

        public ActionResult Details(CustomerIvy customer)
        {
            return View(customer);
        }

        public ActionResult Delete(int? id)
        {
            CustomerIvy customer =db.CustomerIvies.Where(x=>x.CustomerId==id).SingleOrDefault();
            TempData["custid"]=id;
            return View(customer);

        }

        [HttpPost]
       
        public ActionResult Delete(CustomerIvy customer)

        {
          customer.CustomerId=Convert.ToInt32(TempData["custid"]);
          db.CustomerIvies.Remove(customer);
          db.SaveChanges();
          return RedirectToAction("CustomIndex");
        }



    }
}