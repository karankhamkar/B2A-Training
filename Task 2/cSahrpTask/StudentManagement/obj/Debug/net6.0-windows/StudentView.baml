   M S B A M L   `   `   `  ????L  HStudentManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManagementStudentManagement  5   	       StudentManagement.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManagement     5   	     ? Title$  Window1??5   	   $	??450??6   $	??800??6&   .??5	      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   6-   ?? 5      $	??300 ?6   6-   .+?5   
   ?? $
??Name??6   ?? 5   
   -   5         ??Name$ txtName??5      $??0??5      $??1??5      ?? 5   
   $??Gender??6   $??1??5      $??0??5      ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??1??5      $??1??5      .+?5      	? .??6   Male6    	? 5       .??6   Female6"   	? 5!      .??6   Other6!   5#      ?? 5$   
   -   5        $??Save Student??5$      $??3??5%      $??1??5&      5)      5,      5-      