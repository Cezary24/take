   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Library.ViewsLibrary.Views  5          Library.Views.VolumesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Library.Views     5        N� Title$  Books��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��48 �6   �� 5      $��* �6   .+�5   
   � $��1��5       5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6    5      �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   .+�5$      � $��0��6    � ColumnDefinitions 5%      �� 5&      �� 5'      .+�5*      �� -   5        $'��!LblStudentsWithApprovedInternship��5*   I   $��0��6   $��Center=�6,   6I   �� 5+      -   5        $*��$LblStudentsWithoutApprovedInternship��5+   I   $��1��6   $��Center=�6,   6I   5,      � 5-      $��1��6    5.      �� 5/      �� 50      54      55      � 58      $��1��6   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgVolumes��59         AutoGenerateColumns$ False��6.   $��30,10,30,10q�6J      
IsReadOnly$
 True��6_   $	��220��5:      "   VerticalScrollBarVisibility$
 Auto=�6%   $��2��6H      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Author��6-   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *author+  5=      $ Publication Date ��6-   	 6H   �� *publicationDate+  5>      $ Publishing House ��6-   	 6H   �� *publishingHouse+  5?      $ Rentals��6-   
   MinWidth$	
 100Q�6>   	 6M   �� *	rentals+  5@      $ Title��6-   	 6<   �� *title+5C      5E      � 5F      $��2��6   .+�5G      �� -   5        $��LblAllStudents��5G   5   $��Center=�6   65   5H      � 5I      $��2��6   $��Right=�6    $��	0,5,153,5q�6<   $��2��6O    5J      �� 5K      �� 5L      $
��Auto �6'   �� 5M      $
��Auto �6'   �� 5N      $
��Auto �6'   �� 5O      $
��Auto �6'   .+�5Q      �� -   5        $��BtnNewVolume��5Q   B   $��1��6   $��Add new volume��6)   $��12(�6V   $��SemiBold"�6d    � Cursor$
 Hand��6z   $��10,10,10,10q�6�   6�   �� 5R      -   5        $��BtnAddReval��5R   @   $��2��6   $��Retal volume��6)   $��12(�6T   $��SemiBold"�6b   $
 Hand��6x   $��10,10,10,10q�6�   6�   �� 5S      -   5        $��BtnDeleteVolume��5S   A   $��3��6   $��delete volume��6)   $��12(�6Y   $��SemiBold"�6g   $
 Hand��6}   $��10,10,10,10q�6�   6�   �� 5T      -   5        $��BtnReturnVolume��5T   A   $��4��6   $��return volume��6)   $��12(�6Y   $��SemiBold"�6g   $
 Hand��6}   $��10,10,10,10q�6�   6�   5U      5V      5W      5X      