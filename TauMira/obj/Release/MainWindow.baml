   M S B A M L   `   `   `  ���� B  >TauMira, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TauMiraTauMira  5clr-namespace:TauMira.UserCtrlsTauMira.UserCtrls      TauMira.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:TauMira     5	UserCtrlsclr-namespace:TauMira.UserCtrls     -     � Title$  
MainWindow��$
��1080��$
��1920�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ SingleBorderWindow=� � WindowState$ 	Maximized=�   CustomWindowStyle#���    � Icon$ /Group 193@2x.png��.���  � RowDefinitions �� $
��auto ��� $��* �.+�� $��0�����#EBEBEB$��56��.+�o�   MainMenuTheme#���  
���  ��.@�m� $
��File��$��16(�$��
Montserrat)�$��Medium"����#264B80.@�m� $��Option 1��{�.  m� $��Option 2��{�.  m� $��Option 3��{�.  �� 	 �� X1$ -5��	 �� Y1$ 10��	 �� X2$	 100��		 �� Y2$	 10�����#C7C7C7$	��1.5��{�.  m� -   $��
Import XML��{�.  m� $��Add Segmant��$��16(�$��
Montserrat)�$��Medium"����#264B80.@�m� $��
Individual��.@�m� $��Add AddressHistory��m� $��Add ID��m� $��Add Contact��m� $��CBScore��.@�m� -   $��Add Negative Event��m� -   $��Add Positive Event���� m� -   $��Add Installment Contract��m� -   $!��Add NonInstallment Contract��m� -   $��Add CreditCard Contract��m� -   $��Add Service Contract��m� -	   $%��Add NegativeEvent/BouncedCheque��� $��1�����#F0F0F0
 � ColumnDefinitions
 �� $
��auto ��� $��* �.+�� $��0��$
��10,0q����#F0F0F0 �� $
��auto ��� $��* �.+�� $��0�����#F0F0F0 �� $
��auto ��� $
��auto �.+�� $��0�����#F0F0F0.+���   LabelStyle1#���  $��18(�$
��Left=�$��Select Sections to Add��$
��Bold"�$��
Montserrat)�� $��1�����#F0F0F0.+�)   #TauMira.UserCtrls.UserControlSearch  � $��1�����#F0F0F0.+��� $��Disabled=�$
��Auto=�
������ .���� -
    ��Name$ ItemsControlDomains��$
��Left=�$	��0,5q�
������ $��0q�� $��1�����#FAFAFA �� $
��auto ��� $��* �.+�� $��0��$��16q�
 �� $��* ��� $��* �.+�� $��0�� �� $��1* ��� $��1* �.+��� $��24(�$��0��#���  $
��Left=�$"��Fill in the following fields��$
��Bold"�$��
Montserrat)��� $��1��#���  $
��Left=�$��18(�$��Medium"�$��
Montserrat)�$4��.You can add new fields from the left side menu���� $��1�� �� CornerRadius$ 10��$��56��$	��200��$��Right=����	#FF264B80$��1q�._��� -   
�������$��20(�$��
Export XML��
������ $��4q�$��	32,0,32,0q�$��
Montserrat)�$��SemiBold"��� $
��Auto=�$��Disabled=�$��1��$��24q�.���� -   $��StackPanelData��