using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookingService
    {
        List<BookingDetail> GetAllBookings();
        List<BookingReservation> GetAllBookingReservation();
        List<BookingDetail> GetBookingById(int id);
        void AddBookingReservation(BookingReservation booking);
        void AddBookingDetail(BookingDetail booking);
        void UpdateBookingReservation(BookingReservation booking);
        void UpdateBookingDetail(BookingDetail bookingDetail);
        void DeleteBooking(int id);
        List<BookingReservation> SearchBookingReservations(string keyword);
        List<BookingDetail> SearchBookingDetails(string keyword);
        List<BookingDetail> ViewReport(DateTime? dateStart, DateTime? dateEnd);

        List<BookingReservation> GetBookingReservations();
    }
}
