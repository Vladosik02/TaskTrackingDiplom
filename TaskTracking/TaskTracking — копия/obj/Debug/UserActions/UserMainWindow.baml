   M S B A M L   `   `   `  ����G  CTaskTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TaskTracking.UserActionsTaskTracking.UserActions  5   	   -    'TaskTracking.UserActions.UserMainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:TaskTracking.UserActions     5   	     � Title$   Доски и задачи��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      �� 5      $��6* �6   �� 5      .+�5   
   �� $;��5Выберите доску для просмотра��6   $��16(�5      $��WrapWithOverflow=�5      $��5q�5      $
��Bold"�5      �� 5   
   -   5        $��listBox��5      $��1��5      $��Disabled=�5      $��5q�5       ��5!      �� 5"      .R�5#      � .+�5$      �� $
��Wrap=�6$   ��68   ��  �� Path$
 Name�5%      5&      5(      �� 5*      -   5        $��searchTextBox��5+      $��30��5,      $��1��5-      $
��Left=�5/      $��Center=�50      $��5q�51      � 53      $��1��54      $��1��55      $��2��56       58      �� 59      �� 5:      $��8* �6     5=      �� 5>      �� 5?      �� 5@      �� 5A      .+�5D      �� -   5        $��backlogTextBlock��5D      $��Беклог��5E      $��Center=�5F      $��Center=�5G      $��WrapWithOverflow=�5H      $��14(�5I      �� 5K      -   5        $��notInWorkListBox��5L      $��5q�5M      $��Disabled=�5N      $��1��5O      ��5Q      �� 5R      .R�5S      � -   5        
 � Tag 5U      �� $ Id� 5W      �� 5X   "   �� 5Y   "   �� 5Z   "   .+�5]      �� $
��Bold"�6(   $
��Wrap=�6:   ��6N   �� $ 	ShortName��� 5^      $
��Wrap=�6(   $��1��6<   ��6I   �� $
 Name��� 5_      
�������$��Italic$�5`   (   $
��Wrap=�6;   $��2��6O   ��6\   �� $ 
User1.Name�5a      5b      5e      �� 5h      $��В работе��5i      $��1��5j      $��Center=�5k      $��Center=�5l      $��WrapWithOverflow=�5m      $��14(�5n      �� 5p      -   5        $��inWorkListBox��5q      $��5q�5r      $��Disabled=�5s      $��1��5t      $��1��5u      ��5w      �� 5x      .R�5y      � -   5         5{   %   �� $ Id� 5}      �� 5~   "   �� 5   "   �� 5�   "   .+�5�      �� $
��Bold"�6(   $
��Wrap=�6:   ��6N   �� $ 	ShortName��� 5�      $
��Wrap=�6(   $��1��6<   ��6I   �� $
 Name��� 5�      
�������$��Italic$�5�   (   $
��Wrap=�6;   $��2��6O   ��6\   �� $ 
User1.Name�5�      5�      5�      �� 5�      $��Завершены��5�      $��2��5�      $��Center=�5�      $��Center=�5�      $��WrapWithOverflow=�5�      $��14(�5�      �� 5�      -   5        $��readyListBox��5�      $��5q�5�      $��Disabled=�5�      $��2��5�      $��1��5�      ��5�      �� 5�      .R�5�      � -	   5         5�   %   �� $ Id� 5�      �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� $
��Bold"�6(   $
��Wrap=�6:   ��6N   �� $ 	ShortName��� 5�      $
��Wrap=�6(   $��1��6<   ��6I   �� $
 Name��� 5�      
�������$��Italic$�5�   (   $
��Wrap=�6;   $��2��6O   ��6\   �� $ 
User1.Name�5�      5�      5�      �� 5�      $��Отменены��5�      $��3��5�      $��Center=�5�      $��Center=�5�      $��WrapWithOverflow=�5�      $��14(�5�      �� 5�      -
   5        $��cancelListBox��5�      $��5q�5�      $��Disabled=�5�      $��3��5�      $��1��5�      ��5�      �� 5�      .R�5�      � -   5         5�   %   �� $ Id� 5�      �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      �� $
��Bold"�6(   $
��Wrap=�6:   ��6N   �� $ 	ShortName��� 5�      $
��Wrap=�6(   $��1��6<   ��6I   �� $
 Name��� 5�      
�������$��Italic$�5�   (   $
��Wrap=�5�   (   $��2��6<   ��6I   �� $ 
User1.Name�5�      5�      5�      5�      �� 5�   
   -   5        $��createTaskButton��5�      $��2��5�      $��5q�5�      .��5�      �� $1��+Создать задачу на доске��6   $
��Wrap=�5�      $��Center=�5�      5�      5�      5�      