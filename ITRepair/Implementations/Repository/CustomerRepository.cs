using ITRepair.Entities;
using ITRepair.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRepair.Implementations.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        public void CreateCustomer(Customer customer) => RepositoryContext.Customers.Add(customer);

        public IEnumerable<Customer> GetAllCustomers() => RepositoryContext.Customers.ToList();

        public Customer GetCustomerById(string id) 
            => RepositoryContext.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));

        public Customer GetCustomerByName(string name) 
            => RepositoryContext.Customers.FirstOrDefault(x => x.FirstName.Equals(name));

        public void UpdateCustomer(string id, Customer customer)
        {
            var customerForUpdate = RepositoryContext.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));
            customerForUpdate.FirstName = customer.FirstName;
            customerForUpdate.LastName = customer.LastName;
            customerForUpdate.PhoneNumber = customer.PhoneNumber;
            customerForUpdate.Address = customer.Address;
        }
    }
}
