   M S B A M L   `   `   `  ����B  >CarApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CarApp2.MVVM.ViewCarApp2.MVVM.View  5      !    CarApp2.MVVM.View.loginView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CarApp2.MVVM.View     5      
������ .��5      ��   �� CornerRadius$  12��6   $��	10,0,10,0q�6   ��5   
   �� 5       �� ImageSource$2 ,/Images/f3712c26bca08ab2f4fe36ca9d0e8af4.jpg��6    j� Stretch$ UniformToFill=�5      ._�5   
   �� $  10��6   $��6q�5       J� Opacity$
 0.79Q�5      $��	-12,0,0,0q�6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $ Black��6#   $ 0Q�61   5      ��5       �� 5!      $	 0,1&�6&   $	 1,0&�67   .��5"      � $ Black��6#   $ 0Q�61   � 5#      $ Ivory��6#   $ 1Q�61   5$      ._�5'      � $��0,0,-6,0q�6    � RowDefinitions 5(      �� 5)      $��30 �6$   �� 5*      .+�5-      �� $��Center=�6   $	��504��69   $��1��6F   
���   �$	��Top=�6b   $	��320��6z   
�������$��0,9,0,0q�6�   � 5/      $��0��6   	 � ColumnDefinitions	 51      �� 52      �� 53      $��25 �6+   �� 54      $��25 �6+   �� 55      $��5 �6+   .+�5:      �� $����/Images/Firefly_An_new_car_brand_logo_named_SSVP_to_be_put_in_a_car._It_should_be_new_looking_.black_letter_-removebg-preview.png��6   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   $��503,-50,453,-240q�6�   z�5;      V� 5<      .~�5=   "   �� �� 5>   "    �� AngleX$ 0.895Q�60   �� 5?   "    �� Angle$ 0.915Q�62   T� 5@   "    T� X$ 1.984Q�65   5A      5C      5E      �� 5G      $	��250��6   $��1��5H       �� Orientation$ Vertical=�5I      $��508,160,508,2q�5J      .+�5M      �� $��SSVP Prime Vehicles��6    
���   �$��27(�5O       $��Medium"�5P       $��
Montserrat)�5Q       $��44��68   �� 5T      $V��PWelcome to SSVP: redefining driving with innovation, luxury, and sustainability.��6    
���   �$��12(�5W       $��Medium"�5X       $��
Montserrat)�5Y       $
��Wrap=�5Z        �� TextAlignment$ Center=�5[       $��0,5,0,0q�5\       $��37��61   �� 5^      $��Username��6    
���   �$��12(�5`       $��Medium"�5a       $��
Montserrat)�5b       $��0,35,0,0q�5c       �� 5e      -   5         ��Name$ txtUser��5e      $��13(�5f      $��Medium"�5g      $��
Montserrat)�5h      
���   � �� 
CaretBrush
 �   �
���   �$��0,0,0,2q�5l      $��28��5m      $��Center=�5n      $��0,5,0,0q�5o      $��20,0,0,0q�5p      .��61   ��5r      �� 5s      $$ /Images/icons8-username-16.png��5t       $
 None=�5w   )    j� 
AlignmentX$
 Left=�5x   )   .��5y   .   5z      �� 5|      $��Password��6    
���   �$��12(�5~       $��Medium"�5       $��
Montserrat)�5�       $��0,15,0,0q�5�       G� 5�      -   5         G�Name$ txtPass��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
���   � G� 
CaretBrush
 �   �
���   �$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�      �� 5�      $$ /Images/icons8-password-16.png��6)   $
 None=�5�   )   $
 Left=�5�   )   5�      �� 5�      -   5         ��Name$ 	txtBerror��5�       $
��Wrap=�63   $��.��6G   $��29��6P   $	��249��6\   {�.  ���	#FFE409096z   �� 5�      -   5         ��Name$ btnLogin��5�      $��4q�5�      $��LOG IN��5�      
�������$��14(�5�      $��
Montserrat)�5�       � Cursor$
 Hand��5�      ��5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � �� �� Value �#112f816?    �� Triggers 5�   "   P� 5�   &    P� Property �@J�IsMouseOver P� Value . . �5�   *   ��  � �� �#A52A2A6G   5�   '   5�      ��5�      �� 5�       �� 
TargetType" ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $  20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�      �� $��Haven't Registered?��6$   
���   �$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       �� 5�      -   5        $��Register��5�   $   
����  �$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
 Hand��5�       $��8,0,0,0q�5�       61   5�      5�      5�      5�      5�      5�      