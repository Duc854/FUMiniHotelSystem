   M S B A M L   `   `   `  ����  DucNMWPF    DucNMWPF.HomePage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Trang Chủ��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64   .��5      � ���#F3F3F3.+�5   
   �� .+�5      �� $$��Danh Sách Phòng Khả Dụng��6   $��20(�68   $
��Bold"�6F   
���   �$��0 0 0 10q�6k    �� TextAlignment$ Center=�6}   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
dgRoomList��5      $��10q�6+      AutoGenerateColumns$ False��67      Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$ Số phòng��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
RoomNumber+  5      $ Mô tả phòng��6)    6>   �� *RoomDetailDescription+  5      $ Loại phòng��6)    6=   �� *RoomType.RoomTypeName+  5      $ Sức chứa��6)    6;   �� *RoomMaxCapacity+  5      $ Giá($)/Ngày��6)    6>   �� *RoomPricePerDay+5      �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�5      �� -   5        	 ��Name$	 	txtSearch��5      $	��200��6-   $��0,0,10,0q�69   $��Center=�5      �� 5      -   5        $��Tìm kiếm��5      $	��100��6,   
����ح�6M   5      �� 5      $��Kết quả tìm kiếm:��6   $��16(�61   $
��Bold"�6?   $��
10 10 10 0q�6Q     5      -   5        $ dgSearchResults��5      $��10q�60   $ False��6<    5        5      $ Số phòng��6)    6;   �� *
RoomNumber+  5      $ Mô tả phòng��6)    6>   �� *RoomDetailDescription+  5      $ Loại phòng��6)    6=   �� *RoomType.RoomTypeName+  5      $ Sức chứa��6)    6;   �� *RoomMaxCapacity+  5      $ Giá($)/Ngày��6)    6>   �� *RoomPricePerDay+5       �� 5!      $ 
Horizontal=�6   $��Center=�62   .+�5"      �� -   5        $��Sửa Hồ Sơ��5"      $	��120��6-   $��40��69   
��� � �
�������$��	0 0 100 0q�6�   �� 5#      -   5        $#��Xem lịch sử đặt phòng��5#      $	��120��69   $��40��6E   ���#0078D7
�������$��0 0 10 0q�6�   5$      5%      5&      5'      