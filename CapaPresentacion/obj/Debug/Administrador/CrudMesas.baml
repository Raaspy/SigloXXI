   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CapaPresentacion.AdministradorCapaPresentacion.Administrador  5   	   .    (CapaPresentacion.Administrador.CrudMesas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CapaPresentacion.Administrador     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  	CrudMesas��5	   	   $	��700��6   $
��1200��6(    � WindowStyle$
 None=�65    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��40 �6    �� 5      �� 5      $��70 �6     � ColumnDefinitions 5      �� 5      �� 5      $	��300 �6#   �� 5      $��25 �6#   .+�5      �� $ 10��5      ���#48A999$��0��5       $��3��5!      $��10 0 0 0q�5"      $��3q�5#      ���#E0F2F1$	��456��5%      $	��855��5&      $	��Top=�5'      $��Right=�5(      ._�5*      � $��5 2 5 2q�6    5+      �� 5,      $��30 �6(   �� 5-      $��* �6(   �� 5.      $��25 �6(    50      �� 51      $��25 �6+   �� 52      $	��320 �6+   �� 53      $��20 �6+   �� 54      $��* �6+   �� 55      $��25 �6+   .+�59      �� -   5         ��Name$ btnCerrarVentana��59      $��0q�5:      $��x��5;      
���   �$��16(�5=      	 � Cursor$
	 Hand��5>      $��4��5?      ��5C      �� 5D      
 �� 
TargetType"
 ��6$   .�5E   "   ��  �� Property � �� �� Value �#e0f2f16?    �� Triggers 5F   "   P� 5G   &    P� Property �@J�IsMouseOver P� Value . . �5H   *   ��  � �� �#B5DEDA6G   5I   '   5K      ��5O      �� 5P       �� 
TargetType" ��6.   .R�5Q   "   �� $��20��6)   $��20��64   $ 8��5R      #��z��5S      ._�5T   &   �� $��Center=�67   $��Center=�5U   -   5W   #   5X      5Z      �� 5]      $��1��6   $��1��6-   $��10q�5^      $	��285��5_      $ 20��5`      ���#C8C8C8$	��1.5q�5b      ._�5d      �� .+�5f      ��  �� Orientation$ 
Horizontal=�6)   $��0,10,0,0q�6B   .+�5g   "   �� $��Id Proveedor:��6(   $��10,0,0,0q�5h   $   $��
ExtraLight"�5i   $   $��
Montserrat)�5j   $   $��Italic$�5k   $   $��15(�5l   $   $
��Left=�5m   $   �� 5o   "   -   5         ��Name$ lbIdMesa��5o   (   $��0��5p   %   $��
ExtraLight"�5q   %   $��0,0,80,0q�5r   %   $��
Montserrat)�5s   %   $��Italic$�5t   %   $��15(�5u   %   $��Center=�5v   %   5w      �� 5z      $��N° Mesa��6$   $��10,5,0,0q�5{   !   $��
ExtraLight"�5|   !   $��
Montserrat)�5}   !   $��Italic$�5~   !   $��15(�5   !   $
��Left=�5�   !   �� 5�      -   5         ��Name$ tbnumeroMesa��5�   &   $��15,0,0,5q�5�   !   $	��250��5�   !   $��25��5�   !    �� SelectedText$ 0��5�   !   $
��Left=�5�   !   
������  �� 
CaretBrush
 �����
�������$��0,0,0,2q�5�   !   �� 5�      $��Estado Mesa��6$   $��
ExtraLight"�5�   !   $��
Montserrat)�5�   !   $��Italic$�5�   !   $��15(�5�   !   $��10,5,0,0q�5�   !   $
��Left=�5�   !   �� 5�      $ 
Horizontal=�6)   $��15,5,0,0q�6B   .+�5�   "   	� -   5         	�Name$ rbMesaDisponible��5�   A    	� 	GroupName$ Estado��6.   $��
Disponible��6[   	� 5�   "   -   5        $ rbMesaNoDisponible��5�   A   $ Estado��6.   $��20 0 0 0q�6]   $��No Disponible��6o   5�      �� 5�      $��	5,20,5,15q�6%   ���#C8C8C8$��1q�6N   6d   �� 5�      -   5        $ btnAgregarMesa��5�   %      BotonOpciones#��[  6Z   $��0,10,0,0q�6�   .��5�   "   �� $ 
Horizontal=�6-   .+�5�   &   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 
FloppyDisk=�63     BotonOpcionesIcono#��[ 6E   �� 5�   &   $��Guardar Mesa��60     BotonOpcionesTexto#��[ 6D   5�   #   5�      �� 5�      -   5        $ btnActualizarMesa��5�   %   #��[  6`   $��0,10,0,0q�6�   .��5�   "   �� $ 
Horizontal=�6-   .+�5�   &     $ ArrowRotateLeft=�63   #��[ 6J   �� 5�   &   $��Actualizar Mesa��60   #��[ 6G   5�   #   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -	   5          Name$ DataGridMesas��5�        DataGridCellStyle1   	CellStyle# �  5�      $��3��5�      $��1��5�      $��10q�5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . "   VerticalScrollBarVisibility$ Hidden=�5�      ��5�      ��     Columns  5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn!   Header$! ID��61   "   Width5  /System.Windows.Controls.DataGridLengthConverter$" 50 6Y   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 6=   �� *	id_mesa+6Y     5�      $! N° Mesa��61   $" * 6b   # 6B   �� *numero_mesa+6b     5�      $! Estado��61   $" * 6e   # 6A   �� *mesa_disponible+6e   5�      5�      5�      5�      5�      5�      