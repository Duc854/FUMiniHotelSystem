using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public void AddRoom(RoomInformation room) => RoomInformationDAO.Save(room);

        public void DeleteRoom(int roomId) => RoomInformationDAO.Delete(roomId);

        public List<RoomInformation> SearchRoom(string keyword)
        {
            try
            {
                return RoomInformationDAO.Get().Where(r => r.RoomNumber.Contains(keyword)
                || r.RoomPricePerDay.ToString().Contains(keyword)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<RoomInformation>();
            }
        }

        public List<RoomInformation> ShowAllRoomInfor() => RoomInformationDAO.Get();

        public void UpdateRoom(RoomInformation room) => RoomInformationDAO.Update(room);
    }
}
