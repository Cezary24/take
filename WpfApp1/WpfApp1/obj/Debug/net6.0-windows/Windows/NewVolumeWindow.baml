   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   %    Library.Windows.NewVolumeWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Creating new volume��5	   	   $	��333��6%   $	��398��62   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0,10,0,0q�6   .+�5      �� $��Center=�6   $��16(�61   $��New volume details��6?   5      � 5   
   $��1��6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6   $��0,10,0,0q�6     � ColumnDefinitions 5      �� 5      $	��100 �6'    z� SharedSizeGroup$ Label��63   �� 5       $��* �6'   �� 5!      $
��Auto �6'   .+�5$      �� $��0��6   $��Author��6(   $��	10,0,10,0q�69   $��Right=�6L   �� 5%      -   5         ��Name$ 	TxtAuthor��5%      $��1��6-   $��0,0,20,0q�6=   ��6O   �� *author+6g   5&      � 5(      $��1��6   $��0,10,0,0q�6     5)      �� 5*      $	��100 �6'   $ Label��63   �� 5+      $��* �6'   .+�5.      �� $��0��6   $��
Publ. Date��6(   $��	10,0,10,0q�6=   $��Right=�6P   (  "System.Windows.Controls.DatePicker  5/      -   5          Name$ TxtPublicationDate��5/      $��1��69   $��0,0,20,0q�6I      Text 6[   �� *publicationDate+6|   50      � 52      $��2��6   $��0,10,0,0q�6     53      �� 54      $	��100 �6'   $ Label��63   �� 55      $��* �6'   .+�58      �� $��0��6   $��Publ. House��6(   $��	10,0,10,0q�6>   $��Right=�6Q     59      -   5        $ TxtPublishingHouse��59      $��1��69   $��0,0,20,0q�6I    6[   �� *publishingHouse+6|   5:      � 5>      $��4��6   $��0,10,0,0q�6     5?      �� 5@      $	��100 �6'   $ Label��63   �� 5A      $��* �6'   �� 5B      $
��Auto �6'   .+�5E      �� $��0��6   $��Title��6(   $��	10,0,10,0q�68   $��Right=�6K   �� 5F      -   5         ��Name$ TxtTitle��5F   +   $��1��6   $��0,0,5,0q�6>   	 �� Text	 6O   �� *title+6f   �� 5G      -   5        $��LblNewCompany��5G   (   $��2��6   
 � Cursor$

 Hand��6=   $��SemiBold"�6K   
��� � �$	��New��6t   $��0,0,20,0q�6�   6�   5H      5J      � 5L   
   $��2��6   $��	0,20,10,0q�6   $��Right=�6/    5M      �� 5N      $
��Auto �6#   �� 5O      $
��Auto �6#   .+�5Q      �� -   5        $��	BtnCancel��5Q   %   $��0��6   $��Cancel��66   $

 Hand��6G   $��50��6U   $��10q�6c   $��Right=�6o   $��Bottom=�6�   6�   �� 5R      -   5        $��BtnSave��5R   %   $��1��6   ${�false��64   $
��Save��6F   $

 Hand��6U   $��50��6c   
������$��10q�6�   $��Right=�6�   $��Bottom=�6�   6�   5S      5T      5U      