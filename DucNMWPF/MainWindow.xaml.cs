using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using Services;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DucNMWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CustomerService customerService;
        public MainWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var adminEmail = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["AdminAccount:Email"];
            var adminPassword = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["AdminAccount:Password"];
            if (email == adminEmail && password == adminPassword)
            {
                MessageBox.Show("Đăng nhập thành công (Admin)!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                AdminDashBoard adminDashBoard = new AdminDashBoard();
                adminDashBoard.Show();
                this.Close();
                return;
            }
            if(customerService.Login(email, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                HomePage homePage = new HomePage();
                homePage.Show();
                int userId = customerService.GetAllCustomers().FirstOrDefault(c => c.EmailAddress.Equals(email) && c.Password.Equals(password)).CustomerId;
                Application.Current.Properties["UserID"] = userId;
                this.Close();
                return;
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}