   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	       DucNMWPF.RoomDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$  Thông tin phòng��5      $	��400��6    $	��500��6-    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Số phòng:��6-   $��Center=�6A   �� 5   
   -   5         ��Name$ txtRoomNumber��5      $��0��6)   $��1��66   �� 5   
   $��1��6   $��0��6   $��	Mô tả:��6-   $��Center=�6>   �� 5   
   -   5        $ txtRoomDescription��5      $��1��6.   $��1��6;   �� 5   
   $��2��6   $��0��6   $��Sức chứa:��6-   $��Center=�6A   �� 5   
   -   5        $ txtRoomMaxCapacity��5      $��2��6.   $��1��6;   �� 5   
   $��3��6   $��0��6   $��Loại phòng:��6-   $��Center=�6C   �� 5   
   -   5        $ txtRoomTypeID��5      $��3��6)   $��1��66   �� 5    
   $��4��6   $��0��6   $��Trạng thái:��6-   $��Center=�6C   �� 5!   
   -   5         ��Name$ cmbRoomStatus��5!      $��4��6*   $��1��67   .@�5"      �� $��Active��6   
 � Tag$ 1��6,   �� 5#      $��Inactive��6   $ 0��6.   5$      �� 5%   
   $��5��6   $��0��6   $��Giá/ngày:��6-   $��Center=�6A   �� 5&   
   -   5        $ txtRoomPricePerDay��5&      $��5��6.   $��1��6;   �� 5'   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Right=�6O   $��0,10,0,0q�6k   .+�5(      �� -   5        $��OK��5(      $��80��6"   $��5q�6-    �� 	IsDefault$
 True��68   6I   �� 5)      $��Cancel��6   $��80��6&   $��5q�61   	 �� IsCancel$
	 True��6<   5*      5+      5,      