   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CapaPresentacion.FinanzasCapaPresentacion.Finanzas  5   	   1    +CapaPresentacion.Finanzas.VentanaMontoTotal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CapaPresentacion.Finanzas     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  VentanaMontoTotal��5	   	   $	��700��6#   $
��1200��60    � WindowStyle$
 None=�6=    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   
������ ._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��70 �6    �� 5      �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��25 �6#   .+�5       �� $ 10��5!      ���#48A999$��3��5#      $��3��5$      $��3q�5%      ���#E0F2F1$	��300��5'      $��291.25��5(      $	��Top=�5)      $��Right=�5*      ._�5,      � $��5 2 5 2q�6    5-      �� 5.      $��30 �6(   �� 5/      $��* �6(   �� 50      $��25 �6(    52      �� 53      $��25 �6+   �� 54      $��* �6+   �� 55      $��25 �6+   .+�58      �� -   5         ��Name$ btnCerrarVen��58      $��0q�59      $��x��5:      
���   �$��16(�5<      	 � Cursor$
	 Hand��5=      $��3��5>      ��5B      �� 5C      
 �� 
TargetType"
 ��6$   .�5D   "   ��  �� Property � �� �� Value �#e0f2f16?    �� Triggers 5E   "   P� 5F   &    P� Property �@J�IsMouseOver P� Value . . �5G   *   ��  � �� �#B5DEDA6G   5H   '   5J      ��5N      �� 5O       �� 
TargetType" ��6.   .R�5P   "   �� $��20��6)   $��20��64   $ 8��5Q   )   #��z��5R   )   ._�5S   &   �� $��Center=�67   $��Center=�5T   -   5V   #   5W      5Y      �� 5\      $��1��6   $��1��6-   $ 20��5]      ���#C8C8C8$	��1.5q�5_      ._�5a      �� .+�5b      �� $��221.25��5c   !   $��50��5d   !   $	��Top=�5e   !   $��0 50 0 0q�5f   !   $��
ExtraLight"�5g   !   $��
Montserrat)�5h   !   $��Normal$�5i   !   $��20(�5j   !   $
��Wrap=�5k   !   $1��+El monto total registrado en el sistema es:��5l   !   5m      �� 5o       �� Orientation$ 
Horizontal=�6)   $��Center=�6B   $��0 20 0 0q�6_   .+�5p   "   �� $��Center=�5q   %   $��Center=�5r   %   $��1��5s   %   $��1��62   $��
ExtraLight"�5t   %   $��
Montserrat)�5u   %   $��Normal$�5v   %   $��28(�5w   %   $��$��5x   %   5y   #   �� 5z   "   -   5         ��Name$ lbMontoTotalCaja��5{   %   $��Center=�5|   %   $��Center=�5}   %   $��1��5~   %   $��1��62   $��
ExtraLight"�5   %   $��
Montserrat)�5�   %   $��Normal$�5�   %   $��28(�5�   %   $��0��5�   %   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      