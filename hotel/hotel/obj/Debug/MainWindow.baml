   M S B A M L   `   `   `  ����@  <hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:hotelhotel  5   	       hotel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:hotel     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��328��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��155* �6   �� 5      $
��137* �6    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6>   $��30(�6Y   $��2��6g   $��104,11,103,11q�6{   
Меню6�   �� 5   
   -   5         ��Name$ 	new_guest��5      $��1��6'   $��20(�64   $��10q�6B    �� TextAlignment$ Center=�6N   
�������$��2��6�   -+Зарегестрировать гостя6  �� 5   
   -   5        $ minus_guest��5      $��2��6)   $��20(�66   $��10q�6D   $ Center=�6P   $��2��6�   Выселение6�   �� 5   
   -   5        $ maybe_guest��5      $��3��6)   $��20(�66   $��10q�6D   $ Center=�6P   $��2��6�   Бронирование6�   �� 5   
   -   5        $ 	all_guest��5      $��4��6'   $��20(�64   $��10q�6B   $ Center=�6N   $��2��6�   Список гостей6�   �� 5   
   -   5        $
 time��5      $��5��6"   $��Center=�6/   $��Center=�6L   $��16(�6g   $��2��6u   $��103,20,102,19q�6�   Время/Дата6�   5      5       