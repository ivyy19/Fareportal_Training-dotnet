using firstapi.Model;

namespace firstapi.Service
{

    public interface ICustServ<CustomerIvy>
    {
        Task<List<CustomerIvy>> CustomIndex();
        void Create(CustomerIvy customer);
        void Edit(int id, CustomerIvy customer);
        void Details(CustomerIvy customer);
        CustomerIvy GetCustById(int id);
        void Delete(int id);

    }
    }