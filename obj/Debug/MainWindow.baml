   M S B A M L   `   `   `  ����G  C编码助手, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  编码转换小工具��5   	   $	��450��6   $	��311��6&   .��5	      �  J� RenderTransformOrigin$ 0.509,0.501&�6    � Cursor$  ��6/   $��0,0,12,0q�69    � ColumnDefinitions 5
   
   �� 5      $��9* �6   �� 5      $��5* �6   �� 5      $
��204* �6   �� 5      $
��Auto �6   �� 5      $	��67* �6   �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ Button1��5      $��base64编码��6"   $
��Left=�65   $��27��6P   $��
30,155,0,0q�6\   $	��Top=�6p    � ForceCursor . $��2��6�   $	��100��6�   �� 5   
   -   5        $ Button2��5      $��base64解码��6"   $
��Left=�65   $��27��6P   $��156,155,0,0q�6\   $	��Top=�6q   $	��100��6�   $��2��6�   $��3��6�   �� 5   
   -   5        $ Button3��5      $��unicode编码��6"   $
��Left=�66   $��27��6Q   $��
30,200,0,0q�6]   $	��Top=�6q   $	��100��6�   $��2��6�   6�   �� 5   
   -   5        $ Button4��5      $��unicode解码��6"   $
��Left=�66   $��27��6Q   $��156,200,0,0q�6]   $	��Top=�6r   $	��100��6�   $��2��6�   $��3��6�   �� 5   
   -   5        $��TextBox��5      $
��Left=�6!   $	��140��6<   $��	10,10,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $��请输入...��6p   $	��Top=�6~   $	��252��6�   $��2��6�   $��3��6�   �� 5   
   -   5        $��	URL编码��5      $��2��6!   $
��Left=�61   $��
30,250,0,0q�6L   $	��Top=�6`   $	��100��6x   $��27��6�   6�   �� 5   
   -   5        $��	URL解码��5      $��2��6!   $
��Left=�61   $��156,250,0,0q�6L   $	��Top=�6a   $	��100��6y   $��27��6�   $��3��6�   �� 5   
   -   5        $��html实体编码��5      $��2��6$   $
��Left=�64   $��
91,339,0,0q�6O   $	��Top=�6c   $	��100��6{   $��27��6�   6�   �� 5   
   -	   5        $��utf-8 -> gb2312��5      $��2��6.   $
��Left=�6>   $��
30,291,0,0q�6Y   $	��Top=�6m   $	��100��6�   $��27��6�   6�   �� 5   
   -
   5        $��gb2312 -> utf-8��5      $��2��6.   $
��Left=�6>   $��156,291,0,0q�6Y   $	��Top=�6n   $	��100��6�   $��27��6�   $��3��6�   �� 5   
   -   5        $��关于��5      $��2��6   $
��Left=�6.   $��
91,382,0,0q�6I   $	��Top=�6]   $	��100��6u   $��27��6�   6�   �� 5   
   -   5        $��zhiding��5      $��3��6    $��置
顶��64   $
��Left=�6G   $	��140��6b   $��0,10,0,0q�6o   $��19��6�   $	��Top=�6�   6�   5      5       