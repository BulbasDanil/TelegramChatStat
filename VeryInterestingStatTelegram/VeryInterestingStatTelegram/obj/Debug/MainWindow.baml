   M S B A M L   `   `   `  ����V  RVeryInterestingStatTelegram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:VeryInterestingStatTelegramVeryInterestingStatTelegram  5   	   ,    &VeryInterestingStatTelegram.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:VeryInterestingStatTelegram     5   	     � Title$  TelegramStat��5   	   $	��650��6   $	��400��6+    � 
ResizeMode$ 	CanResize=�67      	MainStyle#���   6N   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Center=�6A   $-��'Выберите JSON файл чата��6_   �� 5   
   -   5         ��Name$ pathBox��5   :     TextBoxStyle1#���  6   $��1��6K    �� TextAlignment$ Center=�6X   
���   �6o   �� 5   
   -   5         ��Name$ 
findButton��5   7     ButtonStyle#���  6   $��1��6K   $��1��6X   $	��...��6h   
���   �6�   �� 5   
   -   5        $ startButton��5   7   #���  6   $��3��6L   $��2��6Y   $��10 10 10 10q�6m   $��Начать��6�   
���   �6�   �� 5   
   $��2��6   $��0��6   $��1��6-   $��Center=�6B   $
��Left=�6]   $7��1Минильное кол-во символов: ��6y   $��10 0 0 0q�6�   �� 5   
   -   5        $ symBox��5   :   #���  6   $��38��6J   $��50��6X   $��18(�5      $��3��6    $��2��6)   $ Center=�66   $��10q�6M   $��0 0 10 0q�5      $��1��6$   
���   �64   �� 5   
   -   5         ��Name$ 	resultBox��5   9     ListBoxStyle#���  6   $��4��6L   $��2��6Y   
���   �6m   5       5!      