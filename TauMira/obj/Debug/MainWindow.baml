   M S B A M L   `   `   `  ����B  >TauMira, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TauMiraTauMira  5   	   5clr-namespace:TauMira.UserCtrlsTauMira.UserCtrls  5   	       TauMira.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TauMira     5   	   5	UserCtrlsclr-namespace:TauMira.UserCtrls     5   	   -   5          � Title$  
MainWindow��5	   	   $
��1080��6   $
��1920��6*    � WindowStartupLocation$ CenterScreen=�67    � WindowStyle$ SingleBorderWindow=�6\    � WindowState$ 	Maximized=�5
   	      CustomWindowStyle#���   5   	    � Icon$ /Group 193@2x.png��65   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#EBEBEB$��56��61   .+�5      o�   MainMenuTheme#���  6   
���  ��.@�5      m� $
��File��6   $��16(�6)   $��
Montserrat)�67   $��Medium"�6O   ���#264B80.@�5      m� $��Option 1��6   {�.  61   m� 5      $��Option 2��6   {�.  61   m� 5      $��Option 3��6   {�.  61   �� 5      	 �� X1$ -5��6   	 �� Y1$ 10��6#   	 �� X2$	 100��5      		 �� Y2$	 10��6$   ���#C7C7C7$	��1.5��6=   {�.  6S   m� 5      -   5        $��
Import XML��5      {�. 6K   5      m� 5      $��Add Segmant��6   $��16(�60   $��
Montserrat)�6>   $��Medium"�6V   ���#264B80.@�5      m� $��
Individual��6   .@�5      m� $��Add AddressHistory��6$   m� 5       $��Add ID��6#   m� 5!      $��Add Contact��6#   5"      m� 5#      $��CBScore��6   .@�5$      m� -   5        $��Add Negative Event��5$   #   6?   m� 5%      -   5        $��Add Positive Event��5%   #   6?   5&      �� 5'      m� 5(      -   5        $��Add Installment Contract��5(      6A   m� 5)      -   5        $!��Add NonInstallment Contract��5)      6D   m� 5*      -   5        $��Add CreditCard Contract��5*      6@   m� 5+      -   5        $��Add Service Contract��5+      6=   m� 5,      -	   5        $%��Add NegativeEvent/BouncedCheque��5,      6H   5/      50      51      � 52   
   $��1��6   ���#F0F0F0
 � ColumnDefinitions
 53      �� 54      $
��auto �6#   �� 55      $��* �6#   .+�57      � $��0��6   $
��10,0q�6#   ���#F0F0F0 58      �� 59      $
��auto �6$   �� 5:      $��* �6$   .+�5<      � $��0��6   ���#F0F0F0 5=      �� 5>      $
��auto �6(   �� 5?      $
��auto �6(   .+�5A      � $��0��6   ���#F0F0F0.+�5B      ��   LabelStyle1#���  6    $��18(�6F   $
��Left=�6T   $��Select Sections to Add��6o   $
��Bold"�6�   $��
Montserrat)�6�   5C      � 5D      $��1��6   ���#F0F0F0.+�5E      )   #TauMira.UserCtrls.UserControlSearch  5F      5G      � 5H      $��1��6   ���#F0F0F0.+�5I      �� $��Disabled=�6#   $
��Auto=�6L   
������ .��5K      �� -
   5         ��Name$ ItemsControlDomains��5L   /   $
��Left=�5K   Z   $	��0,5q�5L   "   
������ $��0q�5M   "   5N      5~      5      5�      � 5�      $��1��6   ���#FAFAFA 5�      �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      � $��0��6   $��16q�6$   
 5�      �� 5�      $��* �6+   �� 5�      $��* �6+   .+�5�      � $��0��6    5�      �� 5�      $��1* �6,   �� 5�      $��1* �6,   .+�5�      �� $��24(�6    $��0��6.   #���  6;   $
��Left=�6a   $"��Fill in the following fields��6|   $
��Bold"�6�   $��
Montserrat)�6�   �� 5�      $��1��6    #���  6-   $
��Left=�6S   $��18(�6n   $��Medium"�6|   $��
Montserrat)�6�   $4��.You can add new fields from the left side menu��6�   5�      �� 5�      $��1��6    �� CornerRadius$ 10��6-   $��56��6?   $	��200��6K   $��Right=�6W   ���	#FF264B80$��1q�6�   ._�5�      �� -   5        
�������$��20(�5�   4   $��
Export XML��6B   
������ $��4q�6p   $��	32,0,32,0q�6�   $��
Montserrat)�6�   $��SemiBold"�6�   5�      5�      �� 5�      $
��Auto=�6   $��Disabled=�6B   $��1��6k   $��24q�6x   .��5�      �� -   5        $��StackPanelData��5�   !   5�      5�      5�      5�      5�      5�      