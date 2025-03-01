using Microsoft.Data.SqlClient;
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
using BusinessObjects;
using Services;
using Microsoft.IdentityModel.Tokens;

namespace DucNMWPF
{
    /// <summary>
    /// Interaction logic for BookingManagementView.xaml
    /// </summary>
    public partial class BookingManagementView : Window
    {
        private readonly BookingService _bookingService;
        public BookingManagementView()
        {
            InitializeComponent();
            _bookingService = new BookingService();
            LoadBookings();
        }

        private void LoadBookings()
        {
            var bookings = _bookingService.GetAllBookingReservation();
            dgBookings.ItemsSource = bookings;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtered = _bookingService.SearchBookingReservations(txtSearchKeyword.Text.ToLower());
            if (filtered.IsNullOrEmpty()) MessageBox.Show("Không tìm thấy kết quả phù hợp!!!");
            dgBookings.ItemsSource = filtered;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int maxId = _bookingService.GetBookingReservations().Max(b => (int?)b.BookingReservationId) ?? 0;
            BookingReservation newBookingReservation = new BookingReservation()
            {
                BookingReservationId = maxId + 1,
                CustomerId = 0,
                TotalPrice = 0,
                BookingDate = DateOnly.FromDateTime(DateTime.Now),
                BookingStatus = 0
            };
            BookingReservationView bookingReservationView = new BookingReservationView(newBookingReservation, newBookingReservation.BookingReservationId);
            bool? result = bookingReservationView.ShowDialog();
            if (result == true)
            {
                _bookingService.AddBookingReservation(bookingReservationView.BookingReservation);
                MessageBox.Show($"Thêm lệnh đặt phòng thành công, vui lòng thêm chi tiết", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Thêm lệnh đặt phòng thất bại!! \n Vui lòng kiểm tra lại thông tin! ", "Lỗi");
            }
            LoadBookings();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgBookings.SelectedItem is BookingReservation selectedBooking)
            {
                BookingReservationView detailWindow = new BookingReservationView(selectedBooking, selectedBooking.BookingReservationId);
                if (detailWindow.ShowDialog() == true)
                {
                    _bookingService.UpdateBookingReservation(detailWindow.BookingReservation);
                    MessageBox.Show($"Cập nhật thông tin lệnh đặt phòng {detailWindow.BookingReservation.BookingReservationId} thành công", "Thông báo");
                    LoadBookings();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgBookings.SelectedItem is BookingReservation selectedBooking)
            {
                    _bookingService.DeleteBooking(selectedBooking.BookingReservationId);
                    MessageBox.Show($"Xóa thông tin lệnh đặt phòng {selectedBooking.BookingReservationId} thành công", "Thông báo");
                    LoadBookings();
            }
        }
        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgBookings.SelectedItem is BookingReservation selectedBooking)
            {
                BookingDetailManagement booking = new BookingDetailManagement(selectedBooking.BookingReservationId);
                booking.Show();
                LoadBookings();
            }

        }
    }
}
