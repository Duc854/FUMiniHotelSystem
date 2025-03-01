using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.CreateCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            _customerRepository.DeleteCustomer(customerId);
        }

        public List<Customer> SearchCustomer(string keyword)
        {
            return _customerRepository.SearchCustomerByNameOrEmail(keyword);
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.ShowAllCustomer();
        }
        
        public bool Login(string email, string password)
        {
            var customers = _customerRepository.ShowAllCustomer();
            return customers.Any(c => c.EmailAddress.Equals(email) &&  c.Password.Equals(password));
        }
    }
}
