   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	   !    DucNMWPF.RoomManagementView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$"  Quản lý thông tin phòng��5   	   $	��450��6)   $	��800��66    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5         ��Name$ txtSearchKeyword��5      $	��200��60   $��25��6<   �� 5      -   5        $��Tìm kiếm��5      $	��100��6(   $��5,0,0,0q�64   6E   �� 5      -   5        $��Thêm phòng��5      $	��150��6*   $��5,0,0,0q�66   6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgRooms��5      $��1��6$      AutoGenerateColumns$ False��61   $��10q�6M      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *RoomId+6L     5      $ Số phòng��6%   $		 100 6V   
 67   �� *
RoomNumber+6V     5      $ Mô tả��6%   $		 200 6^   
 64   �� *RoomDetailDescription+6^     5      $ Sức chứa��6%   $	 80 6[   
 67   �� *RoomMaxCapacity+6[     5      $ Loại phòng��6%   $	 80 6X   
 69   �� *
RoomTypeId+6X     5      $ Trạng thái��6%   $	 80 6X   
 69   �� *
RoomStatus+6X     5      $ 
Giá/ngày��6%   $		 100 6[   
 67   �� *RoomPricePerDay+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Hành động��6)   $		 150 6<      CellTemplate 5      �� 5      .R�5       �� $ 
Horizontal=�6)   .+�5!   "   �� -   5        $��Sửa��5!   )   $��50��67   $��5,0,0,0q�6B   6S   �� 5"   "   -   5        $
��Xóa��5"   )   $��50��67   $��5,0,0,0q�6B   6S   5#      5$      5&      5(      5)      5*      