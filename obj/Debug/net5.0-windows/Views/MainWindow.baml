   M S B A M L   `   `   `  ����H  DAppSfDataGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AppSfDataGrid.ViewModelAppSfDataGrid.ViewModel  5   	   9!clr-namespace:AppSfDataGrid.ViewsAppSfDataGrid.Views  5   	   $    AppSfDataGrid.Views.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4vm%clr-namespace:AppSfDataGrid.ViewModel     5   	   3local!clr-namespace:AppSfDataGrid.Views     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.69, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.69, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
syncfusion!http://schemas.syncfusion.com/wpf   5	   	     � Title$  Registro de Personas��5   	   $	��600��6&   $
��1000��63    � WindowStartupLocation$ CenterScreen=�6@    � 	Resources 5      -   'AppSfDataGrid.ViewModel.PersonViewModel   personViewModel �� 
TargetType��%H   &	        '��        5   
   6   �� 5   
   " ��6   5      5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6&   $��Center=�62   $��70��6M   $��70��6Y   $��10 0 0 0q�6d   �� 5      
�������$��60��6N    � ToolTip$ 
Nueva Fila��6Y   $��25��6n   $|�False��6z   $��10(�6�   $
��Bold"�6�   
��� � �
�������$��30 0 5 0q�6�   ��6   �� *ButtonNewRow+.��5        $	 Add=�6*   5      �� 5      
�������$��60��6Q   $ Borrar Fila��6\   $��25��6r   $|�False��6~   $��10(�6�   $
��Bold"�6�   
���  ��
�������$��0 0 5 0q�6�   ��6   �� *ButtonDeleteRow+.��5         $ Remove=�6*   5!      �� 5"      
�������$��60��6N   $ Limpiar��6Y   $��25��6k   $|�False��6w   $��10(�6�   $
��Bold"�6�   
���  ��
�������$��0 0 5 0q�6�   ��6   �� *ButtonDelete+.��5#        $ Delete=�6*   5$      5%      �� 5'   
   $ 
Horizontal=�6   $��Center=�6.   .+�5(      �� $��Center=�6   $��14(�65   $��60 0 0 0q�6C   $��Center=�6U   $��Total Filas Count: ��6p   
���   �6�   �� 5)      $��Center=�6   $��14(�65   $��Center=�6C   
���   ���6^   �� *_PersonCollecion.Count+6�   �� 5*      $��Center=�6   $��14(�65   $��10 0 0 0q�6C   $��Center=�6U   $��Total Colum Count: 6��6p   
���   �6�   5+      �� 5-   
   $��0��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5/      �� 
�������$��60��6Q   $ Export Excel��6\   $��25��6s   $|�False��6   $��10(�6�   $
��Bold"�6�   
��� � �
�������$��0 0 5 0q�6�   ��6   �� *ButtonSaveExcel+.��50        $ 
FileExport=�6*   51      �� 52      
�������$��60��6Q   $ Import Excel��6\   $��25��6s   $|�False��6   $��10(�6�   $
��Bold"�6�   
��� � �
�������$��0 0 60 0q�6�   ��6   �� *ButtonOpenExcel+.��53        $ 
FileImport=�6*   54      55      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  57   
   $��1��6    $��2q�6-   (  "Syncfusion.UI.Xaml.Grid.SfGridBase	   EditTrigger$	 OnTap=�68   
   ColumnSizer$

 Star=�6L      AllowEditing$
 True��6_      AllowDeleting$
 True��58       
���   �   AutoGenerateColumns$ False��59          SelectedItem 6<   ��  �� Path$ PersonSelect�   ItemsSource 5:       �� *_PersonCollecion+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5=      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   
HeaderText$ ID��6,      AllowEditing$ False��6<      MappingName$ Id��6Q      Width$ 80Q�6b      UpdateTrigger$ PropertyChanged=�6m     5>      $ Nombre��6,   $
 name��6@   $ PropertyChanged=�6S     5?      $ Apellido��6,   $ surName��6B   $ PropertyChanged=�6X   (  "Syncfusion.UI.Xaml.Grid.GridColumn   AllowFiltering$
 True��6x     5@      $
 Edad��6,   $
 edad��6>   $ 80Q�6Q   $ PropertyChanged=�6\   $
 True��6|     5A      $ Telefono��6,   $ telefone��6B   $ 90Q�6Y   $ PropertyChanged=�6e   0  *Syncfusion.UI.Xaml.Grid.GridComboBoxColumn  5B      $ Departamento��60   $ 
department��6J   $ PropertyChanged=�6�   $
 True��6�      ItemsSource 6c   �� $ ListDepartamentos�6�   5D      5E      5F      