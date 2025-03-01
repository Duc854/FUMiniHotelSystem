using Microsoft.EntityFrameworkCore;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DucNMWPF.Model;
using Microsoft.IdentityModel.Tokens;

namespace DucNMWPF
{
    /// <summary>
    /// Interaction logic for AdminDashBoard.xaml
    /// </summary>
    public partial class AdminDashBoard : Window
    {
        private readonly BookingService bookingService;
        public AdminDashBoard()
        {
            InitializeComponent();
            bookingService = new BookingService();
        }
        private void ActionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstActions.SelectedItem is ListBoxItem selectedItem)
            {
                string action = selectedItem.Content.ToString();
                if (action == "Quản lý người dùng")
                {
                    CustomerManagement customerManagement = new CustomerManagement();
                    customerManagement.Show();
                }
                if (action == "Quản lý phòng")
                {
                    RoomManagementView roomManagementView = new RoomManagementView();
                    roomManagementView.Show();
                }
                if (action == "Quản lý đặt phòng")
                {
                    BookingManagementView bookingManagementView = new BookingManagementView();
                    bookingManagementView.Show();
                }
            }
        }

        private void FilterReports_Click(object sender, RoutedEventArgs e)
        {
            DateTime? startDate = dpStartDate.SelectedDate;
            DateTime? endDate = dpEndDate.SelectedDate;

            if (startDate == null || endDate == null)
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian hợp lệ!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var bookingDetail = bookingService.ViewReport(startDate, endDate);
            var reports = new List<Report>();
            foreach (var report in bookingDetail)
            {
                reports.Add(new Report(
                    report.BookingReservationId, 
                    report.BookingReservation.CustomerId,
                    report.BookingReservation.Customer.CustomerFullName,
                    report.Room.RoomNumber,
                    report.BookingReservation.BookingDate,
                    report.StartDate,
                    report.EndDate,
                    report.BookingReservation.TotalPrice

                    ));
            }
            if (reports.IsNullOrEmpty()) MessageBox.Show("Không tìm thấy kết quả phù hợp!!!");
            dgReports.ItemsSource = reports;
        }

    }
}
