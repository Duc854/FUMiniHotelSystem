using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoomService : IRoomService
    {
        private readonly RoomRepository _roomRepository;
        private readonly IBookingRepository _bookingRepository;

        public RoomService()
        {
            _roomRepository = new RoomRepository();
            _bookingRepository = new BookingRepository();
        }
        public List<RoomInformation> GetAllRooms()
        {
            return _roomRepository.ShowAllRoomInfor();
        }

        public void AddRoom(RoomInformation room)
        {
            _roomRepository.AddRoom(room);
        }

        public void UpdateRoom(RoomInformation room)
        {
            _roomRepository.UpdateRoom(room);
        }

        public void DeleteRoom(int roomId)
        {
            if (!IsRoomUsed(roomId)){
                _roomRepository.DeleteRoom(roomId);
            }
            else
            {
                var room = _roomRepository.ShowAllRoomInfor().FirstOrDefault(r => r.RoomId == roomId);
                room.RoomStatus = 0;
                _roomRepository.UpdateRoom(room);
            }
            
        }

        public List<RoomInformation> SearchRoom(string keyword)
        {
            return _roomRepository.SearchRoom(keyword);
        }

        public List<RoomInformation> GetAvailableRooms()
        {
            return _roomRepository.ShowAllRoomInfor().Where(r => r.RoomStatus != 0).ToList();
        }

        public bool IsRoomUsed(int roomId)
        {
            var bookedRooms = _bookingRepository.GetAll();
            bool isUsed = bookedRooms.Any(booking => booking.RoomId == roomId);

            return isUsed;
        }
    }
}
