   M S B A M L   `   `   `  ����P  LCanvas_and_Animations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Canvas_and_AnimationsCanvas_and_Animations  5   	   &     Canvas_and_Animations.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Canvas_and_Animations     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ canvas��5
      $��10,10,10,75q�6!   ���	#FFEAEAEA|�. }�. 6�   A� 5   
   -   5         A�Name$ 
Modes_grid��5      $��27��6*   $��
10,0,10,34q�66   $��Bottom=�6J    A� Columns$ 5��6e   .+�5      d� -   5        $��Default��5      $	��2,0q�6-   
 � Tag$ 1��6:    d� 	IsChecked$
 TrueY�6B   6S   d� 5      -   5        $��	45° Left��5      $	��2,0q�6.   $ 2��6;   6C   d� 5      -   5        $��
45° Right��5      $	��2,0q�6/   $ 3��6<   6D   d� 5      -   5        $��Vertical��5      $	��2,0q�6.   $ 4��6;   6C   d� 5      -   5        $��
Horizontal��5      $	��2,0q�60   $ 5��6=   6E   5      A� 5   
   $��
10,0,10,10q�6   $��Bottom=�6*   $ 4��6E   .+�5      �� -	   5         ��Name$ speed��5      $��2,0,52,0q�6%    �� TextWrapping$
 Wrap=�67   $
��2000��6�   �� 5      -
   5        $ delay��5      $��-48,0,102,0q�6%   $
 Wrap=�6:   $	��100��6�   �� 5      -   5         ��Name$ stop_animation��5      $��Stop animation��6-   $��
-98,0,52,0q�6F   $��Bottom=�6Z   $��20��6u   6�   �� 5      -   5        $ start_animate��5      $��Start animation��6,   $��	-48,0,2,0q�6F   $��Bottom=�6Y   $��20��6t   6�   5      5      5      