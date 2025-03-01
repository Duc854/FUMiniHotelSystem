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

namespace DucNMWPF
{
        public partial class BookingDetailView : Window
        {
            private RoomService roomService;
            public List<RoomInformation> AvailableRooms { get; set; }
            public BookingDetail BookingDetail { get; set; }
            private int reservationId;
            public BookingDetailView(int reservationId, BookingDetail bookingDetail)
            {
                InitializeComponent();
                roomService = new RoomService();
                AvailableRooms = roomService.GetAvailableRooms();
                this.reservationId = reservationId;
                BookingDetail = bookingDetail;
                LoadBookingDetail();
                LoadAvailableRooms();
            }
            private void LoadBookingDetail()
            {
                txtBookingID.Text = txtBookingID.Text = BookingDetail?.BookingReservation?.BookingReservationId.ToString() ?? "";
                dpStartDate.SelectedDate = BookingDetail.StartDate.ToDateTime(TimeOnly.MinValue);
                dpEndDate.SelectedDate = BookingDetail.EndDate.ToDateTime(TimeOnly.MinValue);
                var selectedRoom = AvailableRooms.FirstOrDefault(r => r.RoomId == BookingDetail.RoomId);
                if (selectedRoom != null)
                {
                    dgAvailableRooms.SelectedItem = selectedRoom;
                }
            }
            private void LoadAvailableRooms()
        {
            dgAvailableRooms.ItemsSource = AvailableRooms;
        }

        private void SaveBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingDetail.BookingReservationId = reservationId;
            if(dgAvailableRooms.SelectedItem is RoomInformation room)
            {
                BookingDetail.RoomId = room.RoomId;
                BookingDetail.ActualPrice = room.RoomPricePerDay;
            }
            if (dpStartDate.SelectedDate.HasValue && dpEndDate.SelectedDate.HasValue)
            {
                DateOnly startDate = DateOnly.FromDateTime(dpStartDate.SelectedDate.Value);
                DateOnly endDate = DateOnly.FromDateTime(dpEndDate.SelectedDate.Value);
                if (startDate >= endDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Lỗi");
                    return;
                }
                if (dgAvailableRooms.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một phòng!", "Lỗi");
                    return;
                }
                BookingDetail.StartDate = startDate;
                BookingDetail.EndDate = endDate;
                MessageBox.Show("Thành công!", "Thông báo");
                this.DialogResult = true;
                this.Close();
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

