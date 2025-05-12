using Buisness.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new();

        public void AddCustomer(CustomerModel model)
        {
            var customer = new Customer
            {
                Id = _customers.Count + 1,
                FullName = model.FullName,
                Email = model.Email
            };
            _customers.Add(customer);
        }

        public IEnumerable<Customer> GetAllCustomers() => _customers;
    }
}
