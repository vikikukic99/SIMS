   M S B A M L   `   `   `  ����G  CSIMS2021-wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SIMS2021.UI.Components.Login.View!SIMS2021.UI.Components.Login.View  5   	   1    +SIMS2021.UI.Components.Login.View.LoginView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:SIMS2021.UI.Components.Login.View     5   	     � Title$  	LoginView��5   	    � SizeToContent$ WidthAndHeight=�6   .��5	      � $��20q�6    � ColumnDefinitions 5
      �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6    � RowDefinitions 5      �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   .+�5      �� $��0��6   $��0��6   $��	Username:��6)   �� 5      $��1��6(   $��0��68   $��0��6E   $	��250��6R   ��6   �� *
Username+6R   �� 5      $��0��6   $��1��6   $��	Password:��6)   G� 5      -   5        $��passwordBox��5      $��1��6S   $��1��6c   $��1��6p   $	��250��6}   �� 5      $��2��6   $��1��6    �� Orientation$ 
Horizontal=�6.   $��Right=�6G   .+�5   
   �� $��Login��6    �� 	IsDefault$
 True��6!   $��2��6S   ��62   �� *LoginCommand+6S   �� 5   
   $��Cancel��6    �� IsCancel$
 True��6"   $��3��6T   ��62   �� *CancelCommand+6T   5      5      5      