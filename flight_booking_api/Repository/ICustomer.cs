using firstapi.Model;
namespace firstapi.Repository
{
    public interface ICustomer<CustomerIvy>
    {
        Task<List<CustomerIvy>> CustomIndex();
        void Create(CustomerIvy customer);
        void Edit(int id, CustomerIvy customer);
        void Details(CustomerIvy customer);
        CustomerIvy GetCustById(int id);
        void Delete(int id);

    }
}