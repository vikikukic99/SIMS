   M S B A M L   `   `   `  ����G  CSIMS2021-wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SIMS2021.UI.Dialogs.ViewSIMS2021.UI.Dialogs.View  5   	   W0clr-namespace:SIMS2021.CompositeComon.Converters"SIMS2021.CompositeComon.Converters  6>   *    $SIMS2021.UI.Dialogs.View.ProductView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SIMS2021.UI.Dialogs.View     5   	   G
converters0clr-namespace:SIMS2021.CompositeComon.Converters     6>   i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g	 cXceed.Wpf.AvalonDock.Themes.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock    	 6�     � Title$  ProductView��5   	   $	��800��6   $
��1500��6*    � 	Resources 5	      F   @SIMS2021.CompositeComon.Converters.DialogStateToEnabledConverter !  DialogStateToEnabledConverter��%   &	          5
   
   63   5      .��5      )  #Xceed.Wpf.AvalonDock.DockingManager     Theme 5   
   + 	 %Xceed.Wpf.AvalonDock.Themes.AeroTheme  5         Layout. 5   
   ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot     	RootPanel. 5      -  'Xceed.Wpf.AvalonDock.Layout.LayoutPanel     Orientation$ Vertical=�6   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   Children. 5      6  0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   	DockWidth$	 200 �6,   �	  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]] 	  Children. 5      2
  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable
  /  )Xceed.Wpf.AvalonDock.Layout.LayoutContent	   	ContentId$	 
properties��6,   
   Title$

 Data��6C    
  CanHide$ False��6P      CanClose$ False��6`    
  AutoHideWidth$	 240Q�5   -      Content. 5      �  � ColumnDefinitions 5      �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5!      �� $��0��6)   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5"   "   �� $��30��6(   $��30��63   $��5q�6?   $��/Icons/search.png��6J   $��Center=�6e   �� 5#   "   $	��150��6*   $��30��66   $��5q�6B   $��0��6M   $��0��6]   ��6j   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5$      &   System.Windows.Controls.DataGrid  5&      -   5          Name$ DataGrid��5&   '   $��0��69   $��1��6I      SelectionMode$ Single=�6|   $   HorizontalScrollBarVisibility$
 Auto=�6�   $
��Auto��5'   ,      AutoGenerateColumns$ False��6:      CanUserAddRows$ False��6V      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m   {�5&   V   �� *DataGridEnabled+��6�   �� *Items+$ PropertyChanged=� �� SelectedItem 5'      �� *SelectedItem+   Columns 5(   "   0  *System.Windows.Controls.DataGridTextColumn  5)   &   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *ID+$ OneWay=�  5*   &   $
 Name��69    6G   �� *Name+$ OneWay=�  5+   &   $ Description��69    6N   �� *Description+$ OneWay=�  5,   &   $ Quantity��69    6K   �� *
Quantity+$ OneWay=�5.      5/      51      52        53      $	 200 �6,   . 54      
  $	 
properties��6,   $
 Controls��6C   $ False��6T   $ False��6d   $	 240Q�55   -   . 57      �  58      �� 59   "   $��* �63    5;      �� 5<   "   $��* �60   �� 5=   "   $
��Auto �60   .+�5@      � $��0��6#   $��0��63   {�6@   �� *DialogState+ �� 	Converter# [   5A   "   �� 5B   &   $
��Auto �67   �� 5C   &   $
��Auto �67   �� 5D   &   $
��Auto �67    5F   "   �� 5G   &   $
��Auto �64   �� 5H   &   $
��Auto �64   �� 5I   &   $
��Auto �64   �� 5J   &   $
��Auto �64   .+�5N   "   �� $��0��6(   $��0��68   $
��ID: ��6E   �� 5O   "   $��1��5P      $��0��6   $	��200��6#   ��5O   *   ��  �� Path$ SelectedItem.ID�$ PropertyChanged=�  �� ValidatesOnDataErrors$
  True��! �� NotifyOnValidationError$
! True��" �� ValidatesOnExceptions$
" True��5P   #   �� 5R   "   $��0��6(   $��1��68   $��Name: ��6E   �� 5S   "   $��1��5T      $��1��6   $	��200��6#   ��5S   *   �� $ SelectedItem.Name�$ PropertyChanged=�$
  True��$
! True��$
" True��5T   #   �� 5W   "   $��0��6(   $��2��68   $��Description: ��6E   �� 5X   "   $��1��5Y      $��2��6   $	��200��6#   ��5X   *   �� $ SelectedItem.Description�$ PropertyChanged=�$
  True��$
! True��$
" True��5Y   #   �� 5[   "   $��0��6(   $��3��68   $��
Quantity: ��6E   �� 5\   "   $��1��5]      $��3��6   $	��200��6#   ��5\   *   �� $ SelectedItem.Quantity�$ PropertyChanged=�$
  True��$
! True��$
" True��5]   #   5_      �� 5a      $��0��6)   $��1��69   $ 
Horizontal=�6F   $��10q�6_   .+�5b   "   �� $��0��6)   $��1��69   $��10q�6e   $	��120��6q   # � ToolTip$# Add user��6}   ��6F   �� *
AddCommand+.��5c   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5d   *   �� $��5q�60   $��15��6;   $i��cC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\add.png��6G   6�   �� 5e   *   $��Center=�64   $	��Add��6O   6\   5f   '   5g   #   �� 5h   "   $��0��6)   $��2��69   $��10q�6f   $	��120��6r   $# 	Edit user��6~   ��6F   �� *EditCommand+.��5i   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5j   *   �� $��5q�60   $��20��6;   $k��eC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\edit2.png��6G   6�   �� 5k   *   $��Center=�64   $
��Edit��6O   6]   5l   '   5m   #   �� 5n   "   $��0��6)   $��3��69   $��10q�6h   $	��120��6t   $# Delete user��6�   ��6F   �� *DeleteCommand+.��5o   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5p   *   �� $��5q�60   $��40��6;   $m��gC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\delete3.png��6G   6�   �� 5q   *   $��Center=�64   $��Delete��6O   6_   5r   '   5s   #   �� 5t   "   $��0��6)   $��4��69   $��10q�6d   $	��120��6p   $# Ok user��6|   ��6F   �� *	OkCommand+.��5u   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5v   *   �� $��5q�60   $��25��6;   $h��bC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\ok.png��6G   6�   �� 5w   *   $��Center=�64   $��Ok��6O   6[   5x   '   5y   #   �� 5z   "   $��0��6)   $��5��69   $��10q�6h   $	��120��6t   $# Cancel user��6�   ��6F   �� *CancelCommand+.��5{   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5|   *   �� $��5q�60   $��30��6;   $l��fC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\cancel.png��6G   6�   �� 5}   *   $��Center=�64   $��Cancel��6O   6_   5~   '   5   #   5�      5�      5�      5�      5�      5�      5�      5�      