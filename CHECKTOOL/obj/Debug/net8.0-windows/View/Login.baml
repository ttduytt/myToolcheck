   M S B A M L   `   `   `  ����D  @CHECKTOOL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CHECKTOOL.ViewCHECKTOOL.View  5      9!clr-namespace:CHECKTOOL.ViewModelCHECKTOOL.ViewModel  69       CHECKTOOL.View.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CHECKTOOL.View     5      7	viewmodel!clr-namespace:CHECKTOOL.ViewModel     69     � Title$  Login��5	      $	��400��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�5
       � 
ResizeMode$ NoResize=�5       � WindowStyle$
 None=�5      
������  � AllowsTransparency$
 True��5      .��5      � 
������ .+�5      �� 
������� �� CornerRadius$ 6��5      ._�5   
   ��  �� Orientation$ Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5       �� Padding$ 10q�5      � 5      $��Center=�6    � RowDefinitions 5      �� 5       $��* �6(   �� 5!      $��* �6(   �� 5"      $��* �6(   �� 5#      $��* �6(   .+�5%      �� $��UserName��5&      $��0��5'      $
��0,15q�5(      $
��Left=�5)      �� 5*      $��1��6   $��1��5+      $	��0,5q�5,      $	��255��5-      $��0,0,0,1q�5/      $
��Left=�50      ��5.      �� *
Username+	 �� UpdateSourceTrigger$	 PropertyChanged=�50      �� 52      $��Password��6   $��2��53      $
��0,15q�54      $
��Left=�55      G� 56      -   5        
 G�Name$
 passwordBox��56   "   $��3��67   $	��0,5q�57      $	��255��58      $��0,0,0,1q�59      $
��Left=�5:      5;      �� 5<      $��forgot password?��6   $��Right=�5=      �� 5>      -   5         ��Name$ LoginBtn��5>      $��Login��5@   	   $	��250��5B   	   $��35��5C   	   $
��0,25q�5D   	   ��5A   	   �� *LoginCommand+��5E      �� 5F       �� 
TargetType" ��6    .�5G      ��  �� Property � �� �� Value
 �   �6;   �� 5H       � ��
 �����6;   �� 5I       � ��$
 Bold"�6;   �� 5J       � ��$
 10,5q�68   �� 5K       � ��$ 0q�6@   �� 5L       �@�Cursor$
 Hand��67   �� 5M       � �� 5N   "   �� 5O   &    �� 
TargetType" ��66   .R�5P   *   ��  ��Name$ border��61   #��z��5Q   !   $ 16��5R   !   ._�5S   .   �� $��Center=�5T   !   $��Center=�5U   !   $
��True��5V   !   #��z��5W   !   #��z��5X   !    �� ContentStringFormat �� ContentStringFormat# z 5Y   !   5Z   +    �� Triggers 5[   *   P� 5\   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5]   2   ��  �� 
TargetName$ border��69    � ��
 �����6c   �� 5^   2    � ��
 �   �6O   5_   /   P� 5`   .    � ��$
 True��6K   . �5a   2   �� $ border��69    � ��
 �����6c   5b   /   P� 5c   .    � {�$ False��6K   . �5d   2   �� $ border��69    �@J�Opacity$	 0.5Q�6`   5e   /   5g   '   5i      5j      5l      �� 5o      $��Not a member?��6   $	��0,5q�5p      $��Bottom=�5q      $��Center=�5r      �� 5s      $��Sign Up��6   $
��0,10q�5t      $��Bottom=�5u      $��Center=�5v      5w      5x      5y      5z      