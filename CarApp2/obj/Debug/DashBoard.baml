   M S B A M L   `   `   `  ����B  >CarApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CarApp2CarApp2  5   	   ?$clr-namespace:CarApp2.MVVM.ViewModelCarApp2.MVVM.ViewModel  5
   	   5clr-namespace:CarApp2.MVVM.ViewCarApp2.MVVM.View  5   	       CarApp2.DashBoard   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CarApp2     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   ` \Syncfusion.Shared.Wpf, Version=25.2462.4.0, Culture=neutral, PublicKeyToken=3d67ed1f87d44c892
syncfusion!http://schemas.syncfusion.com/wpf  5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5	   	   4	viewModel$clr-namespace:CarApp2.MVVM.ViewModel  5
   	   *viewclr-namespace:CarApp2.MVVM.View  5   	     � Title$  	DashBoard��5   	   $	��662��6   $
��1300��6(    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . 
������  � DataContext 5      3  -CarApp2.MVVM.ViewModel.MainDashboardViewModel  5   
   .��5      ��  �� CornerRadius$ 10��6   $��1q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �    winBorderColor1 � Color# [  6   	 � Offset$	 0Q�6H   � 5        winBorderColor2# [ 6   $		 0.5Q�6H   � 5      # [  6   $	 1Q�6H   5      ._�5"   
   � 
 � ColumnDefinitions
 5#      �� 5%      $	��284 �6#   �� 5'      .+�5+      �� $ 	10,0,0,10��6   $��0��5,      ��5/      �� 50      $	 0,0&�6*   $ 0.9,1&�6;   .��51      �   secondaryBackColor1# [ 6'   $	 0Q�6T   � 52        secondaryBackColor2# [ 6'   $	 1Q�6T   53      ._�56      �� .+�5B      �� $��/Images/logoEdit1.png��6   $	��129��6;   $	��196��6H   �� 5G       �� Orientation$ 
Horizontal=�6!   $��35��5H   !   $��
15,25,0,40q�5I   !   .+�5J      �� $��SSVP Prime Vehicles��6$     titleColor1#��[ 5K   $   $��27(�5L   $   $��
Montserrat)�5M   $   $��Medium"�5N   $   $	��259��68   5O      	� 5U        
menuButton#��[ 6"     color10
 � Tag# [ 5V   "    d� 	IsChecked$
 TrueY�5W   "   $	��267��5X   O   ��6"   �� *DashboardHomeViewCommand+.��5Y      �� $ 
