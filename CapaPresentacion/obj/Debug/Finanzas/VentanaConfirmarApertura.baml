   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CapaPresentacion.FinanzasCapaPresentacion.Finanzas  5   	   8    2CapaPresentacion.Finanzas.VentanaConfirmarApertura   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CapaPresentacion.Finanzas     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  VentanaConfirmarApertura��5	   	   $	��700��6*   $
��1200��67    � WindowStyle$
 None=�6D    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   
������ ._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��70 �6    �� 5      $��* �6    �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��25 �6#   .+�5      �� $ 10��5       ���#48A999$��0��5"      $��3��5#      $��3��5$      $��2��5%      $��3q�5&      ���#E0F2F1$	��360��5(      $	��582��5)      $	��Top=�5*      $��Right=�5+      ._�5-      � $��5 2 5 2q�6    5.      �� 5/      $��30 �6(   �� 50      $��* �6(   �� 51      $��25 �6(    53      �� 54      $��25 �6+   �� 55      $��50 �6+   �� 56      $��* �6+   �� 57      $��50 �6+   �� 58      $��25 �6+   .+�5<      �� $��2��6   $��1��6-   $ 20��5=      ���#C8C8C8$	��1.5q�5?      ._�5A      �� .+�5B      �� $	��395��5C   !   $��50��5D   !   $	��Top=�5E   !   $��0 20 0 0q�5F   !   $��
ExtraLight"�5G   !   $��
Montserrat)�5H   !   $��Normal$�5I   !   $��15(�5J   !   $
��Wrap=�5K   !   $S��MEstás a punto de iniciar una apertura de caja con la siguiente información:��5L   !   5M      �� 5O       �� Orientation$ 
Horizontal=�6)   .+�5P   "   �� $��18 0 0 0q�5Q   %   $��
ExtraLight"�5R   %   $��
Montserrat)�5S   %   $��Normal$�5T   %   $��15(�5U   %   $��Nombre Cajero:��5V   %   5W   #   �� 5X   "   -   5        	 ��Name$	 lbNombreCajero��5Y   %   $	��Top=�5Z   %   $��2 0 0 0q�5[   %   $��
ExtraLight"�5\   %   $��
Montserrat)�5]   %   $��Normal$�5^   %   $��15(�5_   %   $��No Conocido��5`   %   5a   #   5b      �� 5c      $ 
Horizontal=�6)   .+�5d   "   �� $	��Top=�5e   %   $��18 0 0 0q�5f   %   $��
ExtraLight"�5g   %   $��
Montserrat)�5h   %   $��Normal$�5i   %   $��15(�5j   %   $��Monto Inicial:��5k   %   5l   #   �� 5m   "   -   5        $	 lbMontoInicial��5n   %   $	��Top=�5o   %   $��18 0 0 0q�5p   %   $��
ExtraLight"�5q   %   $��
Montserrat)�5r   %   $��Normal$�5s   %   $��15(�5t   %   $��No Conocido��5u   %   5v   #   5w      �� 5x      $ 
Horizontal=�6)   .+�5y   "   �� $	��Top=�5z   %   $��18 0 0 0q�5{   %   $��
ExtraLight"�5|   %   $��
Montserrat)�5}   %   $��Normal$�5~   %   $��15(�5   %   $��Fecha Apertura:��5�   %   5�   #   �� 5�   "   -   5        $	 lbFechaApertura��5�   %   $	��Top=�5�   %   $��2 0 0 0q�5�   %   $��
ExtraLight"�5�   %   $��
Montserrat)�5�   %   $��Normal$�5�   %   $��15(�5�   %   $��No Conocido��5�   %   5�   #   5�      �� 5�      $��	18 20 0 0q�5�   !   $��
ExtraLight"�5�   !   $��
Montserrat)�5�   !   $��Normal$�5�   !   $��15(�5�   !   $��Center=�5�   !   $4��.¿Está seguro de iniciar la apertura de caja?��5�   !   5�      �� 5�      $ 
Horizontal=�6)   $��Center=�6B   $��0 20 0 0q�6_   .+�5�   "   �� -   5        
 ��Name$
 btnRealizarApertura��5�   )      BotonOpciones#��[  6h   $	��180��6�   $��45��6�   $��0 0 20 0q�6�   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ CircleCheck=�67     BotonOpcionesIcono#��[ 6J   $��20��6v   $��20��6�   �� 5�   *   $��Realizar Apertura��64     BotonOpcionesTexto#��[ 6M   5�   '   5�   #   �� 5�   "   -   5        $
 btnCancelarApertura��5�   )     BotonEliminar#��[ 6h   $	��180��6�   $��45��6�   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *     $ CircleXmark=�67   #��[ 6J   $��20��6v   $��20��6�   �� 5�   *   $��Cancelar Apertura��64   #��[ 6M   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      