using System.Windows;
using BusinessObjects;
using Microsoft.IdentityModel.Tokens;
using Services;

namespace DucNMWPF
{
    public partial class CustomerManagement : Window
    {
        private readonly CustomerService customerService;
        private List<Customer> Customers;

        public CustomerManagement()
        {
            InitializeComponent();
            customerService = new CustomerService();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            Customers = customerService.GetAllCustomers();
            CustomerDataGrid.ItemsSource = Customers;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text.ToLower();
            var filtered = customerService.SearchCustomer(keyword);
            if (filtered.IsNullOrEmpty()) MessageBox.Show("Không tìm thấy kết quả phù hợp!!!");
            CustomerDataGrid.ItemsSource = filtered;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Customer newCustomer = new Customer
            {
                CustomerFullName = "",
                EmailAddress = "",
                Telephone = "",
                CustomerBirthday = DateOnly.FromDateTime(DateTime.Today),
                CustomerStatus = 1
            };
            CustomerDetailWindow detailWindow = new CustomerDetailWindow(newCustomer);
            if (detailWindow.ShowDialog() == true)
            {
                customerService.AddCustomer(detailWindow.Customer);
                MessageBox.Show($"Tạo khách hàng{detailWindow.Customer.CustomerFullName} thành công");
                LoadCustomers();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                CustomerDetailWindow detailWindow = new CustomerDetailWindow(selectedCustomer);
                if (detailWindow.ShowDialog() == true)
                {
                    customerService.UpdateCustomer(detailWindow.Customer);
                    MessageBox.Show($"Update thông tin khách hàng {detailWindow.Customer.CustomerFullName} thành công");
                    LoadCustomers();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer customer)
            {
                MessageBoxResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa khách hàng {customer.CustomerFullName} không?",
                "Xác nhận xóa",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    customerService.DeleteCustomer(customer.CustomerId);
                    LoadCustomers();
                }
            }
        }
    }
}
