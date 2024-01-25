using firstapi.Model;
using firstapi.Repository;

namespace firstapi.Service
{

    public class FlightServ : IFlightServ<FlightsIvy>
    {

        private readonly IFlight<FlightsIvy> flightrepo;
        public FlightServ() { }

        public FlightServ(IFlight<FlightsIvy> _flightrepo)
        {
            flightrepo = _flightrepo;
        }
        public void Add(FlightsIvy flight)
        {
            flightrepo.Add(flight);
        }

        public void Delete(int id)
        {
            flightrepo.Delete(id);
        }

        public async Task<List<FlightsIvy>>Show()
        {
            return await flightrepo.Show();
        }


        public void Edit(int id, FlightsIvy flight)
        {
            flightrepo.Edit(id, flight);
        }
        public void Details(FlightsIvy flight)
        {
            flightrepo.Details(flight);
        }


        public FlightsIvy GetFliById(int id)
        {
            return flightrepo.GetFliById(id);
        }

        //    public  Task ICustServ<CustomerIvy>GetCustById(int id)
        //     {
        //         throw new NotImplementedException();
        //     }
    }

    // public interface ICustServ<T>
    // {
    //     Task GetCustById(int id);
    // }
}