Horizontal=�6%   .+�5Z      !  FontAwesome.Sharp.IconBlock  �  �FontAwesome.Sharp.IconBlockBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 5[      $��	Dashboard��6(     menuButtonText#��[ 69   5\      5]      	� 5_      -   5         	�Name$ rdbModel��5_   "   #��[ 64   # [ 5`      $	��267��5a   4   ��6   �� *ModelViewCommand+.��5b      �� $ 
Horizontal=�6%   .+�5c        $	 Car=�6+   #��[ 66   �� 5d      $��Models��6(   #��[ 66   5e      5f      	� 5h      #��[ 6"   # [ 5i      $	��267��5j   7   ��6   �� *customizeViewCommand+.��5k      �� $ 
Horizontal=�6%   .+�5l        $ ShoppingCart=�6+   #��[ 6?   �� 5m      $	��Buy��6(   #��[ 63   5n      5o      	� 5q      #��[ 6"   # [ 5r      $	��267��5s   H   ��6   �� *PurchaseDeatilsViewCommand+.��5t      �� $ 
Horizontal=�6%   .+�5u        $ Wallet=�6+   #��[ 69   �� 5v      $��Purchase Details��6(   #��[ 6@   5w      5x      	� 5y      #��[ 6"   # [ 5z      $	��275��5{   4   ��6   �� *ReturnViewCommand+.��5|      �� $ 
Horizontal=�6%   .+�5}        $ 
BoxArchive=�6+   #��[ 6=   �� 5~      $��Return��6(   #��[ 66   5      5�      	� 5�      #��[ 6"   # [ 5�      $	��267��5�   (   ��6   �� *supportViewCommand+.��5�      �� $ 
Horizontal=�6%   .+�5�        $ Phone=�6+   #��[ 68   �� 5�      $��Support��6(   #��[ 67   5�      5�      � 5�      $��1��6   $	��190��6+    J� RenderTransformOrigin$ 0.5,0.5&�68   z�5�      V� 5�      .~�5�   "   ��  �� ScaleY$ 1Q�61   �� 5�   "   �� 5�   "   T� 5�   "   5�      .+�5�      �� -   5         ��Name$ 	btnLogout��5�   !   $��4q�5�   	   
�������$��14(�5�   	   $��
Montserrat)�5�   	    � Cursor$
 Hand��5�   	   $��10,-1,63,107q�5�   	   ��5�      �� 5�   "    �� 
TargetType" ��6(   .�5�   &   ��  �� Property � �� �� Value �#c9d5f76C    �� Triggers 5�   &   P� 5�   *    P� Property �@J�IsMouseOver P� Value . . �5�   .   ��  � �� �#A52A2A6K   5�   +   5�   #   ��5�      �� 5�   "    �� 
TargetType" ��62   .R�5�   &   �� $	��150��6-   $��40��69   $ 20��5�      #��z��5�      ._�5�   *   �� $��Center=�6;   $��Center=�5�   #   5�   '   5�   #   .��5�        $ RightFromBracket=�6+   #��[ 6C   $��Bottom=�6k   $��	0,10,60,0q�6�   5�      �� 5�      $��Logout��6$   $��107,32,35,110q�62   5�      5�      5�      �� 5�      $ 	0,10,10,0��6   $��1��5�      ��5�      �� 5�      $	 1,1&�6*   $	 0,0&�6;   .��5�      �  	 primaryBackColor1# [	 6'   $	 0Q�6R   � 5�       
 primaryBackColor2# [
 6'   $	 1Q�6R   5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6(   �� 5�      $��35 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ pnlControlBar��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   ���#acbff3 J� Opacity$	 0.9Q�5�   !   .+�5�      �� -   5        $ btnClose��5�   !     controlButton#��[ 5�   !    
 color7# [ 5�   !   $��29��5�   8   .��5�      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6+     controlButtonIcon#��[ 68   $��12��6c   5�      �� 5�      -   5        $ btnMinimized��5�   !   #��[ 5�       
 color4# [ 5�      .��5�        $ WindowMinimize=�6+   $��12��6A   #��[ 6L   5�      5�      � 5�      $��1��6   
 5�      �� 5�      $
��505* �6/   �� 5�      $
��219* �6/   �� 5�      $
��286* �6/   .+�5�      �� $��0��6%   $ 
Horizontal=�5�   %   $��Center=�5�   %   .+�5        $
 Home=�6+   $��20��5  +   $��20��5  +     titleColor3   
Foreground# [ 5  +   $��	35,0,10,0q�5  +   �� 5     $��	Dashboard��6(   #��[ 5  (   $��16(�5  (   $��Medium)�5  (   $��Center=�5	  (   5     �� 5     $��1��6%   $ 
Horizontal=�5  %   $��RightToLeft=�5  %   $��Center=�5  %   $��0,0,10,0q�5  %   $��2��67   .+�5     ��   
iconButton#��[ 6%    
 color1# [ 5  %   .��5  "     $ 	AngleDown=�6/     iconButtonIcon#��[ 6@   5     �� 5     -   5          ��Name$  txtBusername��5  (   $��.��6>   #��[ 5  (   $��12(�5  (   $��Center=�5  (   $��20,0,0,0q�6C   A� 5!     $��35��6&   $��35��62   $��2��5"  &    
 color9#��[ 5#  &   $��	30,0,10,0q�5$  &   ��5&  "   �� 5(  &   ! �� ImageSource$8! 2/Images/Toyota_C-HR_review_front34_dynamic (1).jpg��61   5+     �� 5.     #��[ 6%    
 color3# [ 5/  %   .��51  "     $ Clock=�6/   #��[ 6<   53     �� 55     #��[ 6%   # [ 56  %   .��58  "     $ Envelope=�6/   #��[ 6?   5:     �� 5<     #��[ 6%    
 color5# [ 5=  %   .��5?  "     $
 Bell=�6/   #��[ 6;   5A     5B     5C     � 5E     $��3��6   $
��1092��6,   $	��Top=�6:   $��
0,-172,0,0q�6R    5F     �� 5G     $
��185* �6,   �� 5H     $
��179* �6,   .+�5K     �� $��/Images/wall.jpg��6    $��UniformToFill=�6:   $��0,261,2,258q�6R   $��2��6g   �� 5L     "  WpfAnimatedGif.ImageBehavior"   RepeatBehavior$" Forever��6!   #   AnimatedSource$K# E/Images/Website_Header_RaceTrack-ezgif.com-video-to-gif-converter.gif��5M     $��UniformToFill=�5N     $��-102,261,-4,268q�6   $��2��62   �� 5R     $��Arial)�6%   $��62(�68   $
��Bold"�6F   $��82,399,301,428q�6X   $��2��6p   
��������� 6�   $�SSVP Lexus E5 : with��6�   �� 6�   �� 6�   $�dynamism and ��6�   �� 6�   �� 6�   $�a helping hand��6�   6  5Z     �� 5\     
������ $��1��5]  N   $��2��6[   ��6.   �� *CurrentView+6[   5a     5b     5d     5e     5g     