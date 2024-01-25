using firstapi.Model;
using Microsoft.EntityFrameworkCore;
//using firstapi.Models;

namespace firstapi.Repository
{

    public class CustRepo : ICustomer<CustomerIvy>
    {
        private readonly Ace52024Context db;
        public CustRepo() { }

        public CustRepo(Ace52024Context _db)
        {
            db = _db;
        }

        public void Create(CustomerIvy customer)
        {
            db.CustomerIvies.Add(customer);
            db.SaveChanges();
        }

        // public void AddEmployee(EmployeeIvy e)
        // {
        //     db.EmployeeIvies.Add(e);
        //     db.SaveChanges();
        // }

        public void Delete(int id)
        {
            CustomerIvy customer = db.CustomerIvies.Find(id);
            db.CustomerIvies.Remove(customer);
            db.SaveChanges();
        }
        public CustomerIvy GetCustById(int id)
        {
            return db.CustomerIvies.Find(id);
        }

        // public EmployeeIvy GetEmpById(int id)
        // {
        //     return  db.EmployeeIvies.Find(id);
        // }



        public async Task<List<CustomerIvy>> CustomIndex()
        {
            return await db.CustomerIvies.ToListAsync();
        }

        public void Edit(int id, CustomerIvy customer)
        {
            db.CustomerIvies.Update(customer);
            db.SaveChanges();

        }

        public void Details(CustomerIvy customer)
        {
            throw new NotImplementedException();
        }
    }
}