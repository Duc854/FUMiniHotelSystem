using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DucNMWPF
{
    public partial class CustomerDetailWindow : Window
    {
        public Customer Customer { get; private set; }
        public CustomerDetailWindow(Customer customer)
        {
            InitializeComponent();
            Customer = customer ?? new Customer();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            FullNameTextBox.Text = Customer.CustomerFullName;
            EmailTextBox.Text = Customer.EmailAddress;
            TelephoneTextBox.Text = Customer.Telephone;
            BirthdayPicker.SelectedDate = Customer.CustomerBirthday.Value.ToDateTime(TimeOnly.MinValue);
            PasswordBox.Password = Customer.Password;
            if (StatusComboBox.SelectedValue != null)
            {
                Customer.CustomerStatus = Convert.ToByte(StatusComboBox.SelectedValue);
            }
            else
            {
                Customer.CustomerStatus = 1;
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Customer.CustomerFullName = FullNameTextBox.Text;
            Customer.EmailAddress = EmailTextBox.Text;
            Customer.Telephone = TelephoneTextBox.Text;
            Customer.CustomerBirthday = DateOnly.FromDateTime(BirthdayPicker.SelectedDate.Value);
            Customer.Password = PasswordBox.Password;
            if (StatusComboBox.SelectedItem is ComboBoxItem selectedItem && selectedItem.Tag is string tagValue)
            {
                if (byte.TryParse(tagValue, out byte status))
                {
                    Customer.CustomerStatus = status;
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể chuyển đổi trạng thái!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            DialogResult = true;
            Close();
        }
    }
}
