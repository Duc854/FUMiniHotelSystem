using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using Services;
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
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        private readonly RoomService roomService;
        private readonly CustomerService customerService;
        public HomePage()
        {
            InitializeComponent();
            roomService = new RoomService();
            customerService = new CustomerService();
            LoadRooms();
        }

        private void LoadRooms()
        {
            dgRoomList.ItemsSource = roomService.GetAvailableRooms();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var searchResult = roomService.SearchRoom(keyword);
            if (searchResult.IsNullOrEmpty()) MessageBox.Show("Không tìm thấy kết quả phù hợp!!!");
            dgSearchResults.ItemsSource = searchResult;
        }

        private void EditProfile_Click(object sender, RoutedEventArgs e)
        {
            var currentCustomer = customerService.GetCustomerById((int) Application.Current.Properties["UserID"]);
            CustomerDetailWindow customerDetail = new CustomerDetailWindow(currentCustomer);
            if (customerDetail.ShowDialog() == true)
            {
                customerService.UpdateCustomer(customerDetail.Customer);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadRooms();
                return;
            }
            MessageBox.Show("Thay đổi chưa được lưu!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadRooms();
        }

        private void BookedHistory_Click(object sender, RoutedEventArgs e)
        {
            BookingHistory bookingHistory = new BookingHistory((int)Application.Current.Properties["UserID"]);
            bookingHistory.ShowDialog();
            LoadRooms();
        }

        private void BookRoom_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
