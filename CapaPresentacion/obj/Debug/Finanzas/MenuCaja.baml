   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CapaPresentacion.FinanzasCapaPresentacion.Finanzas  5   	   (    "CapaPresentacion.Finanzas.MenuCaja   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CapaPresentacion.Finanzas     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  MenuCaja��5	   	   $	��700��6   $
��1200��6'    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ���#E0F2F1._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��70 �6    �� 5      $��* �6    �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��25 �6#   .+�5       �� $(��"Restautante Siglo XXI / Menú Caja��6   $��5,0,0,0q�5!      $��
ExtraLight"�5"      $��Italic$�5#      $��0��5$      $��Center=�5%      $��15(�5&      5'      �� 5(      -   5         ��Name$ btnMaximizarWin��5(      $��0q�5)      $��Right=�5*      $	��❐��5+      
���   �$��16(�5-      	 � Cursor$
	 Hand��5.      $��3��5/      ��53      �� 54      
 �� 
TargetType"
 ��6   .�55      ��  �� Property � �� �� Value �#e0f2f167    �� Triggers 56      P� 57       P� Property �@J�IsMouseOver P� Value . . �58   "   ��  � �� �#B5DEDA6?   59      5;      ��5?      �� 5@       �� 
TargetType" ��6&   .R�5A      �� $��20��6!   $��20��6,   $ 8��5B   !   #��z��5C   !   ._�5D      �� $��Center=�6/   $��Center=�5E   /   5G      5H      5J      �� 5K      -   5        $ btnMinimizarWin��5K      $��0q�5L      $��-��5M      
���   �$��16(�5O      $
	 Hand��5P      $��4��5Q      ��5U      �� 5V      "
 ��6   .�5W      ��  � �� �#e0f2f167    5X      P� 5Y       �@J�IsMouseOver . . �5Z   "   ��  � �� �#B5DEDA6?   5[      5]      ��5a      �� 5b      " ��6&   .R�5c      �� $��20��6!   $��20��6,   $ 8��5d   !   #��z��5e   !   ._�5f      �� $��Center=�6/   $��Center=�5g   /   5i      5j      5l      � 5o      $��1��6    5p      �� 5q      $	��260 �6'   �� 5r      $��* �6'   .+�5u      �� $��0��6   $��/Imagenes/Logo.png��6(   5v      � 5y      $��2��6   $��1��6    $��2��60   .+�5z      �� $��Caja Registradora��6   $��SemiBold"�5{      $��
Montserrat)�5|      $��Italic$�5}      $��40(�5~      $��Center=�5      5�      �� 5�      $��3��6   $��1��6&   $��2��66   $��Center=�6J   $	��250��6g   .+�5�      �� $��Monto Inicial��6   $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 50 0 0q�5�      $��Center=�5�      �� 5�       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5�      �� $��$��6   $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      �� 5�      -   5         ��Name$ tbMontoInicial��5�      $	��160��5�      $��30��5�      $��15(�5�      $��0 0 18 0q�5�      
������  �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      5�      �� 5�      $��Contraseña��6   $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 20 0 0q�5�      $��Center=�5�      G� 5�      -   5         G�Name$ tbContraseniaUsuario��5�      $	��160��5�      $��30��5�      $��0 0 0 35q�5�      $��Center=�5�      
������  G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      �� 5�      -   5         ��Name$ lbNombreCajero��5�      $y�Hidden=�60   $
��name��6D   6U   �� 5�      -   5        $ btnRealizarApertura��5�         BotonOpciones#��[  6X   $	��220��6   $��50��6�   .��5�      �� $ 
Horizontal=�6!   .+�5�      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ CircleCheck=�6'     BotonOpcionesIcono#��[ 6:   $��20��6f   $��20��6r   �� 5�      $��Realizar Apertura��6$     BotonOpcionesTexto#��[ 6=   $��18(�6i   5�      5�      �� 5�      $��¡Importante!��5�      $��Center=�5�      $��
Montserrat)�5�      $��0 30 0 0q�5�      $��15(�5�      6%   �� 5�      $`��ZSolo usuarios asociados con el rol de Finanzas pueden iniciar aperturas y cierres de caja*��5�      $
��Wrap=�5�      $��Center=�5�      $��
Montserrat)�5�      $��15(�5�      5�      5�      � 5�      $��3��6   $��4��6#   .+�5�      �� -   5        $ btnVolverAtras��5�      #��[  6N   $	��180��6u   $��50��6�   $��Center=�6�   .��5�      �� $ 
Horizontal=�6!   .+�5�        $ ChevronLeft=�6'   #��[ 6:   $��20��6f   $��20��6r   �� 5�      $��Volver Atrás��6$   #��[ 68   $��18(�6d   5�      5�      5�      5�      5�      5�      