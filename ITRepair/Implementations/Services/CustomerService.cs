using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITRepair.Dtos;
using ITRepair.Interfaces.Repository;
using ITRepair.Interfaces.services;

namespace ITRepair.Implementations.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public void CreateCustomer(CustomerForCreation customer) =>
            _customerRepository.CreateCustomer(new Entities.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber
            });


        public IEnumerable<CustomerDto> GetAllCustomers() =>
            _customerRepository.GetAllCustomers().Select(x => new CustomerDto
            {
                CustomerId = x.CustomerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber
            });

        public CustomerDto GetCustomerById(string id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            return new CustomerDto
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public CustomerDto GetCustomerByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerForUpdate customer) =>
            _customerRepository.UpdateCustomer(customer.CustomerId, new Entities.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber
            });
    }
}