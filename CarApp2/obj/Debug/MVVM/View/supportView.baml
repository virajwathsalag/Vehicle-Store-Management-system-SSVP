   M S B A M L   `   `   `  ����B  >CarApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarApp2.MVVM.ViewCarApp2.MVVM.View  5      #    CarApp2.MVVM.View.supportView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarApp2.MVVM.View     5      
������ $	��662��5   Z   .��5
      �� $��0,0,0,10q�6   .��5   
   ��   �� CornerRadius$  10��6   
������� �� Padding$ 5q�66   ._�5      �� ._�5      �  � RowDefinitions 5      �� 5      $��60 �6(   �� 5      $	��350 �6(   �� 5      $	��190 �6(   �� 5      $	��340 �6(   .+�5      � $��0��6   $��25,0,0,0q�6(    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $
��Auto �6/   .+�5      �� $��/Images/Logo.png��6    $	��135��6:   $
��Left=�6F   $��10,5,0,0q�6a   �� 5      $��/Images/24Service.png��6    $��Center=�6?   $	��143��6\   $��1��6h   $��0,0,0,5q�6x   5      �� 5      $��1��6!   $��-15,0,-12,0q�6.   .+�5      �� $��/Images/Car.jpg��6    5       �� 5!      $��1��6    $
��Left=�6.   
���   �$��45(�5"   ,   $
��Bold"�6:   $��
25,76,0,76q�6L   $	��486��6`   �� 5#      $�Welcome To SSVP ��6   �� 5$      �� 5%      $�Support Center��6   �� 5&      5'      � 5*      $��2��6   $��	0,43,0,10q�6(    5+      �� 5,      $��* �6/   �� 5-      $��* �6/   �� 5.      $��* �6/   �� 5/      $��* �6/   .+�51      �� $��0��6%   $��Center=�65   .+�52      �� $ ��Frequently Asked Questions��6(   $��18(�6J   $
��Bold"�6X   $��0,0,0,10q�6j   $��Center=�6|   53      �� 54      $��1��6%   $��Center=�65   .+�55      9� $!��How to use the application?��6'    9� 
IsExpanded . $��17(�6^   .��56   "   �� $
��Wrap=�6,   $P��JFirst You have to Register To the App and Then you Can login to the system��6@   $��10q�6�   $��17(�6�   57      58      �� 59      $��2��6%   $��Center=�65   .+�5:      9� $��How to contact support?��6'   $��17(�6H   .��5;   "   �� $
��Wrap=�6,   $c��]You can contact support via the form on the left or email us at support@ssvpprimevehicles.com��6@   $��10q�6�   $��17(�6�   5<      5=      �� 5>      $��3��6%   $��Center=�65   .+�5?      9� $ ��What is the response time?��6'   $��17(�6K   .��5@   "   �� $
��Wrap=�6,   $7��1Our support team will respond within 24-48 hours.��6@   $��10q�6y   $��17(�6�   5A      5B      5C      �� 5E      $��3��6!   $��
25,0,600,0q�6.   .+�5F      �� $��
Contact Us��6$   $��18(�66   $
��Bold"�6D   $��0,0,0,10q�6V   �� 5G      $��
Our Email:��6$   �� 5H      -   5         ��Name$ txtouremail��5H   "   $ ��virajwgunasinghe@gmail.com��67   $��0,0,0,10q�6Z   �� 5I      $��Your Email:��6$   �� 5J      -   5        $ txtyouremail��5J   "   $��0,0,0,10q�68   �� 5K      $��Message:��6$   �� 5L      -   5        $ 
txtmessage��5L   "    �� AcceptsReturn . $	��100��6K   $��0,0,0,10q�6X   �� 5M      -   5         ��Name$ 	btnSubmit��5M   !   $��Submit��64   6E   5N      �� 5O      $��3��6!   $��
612,0,10,0q�6.   .+�5P      �� $	��215��6$   5R      5S      5U      5V      5W      5X      5Y      