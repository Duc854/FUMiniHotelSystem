using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Repositories
{
    public interface IBookingRepository
    {

     List<BookingDetail> GetAll();
     List<BookingReservation> GetAllReservations();

    public void AddReservation(BookingReservation booking);
    public void AddDetail(BookingDetail booking);
    void UpdateReservation(BookingReservation booking);

     void UpdateDetail(BookingDetail booking);

     void Delete(int bookingReservationId);

     List<BookingDetail> Search(int customerId);

     List<BookingReservation> GetBookingReservations();
     List<BookingReservation> SearchBookingReservation(string keyword);
     List<BookingDetail> SearchBookingDetail(string keyword);
    }
}
