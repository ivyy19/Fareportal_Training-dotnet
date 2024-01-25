

using firstapi.Model;

namespace firstapi.Service
{

    public interface IFlightServ<FlightsIvy>
    {
        Task<List<FlightsIvy>> Show();
        void Add(FlightsIvy flight);
        void Edit(int id, FlightsIvy flight);
        void Details(FlightsIvy flight);
        FlightsIvy GetFliById(int id);
        void Delete(int id);

    }
    }