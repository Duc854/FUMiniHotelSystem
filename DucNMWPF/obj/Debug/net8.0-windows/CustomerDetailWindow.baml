   M S B A M L   `   `   `  ����  DucNMWPF#    DucNMWPF.CustomerDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Thông tin khách hàng��5   	   $	��350��6&   $	��400��63    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Họ và tên:��6-   $��Center=�6B   �� 5   
   -   5         ��Name$ FullNameTextBox��5      $��0��6+   $��1��68   �� 5   
   $��1��6   $��0��6   $��Email:��6-   $��Center=�6>   �� 5   
   -   5        $ EmailTextBox��5      $��1��6(   $��1��65   �� 5   
   $��2��6   $��0��6   $��SĐT:��6-   $��Center=�6<   �� 5   
   -   5        $ TelephoneTextBox��5      $��2��6,   $��1��69   �� 5   
   $��3��6   $��0��6   $��Ngày sinh:��6-   $��Center=�6B   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ BirthdayPicker��5      $��3��6-   $��1��6:   �� 5   
   $��4��6   $��0��6   $��Mật khẩu:��6-   $��Center=�6A   G� 5   
   -   5         G�Name$ PasswordBox��5      $��4��6+   $��1��68   �� 5   
   $��5��6   $��0��6   $��Trạng thái:��6-   $��Center=�6C   �� 5   
   -   5         ��Name$ StatusComboBox��5      $��5��6+   $��1��68    �� SelectedValuePath$	 Tag��6H   .@�5       �� $��Active��6   
	 � Tag$	 1��6,   �� 5!      $��Inactive��6   $	 0��6.   5"      �� 5#   
   $��6��6   $��2��6"   
 �� Orientation$
 
Horizontal=�66   $��Right=�5$      $��0,10,0,0q�61   .+�5%      �� -   5        $��OK��5%      $��80��6"   $��5q�6-    �� 	IsDefault$
 True��68   6I   �� 5&      $��Cancel��6   $��80��6&   $��5q�61    �� IsCancel$
 True��6<   5'      5(      5)      