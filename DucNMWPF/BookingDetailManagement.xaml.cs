using BusinessObjects;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for BookingDetailManagement.xaml
    /// </summary>
    public partial class BookingDetailManagement : Window
    {
        private BookingService _bookingService = new BookingService();
        public int BookingReservationId { get; set; }

        public BookingDetailManagement(int bookingReservationId)
        {
            InitializeComponent();
            BookingReservationId = bookingReservationId;
            LoadBookings();
        }

        private void LoadBookings()
        {
            dgBookingDetails.ItemsSource = _bookingService.GetAllBookings().Where(bk=>bk.BookingReservationId == BookingReservationId) ?? new List<BookingDetail>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            BookingDetail newBookingDetail = new BookingDetail()
            {
                BookingReservationId = BookingReservationId,
                RoomId = 0,
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now),
                ActualPrice = 0
            };
            BookingDetailView bookingDetailView = new BookingDetailView(BookingReservationId, newBookingDetail);
            bool? result = bookingDetailView.ShowDialog();
            if (result == true)
            {
                _bookingService.AddBookingDetail(newBookingDetail);
                MessageBox.Show($"Thêm chhi tiết đặt phòng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Thêm chi tiết đặt phòng thất bại!! \n Vui lòng kiểm tra lại thông tin! ", "Lỗi");
            }
            LoadBookings();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgBookingDetails.SelectedItem is BookingDetail selectedBooking)
            {
                BookingDetailView detailWindow = new BookingDetailView(selectedBooking.BookingReservationId, selectedBooking );
                if (detailWindow.ShowDialog() == true)
                {
                    _bookingService.UpdateBookingDetail(detailWindow.BookingDetail);
                    MessageBox.Show($"Cập nhật thông tin chi tiết đặt phòng {detailWindow.BookingDetail.BookingReservationId} thành công", "Thông báo");
                    LoadBookings();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgBookingDetails.SelectedItem is BookingDetail selectedBooking)
            {
                _bookingService.DeleteDetail(selectedBooking);
                MessageBox.Show($"Xóa thông tin chi tiết đặt phòng {selectedBooking.BookingReservationId} thành công", "Thông báo");
                LoadBookings();
            }
        }
        
    }
}
