   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CapaPresentacion.AdministradorCapaPresentacion.Administrador  5   	   1    +CapaPresentacion.Administrador.CrudUsuarios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   8local,clr-namespace:CapaPresentacion.Administrador  5   	   -   5          � Title$  CrudUsuarios��5	   	   $	��700��6   $
��1200��6+    � WindowStyle$
 None=�68    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ���#e0f2f1._�5   
   � $��5,2,5,2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $	��120 �6    �� 5      $��* �6    �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $	��300 �6#   �� 5      $	��300 �6#   �� 5      $	��300 �6#   �� 5      $��* �6#   �� 5      $��25 �6#   .+�5"      �� $+��%Restautante Siglo XXI / Crud Usuarios��6   $��5,0,0,0q�5#      $��
ExtraLight"�5$      $��Italic$�5%      $��0��5&      $��Center=�5'      $��15(�5(      5)      �� 5*      -   5         ��Name$ btnMinimizarWin��5*      $��0q�5+      $��-��5,      
���   �$��16(�5.      	 � Cursor$
	 Hand��5/      $��4��50      ��54      �� 55      
 �� 
TargetType"
 ��6   .�56      ��  �� Property � �� �� Value �#e0f2f167    �� Triggers 57      P� 58       P� Property �@J�IsMouseOver P� Value . . �59   "   ��  � �� �#B5DEDA6?   5:      5<      ��5@      �� 5A       �� 
TargetType" ��6&   .R�5B      �� $��20��6!   $��20��6,   $ 8��5C   !   #��z��5D   !   ._�5E      �� $��Center=�6/   $��Center=�5F   /   5H      5I      5K      � 5N      $��1��6    5O      �� 5P      $	��260 �6'   �� 5Q      $��* �6'   .+�5T      �� $��0��6   $��/Imagenes/Logo.png��6(   5U      �� 5X      $��3��6   $��4��6&   $��0 38 0 0q�66   .+�5Y      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 	ChevronUp=�6   $��16��60   $��16��6;     5Z      $ Mouse=�6   $��18��6,   $��18��67     5[      $ ChevronDown=�6   $��16��62   $��16��6=   5\      �� 5_      $��2��6   $��2��6%   $��	140 3 0 3q�5`      $��2��5a      $ 20��5b      ���#C8C8C8$	��1.5q�5d      ._�5f      �� $��2��6   $��2��6*   $��2��6:   $��Center=�6N   $��Center=�6k   .+�5g      ��  �� Orientation$ 
Horizontal=�6!   .+�5i      �� -   5        $ btnAgregarUsuario��5i   !      BotonOpciones#��[  6\   $��0,0,5,0q�6�   $	��200��6�   .��5j      �� $ 
Horizontal=�6)   .+�5k   "     $ 
FloppyDisk=�6/     BotonOpcionesIcono#��[ 6A   �� 5l   "   $��Guardar Usuario��6,     BotonOpcionesTexto#��[ 6C   5m      5n      �� 5q      -   5        $ btnActualizarUsuario��5q   !   #��[  6b   $	��200��6�   .��5r      �� $ 
Horizontal=�6)   .+�5s   "     $ ArrowRotateLeft=�6/   #��[ 6F   �� 5t   "   $��Actualizar Usuario��6,   #��[ 6F   5u      5v      5w      �� 5y      $ 
Horizontal=�6!   $��Center=�6:   5{      5|      5}      �� 5�      $��2��6   $��3��6"   $��
25 3 170 3q�5�      $ 20��5�      ���#C8C8C8$	��1.5q�5�      ._�5�      �� $ 
Horizontal=�6   $��3��66   $��25 0 0 0q�6J   .+�5�      �� $��0 0 25 0q�6!   .+�5�      �� $ 
Horizontal=�6%   $��0,15,0,0q�6>   .+�5�      �� $��Id Usuario:��6$   $��
ExtraLight"�5�       $��
Montserrat)�5�       $��Italic$�5�       $��15(�5�       $
��Left=�5�       �� 5�      -   5         ��Name$ lbIdUsuario��5�   $   $��0��5�   !   $��
ExtraLight"�5�   !   $��0,0,80,0q�5�   !   $��
Montserrat)�5�   !   $��Italic$�5�   !   $��15(�5�   !   $��Center=�5�   !   5�      �� 5�      $��Nombre del Usuario��6    $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 9 0 0q�5�      $
��Left=�5�      �� 5�      -   5         ��Name$ tbNombreUsuario��5�   "   $	��200��5�      $��20��5�      $
��Left=�5�      
������  �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      5�      �� 5�      $��0 0 25 0q�6!   .+�5�      �� $��Contraseña��6    $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 2 0 0q�5�      $
��Left=�5�      �� 5�      -   5        $ tbContraseniaUsuario��5�   "   $	��200��5�      $��20��5�      $
��Left=�5�      
������ 
 �����
�������$��0,0,0,2q�5�      �� 5�      $��Correo del Usuario��6    $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 2 0 0q�5�      $
��Left=�5�      �� 5�      -   5        $ tbCorreoUsuario��5�   "   $	��200��5�      $��20��5�      $
��Left=�5�      
������ 
 �����
�������$��0,0,0,2q�5�      5�      �� 5�      .+�5�      �� $��Rol del Usuario��6    $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 2 0 0q�5�      $
��Left=�5�      �� 5�      -	   5         ��Name$ cbRolesDeUsuarios��5�   #     ComboBoxItemContainerStyle1#���  6>   $	��200��5�      $��28��5�      $
��Left=�5�      .@�5�      �� .��5�   "   �� $��Administrador��6,   $��14(�6A   $��
ExtraLight"�6O   $��
Montserrat)�6g   $��Italic$�6   5�      �� 5�      .��5�   "   �� $��Bodega��6,   $��14(�6:   $��
ExtraLight"�6H   $��
Montserrat)�6`   $��Italic$�6x   5�      �� 5�      .��5�   "   �� $��Cocina��6,   $��14(�6:   $��
ExtraLight"�6H   $��
Montserrat)�6`   $��Italic$�6x   5�      �� 5�      .��5�   "   �� $��Finanzas��6,   $��14(�6<   $��
ExtraLight"�6J   $��
Montserrat)�6b   $��Italic$�6z   5�      5�      �� 5�      $��Estado Usuario��6    $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��15(�5�      $��0 2 0 0q�5�      $
��Left=�5�      �� 5�      $ 
Horizontal=�6%   .+�5�      	� -
   5         	�Name$ rbUsuarioActivo��5�   =    	� 	GroupName$ Estado��6*   $��Activo��6V   	� 5�      -   5        $ rbUsuarioInactivo��5�   =   $ Estado��6*   $��20 0 0 0q�6X   $��Inactivo��6j   5�      5�      5�      5�      �� 5      $��0��6   $��4��6%   $��4��5     $��25,0,5,0q�5     $��60��5     $ 20��5     ���#C8C8C8$	��1.5q�5     ._�5	     � $��1��6   $��3��6'    5
      5     �� 5     $��70 �6+   �� 5     $��* �6+   �� 5     $��* �6+   �� 5     $��* �6+   �� 5     $��* �6+   �� 5     $��2 �6+   �� 5     $��* �6+   .+�5     � $��0��6   $��5��6(   ���#C8C8C8$��0,4,0,4q�6M   � 5     $��0��6   $��0��6(   .+�5       $
 Bars=�6'   $��35��63   5     � 5      $��0��6   $��1��6(   .+�5!     �� -   5        $ btnVentanaSuministros��5!  !   #��[  6d   $	��180��6�   $��45��6�   .��5"     �� $ 
Horizontal=�6)   .+�5#  "     $ BoxesStacked=�6/   #��[ 6C   $��20��6o   $��20��6{   �� 5$  "   $��Insumos��6,   #��[ 6;   $��18(�6g   5%     5&     5'     � 5*     $��0��6   $��2��6(   .+�5+     �� -   5        $ btnVentanaProveedores��5+  !   #��[  6d   $	��180��6�   $��45��6�   .��5,     �� $ 
Horizontal=�6)   .+�5-  "     $ Dolly=�6/   #��[ 6<   $��20��6h   $��20��6t   �� 5.  "   $��Proveedores��6,   #��[ 6?   $��18(�6k   5/     50     51     � 54     $��0��6   $��3��6(   .+�55     �� -   5        $ btnVentanaProductos��55  !   #��[  6`   $	��180��6�   $��45��6�   .��56     �� $ 
Horizontal=�6)   .+�57  "     $ BowlFood=�6/   #��[ 6?   $��20��6k   $��20��6w   �� 58  "   $��	Productos��6,   #��[ 6=   $��18(�6i   59     5:     5;     � 5>     $��0��6   $��4��6(   .+�5?     �� -   5        $ btnVentanaClientes��5?  !   #��[  6^   $	��180��6�   $��45��6�   .��5@     �� $ 
Horizontal=�6)   .+�5A  "     $ Users=�6/   #��[ 6<   $��20��6h   $��20��6t   �� 5B  "   $��Clientes��6,   #��[ 6<   $��18(�6h   5C     5D     5E     � 5H     $��0��6   $��6��6(   .+�5I     �� -   5        $ btnVolverAtras��5I  !   #��[  6V   $	��180��6}   $��45��6�   .��5J     �� $ 
Horizontal=�6)   .+�5K  "     $ ChevronLeft=�6/   #��[ 6B   $��20��6n   $��20��6z   �� 5L  "   $��Volver Atrás��6,   #��[ 6@   $��18(�6l   5M     5N     5O     5P     5Q     &   System.Windows.Controls.DataGrid  5T     -   5          Name$ DataGridUsuarios��5[       DataGridCellStyle1   	CellStyle# �  5U     $��0��5V     $��3��5W     $��5��5X     $��	25 5 25 5q�5Y       DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5Z        AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . "   VerticalScrollBarVisibility$ Hidden=�5`     ��5\     ��     Columns  5b     0  *System.Windows.Controls.DataGridTextColumn  5c     ,  &System.Windows.Controls.DataGridColumn!   Header$! ID��6)   "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 50 6T   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 65   �� *
id_usuario+6T     5d     $! Nombre��6)   $" * 6\   # 69   �� *nombre_usuario+6\     5e     $! Contraseña��6)   $" * 6e   # 6=   �� *contrasenia_usuario+6e     5f     $! Correo��6)   $" * 6\   # 69   �� *correo_usuario+6\     5g     $! Rol de Usuario��6)   $" * 6a   # 6A   �� *rol_usuario+6a     5h     $! Estado��6)   $" * 6`   # 69   �� *estado_tipousuario+6`   5j     5k     5l     5m     