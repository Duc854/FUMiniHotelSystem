   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	        DucNMWPF.BookingDetailView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$  BookingDetailView��5   	   $	��450��6#   $	��600��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � .+�5
   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��
10,10,10,0q�62   .+�5      �� $��Mã Đặt Phòng:��6   $��Center=�61   $	��120��6L   �� 5      -   5         ��Name$ txtBookingID��5      $	��200��60    �� 
IsReadOnly$
 True��6<   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgAvailableRooms��5         AutoGenerateColumns$ False��61   $��
10,10,10,0q�6M   $	��150��6a      SelectionMode$ Single=�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Mã Phòng��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 80 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
RoomNumber+6Z     5      $	 Mô tả��6)   $
 * 6b    68   �� *RoomDetailDescription+6b     5      $	 Loại phòng��6)   $
 70 6a    6=   �� *RoomMaxCapacity+6a     5      $	 Sức chứa��6)   $
 60 6_    6;   �� *RoomMaxCapacity+6_     5      $	 Giá Phòng��6)   $
 90 6`    6<   �� *RoomPricePerDay+6`   5      �� 5      $ 
Horizontal=�6   $��
10,10,10,0q�62   $
��Left=�6F   .+�5      �� $��Ngày Bắt Đầu:��6   $��Center=�61   $	��100��6L   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpStartDate��5      $��5q�62   $	��120��6=   �� 5      $��Ngày Kết Thúc:��6   $��Center=�62   $	��100��6M     5      -   5        $ 	dpEndDate��5      $��5q�60   $	��120��6;   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��0,10,0,0q�6O   .+�5      �� -   5        $��Lưu Đặt Phòng��5      $	��120��6-   69   �� 5       -   5        $��Hủy��5       $	��120��6#   $��10,0,0,0q�6/   6A   5!      5"      5#      5$      