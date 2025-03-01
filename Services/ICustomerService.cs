using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(int customerId);

        List<Customer> SearchCustomer(string keyword);

        List<Customer> GetAllCustomers();

        bool Login(string email, string password);
        Customer GetCustomerById(int customerId);
    }
}
