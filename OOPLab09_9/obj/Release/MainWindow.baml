   M S B A M L   `   `   `  ���� E  AOOPLab09_9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OOPLab09_9
OOPLab09_9      OOPLab09_9.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:OOPLab09_9       � Title$  
MainWindow��$	��350��$	��525��.���  � RowDefinitions �� $��20 ��� $��* �.+�o� $��0��.@�m� -    m�Name$
 File��$��_File��.@�m� -   $	 New��$
��_New�� m� Command ��  �� Path$ 
NewCommand�m� -   $
 Save��$��_Save�� �� $ SaveCommand�m� -   $
 Open��$��_Open�� �� $ OpenCommand�m� -   $
 Edit��$��_Edit��.@�m� -   $
 Undo��$��_Undo��$
 Undo��m� -   $
 Redo��$��_Redo��$
 Redo��m� -   $
 Copy��$��_Copy��$
 Copy��m� -	   $ Paste��$��_Paste��$ Paste��m� -
   $
 Font��$
��Font�� �� $ FontCommand�m� -   $ Color��$��Color�� �� $ ColorCommand�d� -    d�Name$
 Bold��$ ��EditingCommands.ToggleBold��$��0q�.���� $"��pack://application:,,,/b.png��d� -   $ Italic��$"��EditingCommands.ToggleItalic��$��0q�.���� $"��pack://application:,,,/i.png��d� -   $ 
Underlined��$%��EditingCommands.ToggleUnderline��$��0q�.���� $"��pack://application:,,,/u.png���� -    ��Name$ textBox��$��1��