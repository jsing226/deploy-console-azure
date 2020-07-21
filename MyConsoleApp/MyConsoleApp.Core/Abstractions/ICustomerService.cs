using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsoleApp.Core.Models;

namespace MyConsoleApp.Core.Abstractions
{
    public interface ICustomerService
    {
        Customer GetById(int customerId);
        List<Customer> GetAll();
    }
}
