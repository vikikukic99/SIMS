   M S B A M L   `   `   `  ����G  CSIMS2021-wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SIMS2021.UI.Dialogs.ViewSIMS2021.UI.Dialogs.View  5   	   W0clr-namespace:SIMS2021.CompositeComon.Converters"SIMS2021.CompositeComon.Converters  6>   '    !SIMS2021.UI.Dialogs.View.BillView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SIMS2021.UI.Dialogs.View     5   	   G
converters0clr-namespace:SIMS2021.CompositeComon.Converters     6>   i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g	 cXceed.Wpf.AvalonDock.Themes.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock    	 6�     � Title$  BillView��5   	   $	��800��6   $
��1500��6'    � 	Resources 5	      F   @SIMS2021.CompositeComon.Converters.DialogStateToEnabledConverter !  DialogStateToEnabledConverterB   <SIMS2021.CompositeComon.Converters.DateTimeToStringConverter  DateTimeToStringConverter��%:   &	        &	        5
   
   63     5   
   6/   5      .��5      )  #Xceed.Wpf.AvalonDock.DockingManager     Theme 5   
   + 	 %Xceed.Wpf.AvalonDock.Themes.AeroTheme  5         Layout. 5   
   ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot     	RootPanel. 5      -  'Xceed.Wpf.AvalonDock.Layout.LayoutPanel     Orientation$ Vertical=�6   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   Children. 5      6  0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  �	  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]] 	  	DockWidth$	 200 �6,   �
  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]] 
  Children. 5      2  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable  /  )Xceed.Wpf.AvalonDock.Layout.LayoutContent	   	ContentId$	 
properties��6,   
   Title$

 Data��6C      CanHide$ False��6P      CanClose$ False��6`      AutoHideWidth$	 240Q�5   -      Content. 5      �  � ColumnDefinitions 5      �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5!      �� $��0��6)   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5"   "   �� $��Search: ��6(   �� 5#   "   $	��150��6*   $��30��66   $��5q�6B   $��0��6M   $��0��6]   ��6j   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5$      � 5&      $��0��6#   $��1��63    5'   "   �� 5(   &   $��* �67   6C   .+�5+   "   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5+   +   $��0��6=   $��1��6M      SelectionMode$ Single=�6�   $   HorizontalScrollBarVisibility$
 Auto=�6�   $
��Auto��5,   ,      AutoGenerateColumns$ False��6:      CanUserAddRows$ False��6V      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m   {�5+   Z   �� *DataGridEnabled+��6�   �� *Items+$ PropertyChanged=� �� SelectedItem 5,      �� *SelectedItem+   Columns 5-   &   0  *System.Windows.Controls.DataGridTextColumn  5.   *   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *ID+$ OneWay=�  5/   *   $ 	Farmacist��6=    6P   �� *	Farmacist+$ OneWay=�  50   *   $
 Date��6=    6K   �� *Date+$ OneWay=� �� 	Converter# [   51   *   $
 Time��6=    6K   �� *Time+$ OneWay=�  52   *   $ 
Full price��6=    6Q   �� *	FullPrice+$ OneWay=�54   #   58      5:      5=      5>        5?      $	 200 �6,   . 5@        $	 
properties��6,   $
 Controls��6C   $ False��6T   $ False��6d   $	 240Q�5A   -   . 5C      �  5D      �� 5E   "   $��* �63    5G      �� 5H   "   $��* �60   �� 5I   "   $
��Auto �60   .+�5L      � $��0��6#   $��0��63   {�6@   �� *DialogState+# [   5M   "   �� 5N   &   $
��Auto �67   �� 5O   &   $
��Auto �67   �� 5P   &   $
��Auto �67    5R   "   �� 5S   &   $
��Auto �64   �� 5T   &   $
��Auto �64   �� 5U   &   $
��Auto �64   �� 5V   &   $
��Auto �64   �� 5W   &   $
��Auto �64   .+�5[   "   �� $��0��6(   $��0��68   $
��ID: ��6E   �� 5\   "   $��1��5]      $��0��6   $	��200��6#   ��5\   *   ��  �� Path$ SelectedItem.ID�$ PropertyChanged=�  �� ValidatesOnDataErrors$
  True��! �� NotifyOnValidationError$
! True��" �� ValidatesOnExceptions$
" True��5]   #   �� 5_   "   $��0��6(   $��1��68   $��Farmacist: ��6E   �� 5`   "   $��1��5a      $��1��6   $	��200��6#   ��5`   *   �� $ SelectedItem.Farmacist�$ PropertyChanged=�$
  True��$
! True��$
" True��5a   #   �� 5c   "   $��0��6(   $��2��68   $��Date: ��6E   (  "System.Windows.Controls.DatePicker  5d   "   $��1��5e      $��2��6   $	��200��6#   #   SelectedDate# 5d   -   �� $ SelectedItem.Date�$ PropertyChanged=�$
  True��$
! True��$
" True��5e   #   �� 5g   "   $��0��6(   $��3��68   $��Time: ��6E   �� 5h   "   $��1��5i      $��3��6   $	��200��6#   ��5h   *   �� $ SelectedItem.Time�$ PropertyChanged=�$
  True��$
! True��$
" True��5i   #   �� 5k   "   $��0��6(   $��4��68   $��Full price: ��6E   �� 5l   "   $��1��5m      $��4��6   $	��200��6#   ��5l   *   �� $ SelectedItem.FullPrice�$ PropertyChanged=�$
  True��$
! True��$
" True��5m   #   5o      5r      5t      5u      5w      5x      5{      5|      