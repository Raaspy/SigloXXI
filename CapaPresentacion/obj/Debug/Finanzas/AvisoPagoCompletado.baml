   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CapaPresentacion.FinanzasCapaPresentacion.Finanzas  5   	   3    -CapaPresentacion.Finanzas.AvisoPagoCompletado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CapaPresentacion.Finanzas     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  AvisoPagoCompletado��5	   	   $	��700��6%   $
��1200��62    � WindowStyle$
 None=�6?    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   
������ ._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��70 �6    �� 5      $��* �6    �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��25 �6#   .+�5      �� $ 10��5       ���#48A999$��0��5"      $��3��5#      $��3��5$      $��2��5%      $��3q�5&      ���#E0F2F1$	��300��5(      $	��582��5)      $	��Top=�5*      $��Right=�5+      ._�5-      � $��5 2 5 2q�6    5.      �� 5/      $��30 �6(   �� 50      $��* �6(   �� 51      $��25 �6(    53      �� 54      $��25 �6+   �� 55      $��50 �6+   �� 56      $��* �6+   �� 57      $��50 �6+   �� 58      $��25 �6+   .+�5<      �� $��2��6   $��1��6-   $ 20��5=      ���#C8C8C8$	��1.5q�5?      ._�5A      �� .+�5B      �� $	��395��5C   !   $	��Top=�5D   !   $��
ExtraLight"�5E   !   $��
Montserrat)�5F   !   $��Normal$�5G   !   $��30(�5H   !   $��Center=�5I   !   $��Transacción Realizada��5J   !   5K      �� 5M       �� Orientation$ 
Horizontal=�6)   $��
120 20 0 0q�6B   .+�5N   "   �� $��18 0 0 0q�5O   %   $��
ExtraLight"�5P   %   $��
Montserrat)�5Q   %   $��Normal$�5R   %   $��20(�5S   %   $��Vuelto:��5T   %   5U   #   �� 5V   "   -   5        	 ��Name$	 lbVueltoParaEntregar��5W   %   $	��Top=�5X   %   $��2 0 0 0q�5Y   %   $��
ExtraLight"�5Z   %   $��
Montserrat)�5[   %   $��Normal$�5\   %   $��20(�5]   %   $��0��5^   %   5_   #   5`      �� 5b      $��0 20 0 0q�5c   !   $��
ExtraLight"�5d   !   $��
Montserrat)�5e   !   $��Normal$�5f   !   $��15(�5g   !   $��Center=�5h   !   $-��'Recuerde entregar el vuelto al cliente.��5i   !   5j      �� 5m      $ 
Horizontal=�6)   $��Center=�6B   $��0 20 0 0q�6_   .+�5n   "   �� -   5        
 ��Name$
 btnConfirmacionFinal��5n   )      BotonOpciones#��[  6j   $	��180��6�   $��45��6�   $��0 0 20 0q�6�   .��5o   &   �� $ 
Horizontal=�61   .+�5p   *   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ CircleCheck=�67     BotonOpcionesIcono#��[ 6J   $��20��6v   $��20��6�   �� 5q   *   $��	Confirmar��64     BotonOpcionesTexto#��[ 6E   5r   '   5s   #   5t      5u      5x      5z      5{      5|      5}      5~      