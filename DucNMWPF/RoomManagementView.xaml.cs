using BusinessObjects;
using Microsoft.IdentityModel.Tokens;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for RoomManagementView.xaml
    /// </summary>
    public partial class RoomManagementView : Window
    {
        private readonly RoomService roomService;
        public List<RoomInformation> Rooms { get; set; } = new List<RoomInformation>();

        public RoomManagementView()
        {
            InitializeComponent();
            roomService = new RoomService();
            LoadRooms();
        }

        private void LoadRooms()
        {
            Rooms = roomService.GetAllRooms();
            dgRooms.ItemsSource = Rooms;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearchKeyword.Text.ToLower();
            var filtered = roomService.SearchRoom(keyword);
            if (filtered.IsNullOrEmpty()) MessageBox.Show("Không tìm thấy kết quả phù hợp");
            dgRooms.ItemsSource = filtered;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            RoomInformation newRoom = new RoomInformation
            {
                RoomNumber = "", 
                RoomDetailDescription = "",
                RoomMaxCapacity = 0,  
                RoomTypeId = 0,     
                RoomStatus = 1,
                RoomPricePerDay = 0   
            };  
            RoomDetailWindow detailWindow = new RoomDetailWindow(newRoom);
            if (detailWindow.ShowDialog() == true)
            {
                roomService.AddRoom(detailWindow.Room);
                LoadRooms();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgRooms.SelectedItem is RoomInformation selectedRoom)
            {
                RoomDetailWindow detailWindow = new RoomDetailWindow(selectedRoom);
                if (detailWindow.ShowDialog() == true)
                {

                    roomService.UpdateRoom(detailWindow.Room);
                    MessageBox.Show($"Update thông tin phòng {detailWindow.Room.RoomNumber} thành công!");
                    LoadRooms();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            if (dgRooms.SelectedItem is RoomInformation selectedRoom)
            {

                MessageBoxResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng {selectedRoom.RoomNumber} không?",
                "Xác nhận xóa",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    roomService.DeleteRoom(selectedRoom.RoomId);
                    LoadRooms();
                }
            }
        }
    }
}
