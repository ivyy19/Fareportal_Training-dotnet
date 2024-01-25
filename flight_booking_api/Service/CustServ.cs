using firstapi.Model;
using firstapi.Repository;

namespace firstapi.Service
{

    public class CustServ : ICustServ<CustomerIvy>
    {

        private readonly ICustomer<CustomerIvy> custrepo;
        public CustServ() { }

        public CustServ(ICustomer<CustomerIvy> _custrepo)
        {
            custrepo = _custrepo;
        }
        public void Create(CustomerIvy customer)
        {
            custrepo.Create(customer);
        }

        public void Delete(int id)
        {
            custrepo.Delete(id);
        }

        public async Task<List<CustomerIvy>>CustomIndex()
        {
            return await custrepo.CustomIndex();
        }


        public void Edit(int id, CustomerIvy customer)
        {
            custrepo.Edit(id, customer);
        }
        public void Details(CustomerIvy customer)
        {
            custrepo.Details(customer);
        }


        public CustomerIvy GetCustById(int id)
        {
            return custrepo.GetCustById(id);
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
