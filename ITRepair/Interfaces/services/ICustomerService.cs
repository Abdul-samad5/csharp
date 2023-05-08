using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITRepair.Dtos;

namespace ITRepair.Interfaces.services
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(string id);
        CustomerDto GetCustomerByName(string name);
        void CreateCustomer(CustomerForCreation customer);
        void UpdateCustomer(CustomerForUpdate customer);
    }
}