using System;
using System.Collections.Generic;
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
using BusinessObjects;

namespace DucNMWPF
{
    public partial class RoomDetailWindow : Window
    {
        public RoomInformation Room { get; set; }

        public RoomDetailWindow(RoomInformation room)
        {
            InitializeComponent();
            this.Room = room;
            txtRoomNumber.Text = room.RoomNumber;
            txtRoomDescription.Text = room.RoomDetailDescription;
            txtRoomMaxCapacity.Text = room.RoomMaxCapacity.ToString();
            txtRoomTypeID.Text = room.RoomTypeId.ToString();

            foreach (ComboBoxItem item in cmbRoomStatus.Items)
            {
                if (item.Tag != null && item.Tag.ToString() == room.RoomStatus.ToString())
                {
                    cmbRoomStatus.SelectedItem = item;
                    break;
                }
            }

            txtRoomPricePerDay.Text = room.RoomPricePerDay.ToString();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Room.RoomNumber = txtRoomNumber.Text;
            Room.RoomDetailDescription = txtRoomDescription.Text;

            if (int.TryParse(txtRoomMaxCapacity.Text, out int maxCapacity))
            {
                Room.RoomMaxCapacity = maxCapacity;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Sức chứa.");
                return;
            }

            if (int.TryParse(txtRoomTypeID.Text, out int roomTypeId))
            {
                Room.RoomTypeId = roomTypeId;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Loại phòng.");
                return;
            }

            if (cmbRoomStatus.SelectedItem is ComboBoxItem selectedItem && selectedItem.Tag != null)
            {
                if (byte.TryParse(selectedItem.Tag.ToString(), out byte status))
                {
                    Room.RoomStatus = status;
                }
            }

            if (decimal.TryParse(txtRoomPricePerDay.Text, out decimal price))
            {
                Room.RoomPricePerDay = price;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Giá/ngày.");
                return;
            }
            DialogResult = true;
        }
    }
}
