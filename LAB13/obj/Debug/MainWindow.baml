   M S B A M L   `   `   `  ����@  <LAB13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LAB13LAB13  5   	       LAB13.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:LAB13     5   	   -   5          �Name$  ManagerCarWPF��5   	    � Title$ MangerCarWPF��5   	   $��375.6��6   $��747.2��6-    � 	Resources 5	         LAB13.CarDataSet   
carDataSet  autoViewSource �� Source �� Source  producerViewSource��%�   &	        &	      7   &	 =     7     5
   
   6   �� 5   
    66   �� *Auto+8   �� 5   
    6:   �� *
Producer+8   5      .��5      �� .@�5   
   �� $��Машины��6   .��5      � ���	#FFE5E5E5 � DataContext# [ 6*   .+�5      �� -   5         ��Name$ saveAuto��5      $��Сохранить��6+   $
��Left=�6?   $��9,14,0,0q�6Z   $	��Top=�6l   $��75��6�   6�   �� 5      -   5        $ 
deleteAuto��5      $��Удалить��6-   $
��Left=�6?   $��	98,14,0,0q�6Z   $	��Top=�6m   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ autoDataGrid��5         EnableRowVirtualization . 	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6P   $��-2,59,282.2,0.4q�6   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6�      AutoGenerateColumns .  ��6�   ��  �� Mode$ OneWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        numberColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��5   ^      Width$ SizeToHeader 6m      
FontWeight$
 Bold"�6�      MinWidth$ 40Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Number+6�   4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        
UserColumn��$ 60 5   �      DisplayMemberPath$ Title��6�      SelectedValuePath$ 
ProducerId��6�   $ 
Марки��6�      ItemsSource 6E   �� # [    SelectedValueBinding 6�   �� *
ProducerId+6�     5      -   5        
NameColumn��$ Имя��5   [   $ SizeToHeader 6h    6A   �� *uName+6h     5      -   5        lastNameColumn��$ Фамилия��5   b   $ SizeToHeader 6s    6E   �� *
LastName+6s   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Фотография��61      CellTemplate 5      �� 5   "   .R�5   &   �� ��6,   �� *Photo+6G   5   #   5      5!      �� 5"      -	   5         ��Name$ 
labelImage��5"      $��	Фото
��6,   $
��Left=�6@   $��
569,56,0,0q�6[   $	��Top=�6o    J� RenderTransformOrigin$ 0.834,-0.161&�6�   $��25��6�    � ContextMenu 5#      �� 5$      .@�5%      �� -
   5        $ ContextImage��5%   %   $��Загрузить��6;   6O   5&      5(      �� 5)      
���   �$��1q�6-   $
��Left=�6A   $	��203��6\   $��
480,89,0,0q�6i   $	��Top=�6}   $	��222��6�   ._�5*      �� -   5         ��Name$ 
photoImage��5*      ��60   �� *Photo+5+      5,      5-      5/      �� 50   
   $��
Марки��6   .��51      � ���	#FFE5E5E5# [ 6*   .+�52        -   5        $ producerDataGrid��52       .   . $��2,52,10.2,7.4q�6�   $	 VisibleWhenSelected=�6�   ��6p   ��  53        54      -   5        titleColumn��$ Название��54   \   $ SizeToHeader 6n    6B   �� *Title+6n     55      -   5        countryColumn��$ Страна��55   `   $ SizeToHeader 6p    6D   �� *	Country+6p   57      �� 58      -   5        $ saveProducer��58      $��Сохранить��6/   $
��Left=�6C   $��6,20,0,0q�6^   $	��Top=�6p   $��75��6�   6�   �� 59      -   5        $ deleteProducer��59      $��Удалить��61   $
��Left=�6C   $��
105,20,0,0q�6^   $	��Top=�6r   $��75��6�   6�   5:      5;      5<      5=      