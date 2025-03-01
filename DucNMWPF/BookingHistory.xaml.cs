using BusinessObjects;
using DucNMWPF.Model;
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
    /// Interaction logic for BookingHistory.xaml
    /// </summary>
    public partial class BookingHistory : Window
    {
        private readonly int _customerId;
        private readonly BookingService bookingService;
        public BookingHistory( int customerId)
        {
            InitializeComponent();
            bookingService = new BookingService();
            _customerId = customerId;
            LoadHistory();
        }

        private void LoadHistory()
        {
            var bookingHistory = bookingService.GetBookingHistory(_customerId);
            var reports = new List<Report>();
            foreach (var report in bookingHistory)
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
            dgReports.ItemsSource = reports;
        }
    }
}
