   M S B A M L   `   `   `  ����G  CSIMS2021-wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SIMS2021.UI.Dialogs.ViewSIMS2021.UI.Dialogs.View  5   	   W0clr-namespace:SIMS2021.CompositeComon.Converters"SIMS2021.CompositeComon.Converters  6>   )    #SIMS2021.UI.Dialogs.View.DoctorView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SIMS2021.UI.Dialogs.View     5   	   G
converters0clr-namespace:SIMS2021.CompositeComon.Converters     6>   i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g	 cXceed.Wpf.AvalonDock.Themes.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock    	 6�     � Title$  
DoctorView��5   	   $	��800��6   $
��1500��6)    � 	Resources 5	      F   @SIMS2021.CompositeComon.Converters.DialogStateToEnabledConverter !  DialogStateToEnabledConverter��%   &	          5
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
  AutoHideWidth$	 240Q�5   -      Content. 5      �  � ColumnDefinitions 5      �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5       �� $��0��6)   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5!   "   �� $��Search: ��6(   �� 5"   "   $	��150��6*   $��30��66   $��5q�6B   $��0��6M   $��0��6]   ��6j   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5#      &   System.Windows.Controls.DataGrid  5%      -   5          Name$ DataGrid��5%   '   $��0��69   $��1��6I      SelectionMode$ Single=�6|   $   HorizontalScrollBarVisibility$
 Auto=�6�   $
��Auto��5&   ,      AutoGenerateColumns$ False��6:      CanUserAddRows$ False��6V      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m   {�5%   V   �� *DataGridEnabled+��6�   �� *Items+$ PropertyChanged=� �� SelectedItem 5&      �� *SelectedItem+   Columns 5'   "   0  *System.Windows.Controls.DataGridTextColumn  5(   &   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *ID+$ OneWay=�  5)   &   $ Username��69    6K   �� *
Username+$ OneWay=�  5*   &   $ 
First name��69    6M   �� *	FirstName+$ OneWay=�  5+   &   $ 	Last name��69    6L   �� *
LastName+$ OneWay=�5-      5.      50      51        52      $	 200 �6,   . 53      
  $	 
properties��6,   $
 Controls��6C   $ False��6T   $ False��6d   $	 240Q�54   -   . 56      �  57      �� 58   "   $��* �63    5:      �� 5;   "   $��* �60   �� 5<   "   $
��Auto �60   .+�5?      � $��0��6#   $��0��63   {�6@   �� *DialogState+ �� 	Converter# [   5@   "   �� 5A   &   $
��Auto �67   �� 5B   &   $
��Auto �67   �� 5C   &   $
��Auto �67    5E   "   �� 5F   &   $
��Auto �64   �� 5G   &   $
��Auto �64   �� 5H   &   $
��Auto �64   �� 5I   &   $
��Auto �64   �� 5J   &   $
��Auto �64   �� 5K   &   $
��Auto �64   .+�5O   "   �� $��0��6(   $��0��68   $
��ID: ��6E   �� 5P   "   $��1��5Q      $��0��6   $	��200��6#   ��5P   *   ��  �� Path$ SelectedItem.ID�$ PropertyChanged=�  �� ValidatesOnDataErrors$
  True��! �� NotifyOnValidationError$
! True��" �� ValidatesOnExceptions$
" True��5Q   #   �� 5S   "   $��0��6(   $��1��68   $��
Username: ��6E   �� 5T   "   $��1��5U      $��1��6   $	��200��6#   ��5T   *   �� $ SelectedItem.Username�$ PropertyChanged=�$
  True��$
! True��$
" True��5U   #   �� 5W   "   $��0��6(   $��2��68   $��
Password: ��6E   G� 5X   "   -   5        # G�Name$# password��5X   .   $��1��5Y      $��2��6   $	��200��6#   �� 5[   "   $��0��6(   $��3��68   $��First name: ��6E   �� 5\   "   $��1��5]      $��3��6   $	��200��6#   ��5\   *   �� $ SelectedItem.FirstName�$ PropertyChanged=�$
  True��$
! True��$
" True��5]   #   �� 5_   "   $��0��6(   $��4��68   $��Last name: ��6E   �� 5`   "   $��1��5a      $��4��6   $	��200��6#   ��5`   *   �� $ SelectedItem.LastName�$ PropertyChanged=�$
  True��$
! True��$
" True��5a   #   �� 5c   "   $��0��6(   $��5��68   $��Doctor Type: ��6E   �� 5d   "   $��1��6+   $��5��6;   $	��200��6H   $ �� DisplayMemberPath$
$ Name��5e   T   % �� SelectedValuePath$% Value��6m   & �� SelectedValue& 5d   T   �� $ SelectedItem.DoctorType�$ PropertyChanged=�$
  True��$
! True��$
" True����5e   +   �� $ DoctorTypes�5f   #   5h      �� 5j      $��0��6)   $��1��69   $ 
Horizontal=�6F   $��10q�6_   .+�5k   &   �� $��0��6-   $��1��6=   $��10q�6i   $	��120��6u   ' � ToolTip$' 
Add doctor��6�   ��6J   �� *
AddCommand+.��5l   *   �� $ 
Horizontal=�65   $��Center=�6N   $��Center=�6i   .+�5m   *   �� $��5q�60   $��15��6;   $i��cC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\add.png��6G   6�   �� 5n   .   $��Center=�68   $	��Add��6S   6`   5o   +   5p   '   �� 5q   "   $��0��6)   $��2��69   $��10q�6f   $	��120��6r   $' 	Edit user��6~   ��6F   �� *EditCommand+.��5r   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5s   *   �� $��5q�60   $��20��6;   $k��eC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\edit2.png��6G   6�   �� 5t   *   $��Center=�64   $
��Edit��6O   6]   5u   '   5v   #   �� 5w   "   $��0��6)   $��3��69   $��10q�6h   $	��120��6t   $' Delete user��6�   ��6F   �� *DeleteCommand+.��5x   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5y   *   �� $��5q�60   $��40��6;   $m��gC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\delete3.png��6G   6�   �� 5z   *   $��Center=�64   $��Delete��6O   6_   5{   '   5|   #   �� 5}   "   $��0��6)   $��4��69   $��10q�6d   $	��120��6p   $' Ok user��6|   ��6F   �� *	OkCommand+.��5~   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5   *   �� $��5q�60   $��25��6;   $h��bC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\ok.png��6G   6�   �� 5�   *   $��Center=�64   $��Ok��6O   6[   5�   '   5�   #   �� 5�   "   $��0��6)   $��5��69   $��10q�6h   $	��120��6t   $' Cancel user��6�   ��6F   �� *CancelCommand+.��5�   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6e   .+�5�   *   �� $��5q�60   $��30��6;   $l��fC:\Users\vkuki\OneDrive\Radna površina\projekat za 6 sims\SIMS2021-wpf\SIMS2021-wpf\Images\cancel.png��6G   6�   �� 5�   *   $��Center=�64   $��Cancel��6O   6_   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      