using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucNMWPF.Model
{
    public class Report
    {
        public int BookingReservationId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string RoomNumber { get; set; }
        public DateOnly? BookingDate { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal? TotalPrice { get; set; }

        public Report(int bookingReservationId, int customerId, string customerName, string roomNumber, DateOnly? bookingDate, DateOnly startDate, DateOnly endDate, decimal? totalPrice)
        {
            StartDate = startDate;
            EndDate = endDate;
            BookingReservationId = bookingReservationId;
            CustomerId = customerId;
            CustomerName = customerName;
            RoomNumber = roomNumber;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
        }
    }
}
