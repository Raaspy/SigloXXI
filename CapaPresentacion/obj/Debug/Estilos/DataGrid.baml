   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&    System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �Name	 J� Opacity
 � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName �� CornerRadius �� Padding ��Name � ColumnDefinitions � RowDefinitions    SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll  ��Name! �� ScrollableHeight" � Maximum# �� Orientation$ �� ViewportHeight% �� ViewportSize*& �� #ComputedVerticalScrollBarVisibility' � Value( �� Mode) �� ScrollableWidth* �� ViewportWidth,+ �� %ComputedHorizontalScrollBarVisibility, �� Triggers- ]� 
Conditions. �� Property/ �� Value   ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3   -Microsoft.Windows.Themes.DataGridHeaderBorder0   	IsPressed1 J� IsMouseOver2   	IsHovered3   CanUserSort4   IsClickable5   SortDirection6   SortDirection7   SeparatorVisibility8   SeparatorVisibility9   SeparatorBrush:   SeparatorBrush; n�Name< �� Color  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      UthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  5      %h  (��       5      $" DataGridSelectAllButtonStyle��"   )'   �    &	  �    &	 �    7   7   (�� �    5�      *DataGrid.FocusBorderBrushKey+)&	 �    �� 5      "  ��6{   .�5   
   ��  � �� 5      �� 5	      " ��6"   .R�5
      � .+�5      �� $ Border��6$   #��� ��64    . 6u   � 5      $ Arrow��6"   
���   �$��Right=�6>   $��8,8,3,3q�6Z   $
	 0.15Q�6k   
 �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ Border��67   # � ��6K    � ��5      P� 5       � �� . . �5      �� $ Border��65   # � ��6I    � ��5      P� 5       � {� .  . �5      �� $ Arrow��6;    � y�$ 	Collapsed=�6N   5      5      5      5      �� 5       "    6   .�5!   
   ��  � ��
 ���� 6'   �� 5"   
    � ��# � ��6'   �� 5#   
    � �� �#48A9996(   �� 5$   
    � ��$ 3q�6,   �� 5%   
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5&   
    � �� . 6:   �� 5'   
    �@��PanningMode$
 Both=�65   �� 5(   
    �@��IsFlicksEnabled .  63   �� 5)   
     �@  HorizontalGridLinesBrush �#48A99965   �� 5*   
    �@  VerticalGridLinesBrush
 ���� 63   �� 5+   
    � �� 5,      �� 5-      "   6"   .R�5.      �� $ 5��6   #��z��6.   #��z��6X   #��z��6�   # z��6�    . ._�5/      �� $ DG_ScrollViewer��6'   |�.  ��50      �� 51   "   " ��62   .R�52   &   �  53   *   �� 54   .   $
��Auto �6?   �� 55   .   $��* �6?   �� 56   .   $
��Auto �6?    58   *   �� 59   .   $
��Auto �6<   �� 5:   .   $��* �6<   �� 5;   .   $
��Auto �6<   .+�5=   *   �� #��Z 61   |�.  ��6r   C� *�� $" DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5>   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 5?   *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 5@   *   $  PART_VerticalScrollBar��64   $��2��6T   #" z! 6d   $# Vertical=�6�   $��1��6�   #% z$ 6  #y�z& 6D  ' 6�   �� *VerticalOffset+$( OneWay=� �� *TemplatedParent+6D  � 5A   *   $��1��6/   $��2��6?    5B   .   �� 5C   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5D   2   $��* �6C   .+�5F   .   �� $  PART_HorizontalScrollBar��68   $��1��6Z   #" z) 6j   $# 
Horizontal=�6�   #% z* 6  #y�z+ 6?  ' 6�   �� *HorizontalOffset+$( OneWay=� �� *TemplatedParent+6?  5G   +   5H   '   5I   #   .��5K      �� # z 6-   5L      5M      5N      5P      , 5Q   
   ]� 5R      - 5S      �� 5T      . �@��
IsGrouping/ . 66   �� 5U      ". �@%�IsVirtualizingWhenGrouping/ .  6X   ./�5W      ��  � �� .  6B   5X      5Z      �� 5]      "  n�6-   .�5^   
   ��  � ��$ 8��6"   �� 5_   
    � ��
 ���� 6'   �� 5`   
    �@�Cursor$ SizeWE��6#   �� 5a   
    � �� 5b      �� 5c      " n�6"   .R�5d      �� #��z��6   # z��6G   5e      5g      5h      �� 5k      "   6/   .�5l   
   ��  � ��$ Center=�65   �� 5m   
    � ��
 ���� 6'   �� 5n   
    � ��$ Center=�67   �� 5o   
    � ��$ 30��6#   �� 5p   
    � ��$ Medium"�6'   �� 5q   
    � ��$ 
Montserrat)�6'   �� 5r   
    � ��$ Italic$�6&   �� 5s   
    � ��$ 15(�6%   �� 5t   
    � �� 5u      �� 5v      "  6"   .R�5w      � .+�5x        ���#48A999#��z��6J   #��z��6v   #0 z��6�   #2 z1 6�   #4 z3 6�   # z��6(  #6 z5 6L  #8 z7 6|  #: z9 6�  ._�5y      �� $��0q�6/   #��z��6:   ��. # z 6�   #��z��6�   5z      n� 5{      $; PART_LeftHeaderGripper��6    $
��Left=�6@   8��  6[   n� 5|      $; PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5}      5~      5�      5�      �� 5�      $< 	#FF000000��6F   �� 5�      "   6'   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   #��z��6G   #��z��6s    . ._�5�      �� # z 6+   5�      5�      5�      , 5�   
   P� 5�       �@ 
IsSelected . . �5�      ��  � �� �#3D917C6/   �� 5�       � ��# � ��6/   �� 5�       � �� �#3D917C60   5�      P� 5�       �@J�IsKeyboardFocusWithin . . �5�      ��  � �� �#48A99960   �� 5�       � ��$ 2q�64   5�      ]� 5�      - 5�      �� 5�      . �@ 
IsSelected/ . 66   �� 5�      . �@��IsSelectionActive/ .  6F   ./�5�      ��  � �� �#3D917C6/   �� 5�       � �� �#3D917C60   �� 5�       � ��# � .�6/   5�      P� 5�       � {� .  . �5�      ��  � ��# � ��6/   5�      5�      5�      