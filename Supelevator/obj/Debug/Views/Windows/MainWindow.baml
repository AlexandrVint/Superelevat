   M S B A M L   `   `   `  ����F  BSupelevator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SupelevatorSupelevator  5   	       Supelevator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Supelevator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��Button1��5      $��1��6    $��0��6-   $��0q�6=   $��18(�6I   
�������$
��auto��6k   $
��auto��6y   .��5      �� $F��@Расчет естественного дымоудаления��6   $
��Wrap=�5       �� TextAlignment$ Center=�5      $��50��6/   $	��200��6;   6I   5#      �� 5%   
   -   5        $��Button2��5%      $��1��6    $��1��6-   $��0q�6=   
�������$��18(�6\   .��5&      �� $b��\Расчет дымоудаления непосредственно из помещения��6   $
��Wrap=�5'      $ Center=�5(      $��80��6/   $	��250��6;   6I   5)      �� 5+   
   -   5        $��Button3��5+      $��1��6    $��2��6-   $��0q�6=   
�������$��18(�6\   .��5,      �� $A��;Расчет дымоудаления из коридора��6   $
��Wrap=�5-      $ Center=�5.      $��50��6/   $	��200��6;   6I   5/      �� 50   
   -   5        $��Button4��50      $��2��6    $��0��6-   $��0q�6=   
�������$��18(�6\   .��51      �� $G��AРасчет дымоудаления из автостоянки��6   $
��Wrap=�52      $ Center=�53      $��50��6/   $	��200��6;   6I   54      �� 56   
   -   5        $��Button5��56      $��2��6    $��1��6-   $��0q�6=   
�������$��18(�6\   .��57      �� $A��;Расчет дымоудаления из атриумов��6   $
��Wrap=�58      $ Center=�59      $��50��6/   $	��200��6;   6I   5:      �� 5;   
   -   5        $��Button6��5;      $��2��6    $��2��6-   $��0q�6=   
�������$��18(�6\   .��5<      �� $@��:Подпор воздуха в лифтовую шахту��6   $
��Wrap=�5=      $ Center=�5>      $��50��6/   $	��200��6;   6I   5?      �� 5@   
   -   5        $��Button7��5@      $��3��6    $��0��6-   $��0q�6=   
�������$��18(�6[   .��5A      �� $F��@Подпор воздуха в лестничную клетку��6   $
��Wrap=�5B      $ Center=�5C      $��50��6/   $	��180��6;   6I   5D      �� 5E   
   -   5        $��Button8��5E      $��3��6    $��1��6-   $��0q�6=   
�������$��18(�6[   .��5F      �� $:��4Подпор воздуха в тамбур-шлюз��6   $
��Wrap=�5G      $ Center=�5H      $��50��6/   $	��150��6;   6I   5I      �� 5J   
   -	   5        $��Button9��5J      $��3��6    $��2��6-   $��0q�6=   
�������$��18(�6[   .��5K      �� $N��HПодпор воздуха в пожаробезопасную зону��6   $
��Wrap=�5L      $ Center=�5M      $��60��6/   $	��220��6;   6I   5N      �� 5Q   
   -
   5        $��Button10��5Q      $��4��6!   $��0��6.   $��0q�6>   
�������$��18(�6\   .��5R      �� $[��UАеродинамический расчет системы дымоудаления��6   $
��Wrap=�5S      $ Center=�5T      $��70��6/   $	��220��6;   6I   5U      �� 5W   
   -   5        $��Button11��5W      $��4��6!   $��1��6.   $��0q�6>   
�������$��18(�6\   .��5X      �� $`��ZАеродинамический расчет системы подпора влздуха��6   $
��Wrap=�5Y      $ Center=�5Z      $��70��6/   $	��200��6;   6I   5[      �� 5]   
   -   5        $��Button12��5]      $��4��6!   $��2��6.   $��0q�6>   
�������$��18(�6\   .��5^      �� $`��ZТаблица баланса систем противодымной вентиляции��6   $
��Wrap=�5_      $ Center=�5`      $��70��6/   $	��200��6;   6I   5a      o� 5l   
   $��25��6   $	��Top=�6   $��3��63   $��0q�6G   
�������.@�5m      m� $��Файл��6   $��25��6%   $��50��61   
�������.@�5n      m� $��Открыть��6   $��0q�6,   $��25��6@   m� 5o      $��Загрузить��6   $��0q�6/   $��25��6C   6R   m� 5p      $��Сохранить��6   $��0q�6.   $��25��6B   6Q   m� 5q      $��Сохранить как��6   $��0q�62   $��25��6F   6U   m� 5r      $��Печать��6   $��0q�6+   $��25��6?   6N   �� 5s      6   m� 5t      $��
Выход��6   $��0q�6*   $��25��6>   6L   5v      m� 5w      $��Вид��6   .@�5x      m� $%��Панель рисования��6   $��0q�65   $��25��6I   6W   m� 5y      $D��>Сортамент огнезащитного покрытия��6   $��0q�6E   $��25��6Y   6g   m� 5z      $H��BСортамент противопожарных клапанов��6   $��0q�6G   $��25��6[   6i   m� 5{      $%��Настройка отчета��6   $��0q�66   $��25��6J   .@�5|      m� $I��CОтобразить схему системы вентиляции��6   6N   m� 5}      $[��UОтобразить таблицу аэродинамического расчета��6   6W   5~      5�      m� 5�      $��Справка��6   6*   5�      5�      5�      