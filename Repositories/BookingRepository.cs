using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public void AddReservation(BookingReservation booking) 
        {
            BookingReservationDAO.Save(booking);
        }
        public void AddDetail(BookingDetail booking)
        {
            BookingDetailDAO.Save(booking);
        } 
        public void Delete(int bookingReservationId) => BookingReservationDAO.Delete(bookingReservationId);

        public List<BookingDetail> GetAll() => BookingDetailDAO.Get();

        public List<BookingReservation> GetAllReservations() => BookingReservationDAO.Get();
        public List<BookingDetail> Search(int customerId) => BookingDetailDAO.Search(customerId);

        public void UpdateReservation(BookingReservation booking)
        { 
            BookingReservationDAO.Update(booking);
        }
        public void UpdateDetail(BookingDetail booking)
        {
            BookingDetailDAO.Update(booking);
        }

        public List<BookingReservation> GetBookingReservations() => BookingReservationDAO.Get();

        public List<BookingReservation> SearchBookingReservation(string keyword)
        {
            return BookingReservationDAO.Get().Where(br => br.BookingReservationId.ToString() == keyword.ToLower()
                                                    || br.CustomerId.ToString() == keyword.ToLower()).ToList();
        }

        public List<BookingDetail> SearchBookingDetail(string keyword)
        {
            return BookingDetailDAO.Get().Where(bd => bd.BookingReservationId.ToString() == keyword.ToLower()).ToList();
        }
    }
}
