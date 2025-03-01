using BusinessObjects;
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

namespace DucNMWPF
{
    /// <summary>
    /// Interaction logic for BookingReservationView.xaml
    /// </summary>
    public partial class BookingReservationView : Window
    {
        public BookingReservation BookingReservation { get; set; }
        private int _nextBookingReservationId;
        public BookingReservationView(BookingReservation bookingReservation, int nextBookingReservationId)
        {
            InitializeComponent();
            this.BookingReservation = bookingReservation ?? new BookingReservation();
            _nextBookingReservationId = nextBookingReservationId;
            LoadBookingReservationData();
        }
        private void LoadBookingReservationData()
        {

            txtCustomerID.Text = BookingReservation.CustomerId.ToString();
            txtTotalPrice.Text = BookingReservation.TotalPrice.ToString();
            dpBookingDate.SelectedDate = BookingReservation.BookingDate.Value.ToDateTime(TimeOnly.MinValue);
            if (cbStatus.SelectedValue != null)
            {
                BookingReservation.BookingStatus = Convert.ToByte(cbStatus.SelectedValue);
            }
            else
            {
                BookingReservation.BookingStatus = 0;
            }
        }
        private void SaveBooking_Click(object sender, RoutedEventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Mã khách hàng phải là số!", "Lỗi");
                return;
            }

            decimal totalPrice;
            if (!decimal.TryParse(txtTotalPrice.Text, out totalPrice))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi");
                return;
            }

            DateOnly bookingDate = DateOnly.MinValue;
            if (!dpBookingDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Vui lòng chọn ngày đặt phòng!!!", "Lỗi");
                return;
            }
            else
            {
                bookingDate = DateOnly.FromDateTime(dpBookingDate.SelectedDate.Value);
            }
            byte status = 0;
            if (cbStatus.SelectedItem is ComboBoxItem selectedItem)
            {
                status = byte.Parse(selectedItem.Tag.ToString());
            }
            BookingReservation = new BookingReservation()
            {
                BookingReservationId = _nextBookingReservationId,
                CustomerId = customerId,
                TotalPrice = totalPrice,
                BookingDate = bookingDate,
                BookingStatus = status
            };
            this.DialogResult = true;
            this.Close();
        }


        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}