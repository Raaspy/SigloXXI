   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CapaPresentacion.CocinaCapaPresentacion.Cocina  5   	   )    #CapaPresentacion.Cocina.PanelCocina   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CapaPresentacion.Cocina     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � Title$  PanelCocina��5	   	   $	��700��6   $
��1200��6*    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ���#E0F2F1._�5   
   � $��5 2 5 2q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��100 �6    �� 5      $��50 �6    �� 5      $��60 �6    �� 5      $��* �6    �� 5      $��65 �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��25 �6#   .+�5!      �� $*��$Restautante Siglo XXI / Panel Cocina��6   $��5,0,0,0q�5"      $��
ExtraLight"�5#      $��Italic$�5$      $��0��5%      $��Center=�5&      $��15(�5'      5(      �� 5)      -   5         ��Name$ btnMaximizarWin��5)      $��0q�5*      $��Right=�5+      $	��❐��5,      
���   �$��16(�5.      	 � Cursor$
	 Hand��5/      $��3��50      ��54      �� 55      
 �� 
TargetType"
 ��6   .�56      ��  �� Property � �� �� Value �#e0f2f167    �� Triggers 57      P� 58       P� Property �@J�IsMouseOver P� Value . . �59   "   ��  � �� �#B5DEDA6?   5:      5<      ��5@      �� 5A       �� 
TargetType" ��6&   .R�5B      �� $��20��6!   $��20��6,   $ 8��5C   !   #��z��5D   !   ._�5E      �� $��Center=�6/   $��Center=�5F   /   5H      5I      5K      �� 5L      -   5        $ btnMinimizarWin��5L      $��0q�5M      $��-��5N      
���   �$��16(�5P      $
	 Hand��5Q      $��4��5R      ��5V      �� 5W      "
 ��6   .�5X      ��  � �� �#e0f2f167    5Y      P� 5Z       �@J�IsMouseOver . . �5[   "   ��  � �� �#B5DEDA6?   5\      5^      ��5b      �� 5c      " ��6&   .R�5d      �� $��20��6!   $��20��6,   $ 8��5e   !   #��z��5f   !   ._�5g      �� $��Center=�6/   $��Center=�5h   /   5j      5k      5m      � 5p      $��1��6    5q      �� 5r      $	��260 �6'   �� 5s      $��* �6'   .+�5v      �� $��0��6   $��/Imagenes/Logo.png��6(   5w      � 5z      $��2��6   $��1��6    $��2��60   .+�5{      �� $��Pedido Seleccionado��6   $��SemiBold"�5|      $��
Montserrat)�5}      $��Italic$�5~      $��35(�5      $��Center=�5�      5�      �� 5�      $��3��6   $��0��6"   $��4��62   $��100 0 100 10q�5�      $ 20��5�      ���#C8C8C8$	��1.5q�5�      ._�5�      ��  �� Orientation$ 
Horizontal=�6   $��3��66   $��Center=�6J   $��Center=�6e   .+�5�      �� $ 
Horizontal=�6!   .+�5�      �� $��	Cantidad:��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      $
��Left=�5�      �� 5�      -   5         ��Name$ 
lbCantidad��5�      $��0��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      5�      �� 5�      $ 
Horizontal=�6!   $��
50 0 150 0q�6:   .+�5�      �� $��Nombre Platillo:��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      $
��Left=�5�      �� 5�      -   5        $ lbNombrePlatillo��5�      $��No Definido��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      5�      �� 5�      $ 
Horizontal=�6!   $��	0 0 100 0q�6:   .+�5�      �� $��Estado Cocina:��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      $
��Left=�5�      �� 5�      -   5        $ lbEstadoCocina��5�      $��No Definido��5�      $��
ExtraLight"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      5�      5�      5�      �� 5�      $��4��6   $��4��6&   $��0 38 0 0q�66   .+�5�      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 	ChevronUp=�6   $��16��60   $��16��6;     5�      $ Mouse=�6   $��18��6,   $��18��67     5�      $ ChevronDown=�6   $��16��62   $��16��6=   5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ DataGridPanelCocina��5�         DataGridCellStyle1   	CellStyle# �   5�      $��0��5�      $��4��5�      $��5��5�      $��	25 5 25 5q�5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�         AutoGenerateColumns .  $��25(�5�         CanUserAddRows .     
IsReadOnly . "   VerticalScrollBarVisibility$ Hidden=�5�      ��5�      ��    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Cantidad��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *cantidad_carrito+6`     5�      $ Nombre Platillo��6)   $ * 6f    6B   �� *nombre_producto+6f     5�      $
 Mesa��6)   $	 100 6W    67   �� *numero_mesa+6W     5�      $ Estado Cocina��6)   $	 200 6b    6@   �� *estado_cocina+6b     5�      $ Estado Garzón��6)   $	 200 6b    6@   �� *estado_garzon+6b   5�      �� 5�      $��5��6   $��0��6&   $��2��66   $ 
Horizontal=�6J   $��Center=�6c   $
��Left=�6~   $��25 0 0 0q�6�   .+�5�      �� $��Actualización en:��5�      $��SemiBold"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      $
��Left=�5�      �� 5�      -   5        $ lbContadorActualizacion��5�      $��5��5�      $��SemiBold"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      �� 5�      $��Segundos��5�      $��SemiBold"�5�      $��
Montserrat)�5�      $��Italic$�5�      $��20(�5�      5�      � 5�      $��1��6   $��5��6#   $��2��60   .+�5      �� -	   5        $ btnConfirmarPedidoCocina��5        BotonOpciones#��[ 6b   $	��220��6�   $��50��6�   .��5     �� $ 
Horizontal=�6!   .+�5       $ CircleCheck=�6'     BotonOpcionesIcono#��[ 6:   $��20��6f   $��20��6r   �� 5     $��Confirmar Pedido��6$     BotonOpcionesTexto#��[ 6<   $��18(�6h   5     5     5     � 5	     $��3��6   $��5��6#   .+�5
     �� -
   5        $ btnVolverAtras��5
     #��[ 6N   $	��180��6u   $��50��6�   $��Right=�6�   .��5     �� $ 
Horizontal=�6!   .+�5       $ ChevronLeft=�6'   #��[ 6:   $��20��6f   $��20��6r   �� 5     $��Volver Atrás��6$   #��[ 68   $��18(�6d   5     5     5     5     5     5     