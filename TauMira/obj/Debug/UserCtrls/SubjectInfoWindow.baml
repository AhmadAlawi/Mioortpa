   M S B A M L   `   `   `  ����B  >TauMira, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TauMira.UserCtrlsTauMira.UserCtrls  5   	   )    #TauMira.UserCtrls.SubjectInfoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TauMira.UserCtrls     5   	     � Title$  SubjectInfoWindow��5   	    � ShowInTaskbar .   � WindowStyle$
 None=�69    � WindowStartupLocation$ CenterScreen=�6L   $	��300��6q   $	��750��6~   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� -   5         ��Name$ MainStackPanel��5   "   $��0��6   5      �� 5      $��2��6   
�������$��Center=�6:   $��1q�6X    �� CornerRadius$ 2��6l   
�������$��40��6�   $��90��6�   ._�5      �� -   5        $��40��5   /   $��90��6;   $��OK��6F   
������ 
������ 6m   5      � 5      $��1��6    5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5      ��    LabelStyleFieldInput#���   6   $��Count��6G   $��Center=�6W   $��0��6t   �� 5      -   5        $��CountTextbox��5   G   $��1��6   $��
15,0,15,15q�6'   $	��200��6;   6G   5      5       5#      