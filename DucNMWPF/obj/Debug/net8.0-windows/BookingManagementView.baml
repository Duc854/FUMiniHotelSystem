   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	   $    DucNMWPF.BookingManagementView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$  BookingManagementView��5   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�6@   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5         ��Name$ txtSearchKeyword��5      $	��200��60   $��25��6<   �� 5      -   5        $��Tìm kiếm��5      $	��100��6(   $��5,0,0,0q�64   6E   �� 5      -   5        $��Thêm đặt phòng��5      $	��150��6.   $��5,0,0,0q�6:   6K   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgBookings��5      $��1��6'      AutoGenerateColumns$ False��64   $��10q�6P      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đặt phòng��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6d   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *BookingReservationId+6d     5      $ Ngày đặt��6%   $		 100 6W   
 67   �� *BookingDate+6W     5      $ Khách hàng��6%   $		 100 6X   
 69   �� *
CustomerId+6X     5      $ Tổng tiền��6%   $		 200 6W   
 68   �� *
TotalPrice+6W     5      $ Trạng thái��6%   $	 80 6[   
 69   �� *BookingStatus+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Hành động��6)   $		 170 6<      CellTemplate 5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��Sửa��5   )   $��50��67   $��5,0,0,0q�6B   6S   �� 5   "   -   5        $
��Xóa��5   )   $��50��67   $��5,0,0,0q�6B   6S   �� 5    "   -   5        $��
Chi tiết��5    )   $��50��6<   $��5,0,0,0q�6G   6X   5!      5"      5$      5&      5'      5(      