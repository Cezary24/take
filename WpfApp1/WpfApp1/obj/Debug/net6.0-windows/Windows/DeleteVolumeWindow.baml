   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   (    "Library.Windows.DeleteVolumeWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Deleting volume��5	   	   $	��228��6!   $	��498��6.   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0,10,0,0q�6   .+�5      �� $��Center=�6   $��16(�61   $��Delete volume��6?   5      � 5   
   $��1��6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6   $��0,10,0,0q�6     � ColumnDefinitions 5      �� 5      $	��100 �6'    z� SharedSizeGroup$ Label��63   �� 5      $��* �6'   �� 5       $
��Auto �6'   .+�5#      �� $��0��6   $��Volume��6(   $��	10,0,10,0q�69   $��Right=�6L   �� 5$      -   5        $��	CbVolumes��5$   +   $��1��6   $��0,0,5,0q�6<   6M   5%      � 5)      $��1��6   $��10,10,-10,0q�6     J� RenderTransformOrigin$ 0.355,0.517&�65    5*      �� 5+      $��91 �6'   $ Label��62   �� 5,      50      51      � 53   
   $��2��6   $��	0,20,10,0q�6   $��Right=�6/    54      �� 55      $
��Auto �6#   �� 56      $
��Auto �6#   .+�58      �� -   5        $��	BtnCancel��58   %   $��0��6   $��Cancel��66    � Cursor$
 Hand��6G   $��50��6U   $��10q�6c   $��Right=�6o   $��Bottom=�6�   6�   �� 59      -   5        $��BtnSave��59   %   $��1��6   ${�false��64   $
��Save��6F   $
 Hand��6U   $��50��6c   
������$��10q�6�   $��Right=�6�   $��Bottom=�6�   6�   5:      5;      5<      