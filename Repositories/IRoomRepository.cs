using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRoomRepository
    {
        void AddRoom(RoomInformation room);
        void UpdateRoom(RoomInformation room);
        void DeleteRoom(int roomId);
        List<RoomInformation> SearchRoom(string keyword);
        List<RoomInformation> ShowAllRoomInfor();
    }
}
