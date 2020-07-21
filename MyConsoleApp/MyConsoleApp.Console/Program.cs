using MyConsoleApp.Core.Abstractions;
using MyConsoleApp.Core.Models;
using MyConsoleApp.External.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a customer id: ");
            int customerId = 0;
            ICustomerService service = new CustomerService();

            if (int.TryParse(System.Console.ReadLine(), out customerId))
            {
                Customer customer = service.GetById(customerId);
                System.Console.WriteLine($"Showing customer details: Customer ID = {customer.ID}, Customer Name: {customer.Name}" );
            }
            else
            {
                System.Console.WriteLine("Invalid argument. The customer id should be between 1-10. Exiting...");
            }
        }
    }
}
