using System.Net;
using flightmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace flightmvc.Controllers
{
    public class FlightController:Controller{
        private readonly Ace52024Context db;

        public FlightController(Ace52024Context _db)
        {
            db=_db;
        }

        //getting list of flights

       [HttpGet]
        public ActionResult Show()
        {
            List<FlightsIvy>flights =[..db.FlightsIvies.Where(x=>true)];
            return View(flights);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Add(FlightsIvy flight)
        {
            if(ModelState.IsValid)
            {
            db.FlightsIvies.Add(flight);
            db.SaveChanges();
            return RedirectToAction("BookIndex","Booking");
            }
            return View(flight);
        }

        public ActionResult Edit(int id)
        {
            FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
            return View(flight);
        }

        [HttpPost]

        public ActionResult Edit(FlightsIvy flight)
        {
            if(ModelState.IsValid)
            {
            flight.FlightId=Convert.ToInt32(TempData["flightid"]);
            db.FlightsIvies.Update(flight);
            db.SaveChanges();
            return RedirectToAction("Show");
            }
            return View(flight);
        }

        public ActionResult Details(int id)
        {
            FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
            return View(flight);
        }
        

    
        public ActionResult Delete(int id)
        {
            FlightsIvy flight =db.FlightsIvies.Where(x=>x.FlightId==id).SingleOrDefault();
            TempData["flightid"]=id;
            return View(flight);
        }

        [HttpPost]

        public ActionResult Delete(FlightsIvy flight)
        {
            flight.FlightId=Convert.ToInt32(TempData["flightid"]);
            db.FlightsIvies.Remove(flight);
            db.SaveChanges();
            return RedirectToAction("Show");
        }
    }
}