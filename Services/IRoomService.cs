using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IRoomService
    {
        void AddRoom(RoomInformation room);

        void UpdateRoom(RoomInformation room);

        void DeleteRoom(int roomId);

        List<RoomInformation> SearchRoom(string keyword);

        List<RoomInformation> GetAllRooms();
        List<RoomInformation> GetAvailableRooms();

        bool IsRoomUsed(int roomId);
    }
}
