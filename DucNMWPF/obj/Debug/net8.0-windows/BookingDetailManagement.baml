   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	   &     DucNMWPF.BookingDetailManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$  BookingDetailManagement��5   	   $	��450��6)   $	��800��66    � WindowStartupLocation$ CenterScreen=�6B   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $	��300 �6   �� 5      $
��Auto �6   .+�5   
   �� $��Chi tiết đặt phòng��6   $��0��6.   $��16(�6;   $
��Bold"�6I   $��Center=�6[   $��50��6x   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgBookingDetails��5      $��1��6-      AutoGenerateColumns$ False��6:   $��10q�6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đặt phòng��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *BookingReservationId+6d     5      $ 
Mã phòng��6%   $	 100 6R    67   �� *RoomId+6R     5      $ Ngày bắt đầu��6%   $	 100 6Y    6;   �� *	StartDate+6Y     5      $ Ngày kết thúc��6%   $	 100 6X    6<   �� *	EndDate+6X     5      $ Giá thực tế��6%   $	 150 6Z    6:   �� *ActualPrice+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Hành động��6)   $ * 6<   	   CellTemplate	 5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5   "   �� -   5        $��Sửa��5   )   $��50��67   $��5,0,0,0q�6B   6S   �� 5   "   -   5        $
��Xóa��5   )   $��50��67   $��5,0,0,0q�6B   6S   5      5      5       5"      �� 5#   
   $
 
Horizontal=�6   $��2��6.   $��Center=�6;   .+�5$      �� -   5        $$��Thêm chi tiết đặt phòng��5$      $	��150��67   6D   5%      5&      5'      