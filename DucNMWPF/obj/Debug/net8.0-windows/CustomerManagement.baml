   M S B A M L   `   `   `  ����C  ?DucNMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DucNMWPFDucNMWPF  5   	   !    DucNMWPF.CustomerManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DucNMWPF     5   	     � Title$  CustomerManagement��5   	   $	��450��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�6=   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��200��6-   $��25��69   �� 5      -   5        $��Tìm kiếm��5      $	��100��6(   $��5,0,0,0q�64   6E   �� 5      -   5        $��Thêm khách hàng��5      $	��150��6/   $��5,0,0,0q�6;   6L   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CustomerDataGrid��5      $��1��6-      AutoGenerateColumns$ False��6:   $��10q�6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *
CustomerId+6P     5      $ Họ và tên��6%   $		 200 6]   
 68   �� *CustomerFullName+6]     5      $ Email��6%   $		 200 6U   
 64   �� *EmailAddress+6U     5      $
 SĐT��6%   $		 150 6P   
 62   �� *	Telephone+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Hành động��6)   $		 150 6<      CellTemplate 5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��Sửa��5   )   $��50��67   $��5,0,0,0q�6B   5   )   �� 5   "   -   5        $
��Xóa��5   )   $��50��67   $��5,0,0,0q�6B   5    )   5!      5"      5$      5&      5'      5(      