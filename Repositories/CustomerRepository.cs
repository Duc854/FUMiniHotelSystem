using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void CreateCustomer(Customer customer) => CustomerDAO.Save(customer);

        public void DeleteCustomer(int customerId) => CustomerDAO.Delete(customerId);

        public List<Customer> SearchCustomerByNameOrEmail(string keyword) => CustomerDAO.Search(keyword);

        public List<Customer> ShowAllCustomer() => CustomerDAO.Get();

        public void UpdateCustomer(Customer customer) => CustomerDAO.Update(customer);

        public Customer GetCustomerById(int customerId) => CustomerDAO.GetCustomerbyId(customerId);
    }
}
