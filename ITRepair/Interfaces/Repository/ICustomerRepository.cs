using ITRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepair.Interfaces.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(string id);
        Customer GetCustomerByName(string name);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(string id, Customer customer);
    }
}