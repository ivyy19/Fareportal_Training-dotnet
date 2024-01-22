using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using flightmvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class BookingController : Controller
{
    private readonly Ace52024Context db;

    public BookingController(Ace52024Context _db)
    {
        db = _db;
    }

    // GET: Booking
    public IActionResult BookIndex()
    {
        var bookings = db.BookingIvies.Include(x=>x.Flight).Include(x=>x.Customer).ToList();
        // return View(bookings);
        
        return View(bookings);
    }

    // GET: Booking/Details/5
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("BookIndex");
        }

        //var booking = db.BookingIvies.SingleOrDefault(x => x.BookingId == id);

       var booking=db.BookingIvies.Include(x=>x.Flight).Include(x=>x.Customer).SingleOrDefault(x=>x.BookingId==id);
        if (booking == null)
        {
            return RedirectToAction("BookIndex");
        }
        ViewBag.AutoGeneratedFlightId=$"{booking.Source}-{booking.Destination}";

        return View(booking);
    }

    // GET: Booking/Create
    public IActionResult Create()
    {
        ViewBag.Sources = new SelectList(db.FlightsIvies.Select(f => f.Source).Distinct().ToList());
        ViewBag.Destinations = new SelectList(db.FlightsIvies.Select(f => f.Destination).Distinct().ToList());

        ViewBag.Customer=new SelectList(db.CustomerIvies.Select(f=>f.CustomerId));
       
       
        return View();
    }

    [HttpPost]
  
    public IActionResult Create(BookingIvy booking)
    {
        if (ModelState.IsValid)
        {
           
            
                bool validFlight=db.FlightsIvies.Any(x=>x.Source==booking.Source &x.Destination==booking.Destination);

                if(!validFlight)
                {
                    ModelState.AddModelError(string.Empty,"No valid flight exist for the selected source and destination");
                    return View(booking);
                }
                booking.FlightId=GenerateFlightId(booking.Source,booking.Destination);
                booking.TotalCost=TotalCost(booking.FlightId,booking.NoOfPassengers);
                booking.BookingDate=DateTime.Now;
                
                db.BookingIvies.Add(booking);
                db.SaveChanges();

                return RedirectToAction("Details",new{id=booking.BookingId});
            
        }

      
        ViewBag.Sources = db.FlightsIvies.Select(f => f.Source).Distinct().ToList();
        ViewBag.Destinations = db.FlightsIvies.Select(f => f.Destination).Distinct().ToList();

        return View(booking);
    }

    private int GenerateFlightId(string source ,string destinations)
    {
        int flightId=db.FlightsIvies.Where(x=>x.Source==source && x.Destination==destinations).Select(x=>x.FlightId).SingleOrDefault();
        if(flightId<=0)
        {
            return 0;
        }
        return flightId;
    }

    private decimal TotalCost(int? flightId, int? NoOfPassengers)
    {
        if(!flightId.HasValue|| flightId.Value<=0||!NoOfPassengers.HasValue|| NoOfPassengers.Value<=0)

        {
            return 0.00M;
        }
        decimal? rate=db.FlightsIvies.Where(x=>x.FlightId==flightId).Select(x=>x.Rate).SingleOrDefault();

        if(!rate.HasValue||rate.Value<=0)
        {
            return 0.00M;
        }
        return rate.Value* NoOfPassengers.Value;
    }

    // GET: Booking/Edit/5
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("BookIndex");
        }

        var booking = db.BookingIvies.SingleOrDefault(b => b.BookingId == id);

        if (booking == null)
        {
            return RedirectToAction("BookIndex");
        }

         ViewBag.Customer=new SelectList(db.CustomerIvies);
        ViewBag.Source = db.FlightsIvies.Select(f => f.Source).Distinct().ToList();
        ViewBag.Destination = db.FlightsIvies.Select(f => f.Destination).Distinct().ToList();

        return View(booking);
    }

    // POST: Booking/Edit/5
    [HttpPost]
  
    public IActionResult Edit(int id, BookingIvy booking)
    {
        if (id != booking.BookingId)
        {
            return RedirectToAction("BookIndex");
        }

        if (ModelState.IsValid)

        {

            ViewBag.Customer=new SelectList(db.CustomerIvies);
            ViewBag.Source=new SelectList(db.FlightsIvies.Select(x=>x.Source).Distinct());
            ViewBag.Destination=new SelectList(db.FlightsIvies.Select(x=>x.Destination).Distinct());
            var existingBooking=db.BookingIvies.Find(booking.BookingId);

           if(existingBooking!=null)
           {
            existingBooking.BookingDate=DateTime.Now;
            existingBooking.Source=booking.Source;
            existingBooking.Destination=booking.Destination;
            existingBooking.NoOfPassengers=booking.NoOfPassengers;
            existingBooking.CustomerId=booking.CustomerId;
            int flightId=existingBooking.FlightId??0;
            existingBooking.TotalCost=CalculateTotalCost(flightId,existingBooking.NoOfPassengers);
            // Update logic here
            //db.BookingIvies.Update(booking);
            db.SaveChanges();
            return RedirectToAction("BookIndex");
            }
        else{
            return RedirectToAction("BookIndex");
        }
        }

        ViewBag.Customer=new SelectList(db.CustomerIvies);
        ViewBag.Source = new SelectList(db.FlightsIvies.Select(f => f.Source).Distinct().ToList());
        ViewBag.Destination =new SelectList( db.FlightsIvies.Select(f => f.Destination).Distinct().ToList());

        return View(booking);
    }
private decimal CalculateTotalCost(int flightId,int NoOfPassengers)
{
    var flight=db.FlightsIvies.Find(flightId);
    if(flight!=null)
    {
        return flight.Rate*NoOfPassengers;
    }
    return 0;
}
    // GET: Booking/Delete/5
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("BookIndex");
        }

        var booking = db.BookingIvies.SingleOrDefault(b => b.BookingId == id);

        if (booking == null)
        {
            return RedirectToAction("BookIndex");
        }

        return View(booking);
    }

    // POST: Booking/Delete/5
    [HttpPost, ActionName("Delete")]
   
    public IActionResult Delete(int id)
    {
        var booking = db.BookingIvies.SingleOrDefault(b => b.BookingId == id);

        if (booking != null)
        {
            db.BookingIvies.Remove(booking);
            db.SaveChanges();
        }

        return RedirectToAction("BookIndex");
    }
}