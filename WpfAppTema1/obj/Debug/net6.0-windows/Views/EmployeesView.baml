   M S B A M L   `   `   `  ����F  BWpfAppTema1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfAppTema1.ViewModelsWpfAppTema1.ViewModels  5      %    WpfAppTema1.Views.EmployeesView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;
ViewModels$clr-namespace:WpfAppTema1.ViewModels     5        � DataContext  5      .  (WpfAppTema1.ViewModels.EmployeeViewModel  5   
   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $	��Add��6   $��5q�6J   ��6#   �� *AddEmployeeCommand+6J   �� 5      $��Update��6   $��5q�6P   ��6&   �� *UpdateEmployeeCommand+6P   �� 5      -   5        $��Delete��5      $��5q�6P   ��6&   �� *DeleteEmployeeCommand+6[   5      �� 5   
   -   5        $��1��5      ��6    �� *	Employees+ �� SelectedItem 6B   �� *SelectedEmployee+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� DisplayMemberBinding 61   �� *id+�� 5      $
��Name��6%    63   �� *name+�� 5      $��Position��6%    67   �� *
position+�� 5      $��Username��6%    67   �� *
username+�� 5      $��Password��6%    67   �� *
password+5      5      5       5!      