   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   %    Library.Windows.NewReaderWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Library.Windows     5   	     � Title$  Creating new Reader��5   	   $	��257��6%   $	��335��62    � WindowStartupLocation$ CenterScreen=�6>   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   .+�5      �� $��New reader details��6   $��16(�61   $��	0,15,0,15q�6?   $��Center=�6R   5      � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      .+�5      �� $��0��6   $
��Name��6(   $��10q�67   $��Right=�6C   $��Center=�6_   �� 5      -   5        $��TxtName��5   *   $��1��6   $	��200��6O   $��10��6^   $��
26,10,0,10q�6j   $
��Left=�6~   ��69   �� *name+6�   5      � 5      $��1��6    5       �� 5!      $
��Auto �6'   �� 5"      .+�5$      �� $��0��6   $��Surname��6(   $��10q�6:   $��Right=�6F   $��Center=�6b   �� 5%      -   5        $��
TxtSurname��5%   *   $��1��6   $	��200��6U   $��10��6d   $��10q�6p   $
��Left=�6|   ��6<   �� *	surname+6�   5&      5'      � 5(   
   $��2��6   $��Right=�6    5)      �� 5*      $
��Auto �6#   �� 5+      $
��Auto �6#   .+�5-      �� -   5        $��	BtnCancel��5-   %   $��0��6   $��Cancel��66    � Cursor$
 Hand��6G   $��50��6U   $��10q�6c   $��Right=�6o   $��Bottom=�6�   6�   �� 5.      -   5        $��BtnSave��5.   %   $��1��6   ${�false��64   $
��Save��6F   $
 Hand��6U   $��50��6c   
������$��10q�6�   $��Right=�6�   $��Bottom=�6�   6�   5/      50      51      