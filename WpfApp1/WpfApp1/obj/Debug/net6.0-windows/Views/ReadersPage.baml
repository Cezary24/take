   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Library.ViewsLibrary.Views  5          Library.Views.ReadersPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Library.Views     5        N� Title$  Readers��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��48 �6   �� 5      $��* �6   .+�5   
   � $��1��5       5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgReaders��5         AutoGenerateColumns$ False��6.   $��30,10,30,10q�6J      
IsReadOnly$
 True��6_   $	��280��5      "   VerticalScrollBarVisibility$
 Auto=�6%   $��2��6H      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6-      MinWidth$	 100Q�6;   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6J   �� *name+  5"      $ Surname��6-   	 6>   �� *	surname+  5#      $ Rentals��6-   	 6>   �� *	rentals+5&      5(      � 5)      $��1��6   $��Right=�6!   
 � ColumnDefinitions
 5*      �� 5+      �� 5,      $
��Auto �6'   �� 5-      $
��Auto �6'   .+�5/      �� -   5        $��BtnNewOffer��5/   3   $��Add new reader��6   $��12(�6F   $��SemiBold"�6T    � Cursor$
 Hand��6j   $��666,-44,43,64q�6x   $��2��6�   51      52      �� 53   
   $
��Left=�6   $��0��6-   $��	38,46,0,0q�68    �� TextWrapping$
 Wrap=�6K   $��TextBox��6_   $	��Top=�6n   $	��120��6�   �� 54   
   $
��Left=�6   $��
710,10,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��1��6o   �� 6}    � Language$ pl-pl�6�   $�Readers��6�   �� 6�   �� 6�   $ pl-pl�6�   6�   55      56      