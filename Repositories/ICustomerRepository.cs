using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        List<Customer> SearchCustomerByNameOrEmail(string keyword);
        List<Customer> ShowAllCustomer();
        Customer GetCustomerById(int customerId);
    }
}
