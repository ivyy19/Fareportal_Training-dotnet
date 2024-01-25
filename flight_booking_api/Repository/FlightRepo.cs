using firstapi.Model;
using Microsoft.EntityFrameworkCore;
//using firstapi.Models;

namespace firstapi.Repository
{

    public class FlightRepo : IFlight<FlightsIvy>
    {
        private readonly Ace52024Context db;
        public FlightRepo() { }

        public FlightRepo(Ace52024Context _db)
        {
            db = _db;
        }

        public void Add(FlightsIvy flight)
        {
            db.FlightsIvies.Add(flight);
            db.SaveChanges();
        }

        // public void AddEmployee(EmployeeIvy e)
        // {
        //     db.EmployeeIvies.Add(e);
        //     db.SaveChanges();
        // }

        public void Delete(int id)
        {
            FlightsIvy flight = db.FlightsIvies.Find(id);
            db.FlightsIvies.Remove(flight);
            db.SaveChanges();
        }
        public FlightsIvy GetFliById(int id)
        {
            return db.FlightsIvies.Find(id);
        }

        // public EmployeeIvy GetEmpById(int id)
        // {
        //     return  db.EmployeeIvies.Find(id);
        // }



        public async Task<List<FlightsIvy>> Show()
        {
            return await db.FlightsIvies.ToListAsync();
        }

        public void Edit(int id, FlightsIvy flight)
        {
            db.FlightsIvies.Update(flight);
            db.SaveChanges();

        }

        public void Details(FlightsIvy flight)
        {
            throw new NotImplementedException();
        }
    }
}