using MyConsoleApp.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsoleApp.Core.Models;

namespace MyConsoleApp.External.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customers;
        public CustomerService()
        {
            _customers = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                _customers.Add(new Customer { ID = i + 1, Name = "Test" + (i + 1) });
            }
        }
        public List<Customer> GetAll()
        {
            return _customers;            
        }

        public Customer GetById(int customerId)
        {
            return _customers.FirstOrDefault(c => c.ID == customerId);
        }
    }
}
