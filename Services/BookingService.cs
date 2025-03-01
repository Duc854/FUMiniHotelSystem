using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer;

namespace Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingRepository _bookingRepository;
        public BookingService()
        {
            _bookingRepository = new BookingRepository();
        }
        public void AddBookingReservation(BookingReservation booking) 
        {
            _bookingRepository.AddReservation(booking);
        }
        public void AddBookingDetail(BookingDetail booking)
        {
            _bookingRepository.AddDetail(booking);
        }
        public void DeleteBooking(int id) => _bookingRepository.Delete(id);

        public List<BookingDetail> GetAllBookings() => _bookingRepository.GetAll();
        public List<BookingReservation> GetAllBookingReservation() => _bookingRepository.GetAllReservations();

        public List<BookingDetail> GetBookingById(int id) => _bookingRepository.Search(id);

        public void UpdateBookingReservation(BookingReservation booking) => _bookingRepository.UpdateReservation(booking);
        public void UpdateBookingDetail(BookingDetail booking) => _bookingRepository.UpdateDetail(booking);

        public List<BookingDetail> ViewReport(DateTime? dateStart, DateTime? dateEnd)
        {
            var report = _bookingRepository.GetAll()
                .Where(br =>
                    (dateStart == null || br.BookingReservation.BookingDate >= DateOnly.FromDateTime(dateStart.Value)) &&
                    (dateEnd == null || br.BookingReservation.BookingDate <= DateOnly.FromDateTime(dateEnd.Value))
                ).OrderByDescending(br => br.BookingReservation.BookingDate)
                .ToList();
            return report;
        }

        public List<BookingDetail> GetBookingHistory(int customerId) 
        {
            return _bookingRepository.GetAll().Where(br => br.BookingReservation.CustomerId == customerId).ToList();
        }

        public List<BookingReservation> GetBookingReservations()
        {
            return _bookingRepository.GetBookingReservations();
        }

        public List<BookingReservation> SearchBookingReservations(string keyword)
        {
            return _bookingRepository.SearchBookingReservation(keyword);
        }

        public List<BookingDetail> SearchBookingDetails(string keyword)
        {
            return _bookingRepository.SearchBookingDetail(keyword);
        }
        public void DeleteDetail( BookingDetail booking)
        {
            BookingDetailDAO.Delete(booking.BookingReservationId, booking.RoomId);
        }
    }
}
