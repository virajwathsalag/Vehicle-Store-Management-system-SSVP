   M S B A M L   `   `   `  ����B  >CarApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CarApp2CarApp2  5   	   5clr-namespace:CarApp2.MVVM.ViewCarApp2.MVVM.View  5   
   ?$clr-namespace:CarApp2.MVVM.ViewModelCarApp2.MVVM.ViewModel  5   	   5clr-namespace:CarApp2.MVVM.ViewCarApp2.MVVM.View  5	   	       CarApp2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CarApp2     5   	   2local1clr-namespace:CarApp2.MVVM.View     5   
   :	viewModel$clr-namespace:CarApp2.MVVM.ViewModel     5   	   0viewclr-namespace:CarApp2.MVVM.View     5	   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1300��6)    � WindowStyle$
 None=�5   	    � 
ResizeMode$ 	CanResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      *  $CarApp2.MVVM.ViewModel.MainViewModel  5   
   .��5      �� 
������� �� CornerRadius$ 20��5      ._�5   
   �  � RowDefinitions 5      �� 5       $	��23* �6    �� 5!      $	��67* �6    �� 5"      $
��600* �6    .+�5*      � .+�5+      !   CarApp2.MVVM.View.loginView  5-      �� 5.      $��2��6   $��0��6*   $��10q�5/      ��50      �� *CurrentView+�� 51      ���#272537$��Center=�6'   $
��1300��6D   $��0,0,0,57q�6Q   $��2��6c   A� 52      -   5         A�Name$ btnExit��52      
���  ��$��15��62   $
��Left=�6=   $��
1276,8,0,0q�6X   	 � Cursor$
	 Hand��6n   6|   �� 54      $��2��6   �� 57      $��2��6   $��
14,19,6,10q�58      
������ 6&   �� 59      
�������$��Center=�6%   $
��1300��6B   $��1��6O   $��
0,10,0,595q�6\   $��2��6p   	� 5:      
���   �$��14(�5<      $��1178,15,10,3q�6   $��Login��5=         LoginbtnTheme#��[  5>      $
	 Hand��68   $��1��6F   ��5?      �� *LoginViewCommand+	� 5@      
���   �$��14(�5B      $��1061,15,127,3q�6   $��SignUp��5C      #��[  5D      $
	 Hand��68   $��1��6F   ��5E      �� *SigupViewcommand+	� 5F      
���   �$��14(�5H      $��936,15,244,4q�6   $��About��5I      #��[  5J      $
	 Hand��68   $��1��6F   ��5K      �� *AboutViewCommand+	� 5L      
���   �$��14(�5N      $��190,15,988,5q�6   $
��Home��5O      #��[  5P      $
	 Hand��68   $��1��6G   
 d� 	IsChecked$

 TrueY�5Q      ��5R      �� *HomeViewCommand+�� 5U      $
��Left=�6   $	��148��6/   $��	10,-8,0,0q�6<   $	��Top=�6O   $	��143��6g   $����/Images/Firefly_An_new_car_brand_logo_named_SSVP_to_be_put_in_a_car._It_should_be_new_looking_.black_letter_-removebg-preview.png��6t   $��3��6�   A� 5V      -   5        $ btnMinimize��5V      
��� ���$��15��69   $
��Left=�6D   $��
1256,8,0,0q�6_   $
	 Hand��6�   A� 5W      -   5        $ btnExit_Copy1��5W      
���/���$��15��6@   $
��Left=�6K   $��
1236,7,0,0q�6f   �� 5X      
���   �$��1��6%   $��7��60   $	��Top=�6:   $��Right=�6R   $��	0,15,13,0q�6n    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5Y      V� 5Z      .~�5[      ��  �� ScaleY$ -1Q�6)   �� 5\      �� 5]       �� Angle$ 46.406Q�6*   T� 5^      5_      5a      �� 5b      
���   �$��1��6%   $��7��60   $	��Top=�6:   $��Right=�6R   $��	0,15,13,0q�6n   $ 0.5,0.5&�6�   z�5c      V� 5d      .~�5e      �� $ -1Q�6)   �� 5f      �� 5g      $ -48.507Q�6*   T� 5h      5i      5k      �� 5l      
���   �$��1��6%   $��7��60   $	��Top=�6:   $��Right=�6R   $��	0,15,33,0q�6n   $ 0.5,0.5&�6�   z�5m      V� 5n      .~�5o      �� $ -1Q�6)   �� 5p      �� 5q      T� 5r      5s      5u      5y      5}      5~      