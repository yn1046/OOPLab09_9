   M S B A M L   `   `   `  ����E  AOOPLab09_9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OOPLab09_9
OOPLab09_9  5   	       OOPLab09_9.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:OOPLab09_9     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   o� $��0��6   .@�5      m� -   5         m�Name$
 File��5   7      File#���   6   .@�5      m� -   5        $	 New��5   :     New#���  6    m� Command 6G   ��  �� Path$ 
NewCommand�m� 5      -   5        $
 Save��5   ;     Save#���  6    6I   �� $ SaveCommand�m� 5      -   5        $
 Open��5   ;     Open#���  6    6I   �� $ OpenCommand�5      m� 5      -   5        $
 Edit��5   7     Edit#���  6   .@�5      m� -   5        $
 Undo��5   ;     Undo#���  6   $
 Undo��6I   m� 5      -   5        $
 Redo��5   ;     Redo#���  6   $
 Redo��6I   m� 5      -   5        $
 Copy��5   ;     Copy#���  6   $
 Copy��6I   m� 5      -	   5        $ Paste��5   <    	 Paste#���  6   $ Paste��6K   m� 5      -
   5        $
 Font��5   ;    	 Font#��� 	 6    6I   �� $ FontCommand�m� 5      -   5        $ Color��5   <    	
 Color#��� 
 6    6K   �� $ ColorCommand�5      d� 5      -   5         d�Name$
 Bold��5      $ ��EditingCommands.ToggleBold��6)   $��0q�6N   .��5      �� $"��pack://application:,,,/b.png��6   5      d� 5      -   5        $ Italic��5      $"��EditingCommands.ToggleItalic��6+   $��0q�6R   .��5       �� $"��pack://application:,,,/i.png��6   5!      d� 5"      -   5        $ 
Underlined��5"      $%��EditingCommands.ToggleUnderline��6/   $��0q�6Y   .��5#      �� $"��pack://application:,,,/u.png��6   5$      d� 5%      -   5        $ 
SwitchLang��5%      $��RU/EN��6V   $��0q�6f   ��6/   �� $ SwitchCommand�6f   5'      �� 5(   
   -   5         ��Name$ textBox��5(   #   $��1��6   6#   5)      5*      