   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H   .��5	      � $��	0,0,10,10q�6   .+�5
   
   �� -   5         ��Name$ 
txtPromien��5
      $
��Left=�6&   $��
120,22,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $��0��6i   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ txtWysokosc��5      $
��Left=�6'   $��
120,55,0,0q�6B   $
 Wrap=�6V   $��0��6j   $	��Top=�6s   $	��120��6�    � Cursor$  ��6�   �� 5   
   $��Promień��6   $
��Left=�6"   $��	11,18,0,0q�6=   $	��Top=�6P   $	��104��6h   �� 5   
   -   5         ��Name$ lblWysokosc��5      $��Wysokość
��6%   $
��Left=�6B   $��	10,52,0,0q�6]   $	��Top=�6p   $	��105��6�   $��27��6�   �� 5   
   -   5         ��Name$ 	btnOblicz��5      $��Oblicz��6$   $
��Left=�65   $��
175,88,0,0q�6P   $	��Top=�6d   $��65��6|   6�   �� 5   
   -   5        $ lblWynik��5      $�� ��6"   $
��Left=�6-   $��
11,122,0,0q�6H   $	��Top=�6\   $	��300��6t   �� 5   
   -   5         ��Name$ cmbBryly��5      $
��Left=�6%   $��
278,53,0,0q�6@   $	��Top=�6T   $	��186��6l   	 �� SelectedIndex$	 0��6x   .@�5      �� $��Walec��6   �� 5      $��Stożek��6   �� 5      $
��Kula��6   5      �� 5   
   -   5        
 ��Name$
 chkObj��5      $��Objętość��6#   $
��Left=�66   $��
278,22,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ 0.504,0.599&�6}   �� 5   
   -   5        $
 chkPole��5      $��Pole powierzchni��6$   $
��Left=�6?   $��
355,22,0,0q�6Z   $	��Top=�6n   �� 5   
   -	   5        $ lblPow��5      $�� ��6    $
��Left=�6+   $��
11,153,0,0q�6F   $	��Top=�6Z   $	��300��6r   �� 5   
   -
   5        $ btnClose��5      $��Zamknij��6#   $
��Left=�65   $��
10,399,0,0q�6P   $	��Top=�6d   $��25��6|   $��92��6�   6�   �� 5   
   -   5        $ 	btnRysuj1��5      $��Rysuj1��6$   $��23��66   $��89��6B   $��371,184,330,284q�6e   �� 5   
   -   5        $ btnClear��5      $��Czyść płótno��6#   $��22��6;   $��89��6G   $��371,458,330,10q�6i   �� 5   
   -   5         ��Name$ cnvObraz��5      $	��300��6#   $	��300��63   $	��300��6B   $	��300��6R   ���	#FF01BFFF$��477,177,0,0q�6x   5      �� 5   
   -   5        $ 	btnElipsa��5      $��Rysuj3��6$   $
��Left=�65   $��371,225,0,0q�6P   $	��Top=�6e   $��89��6}   6�   �� 5   
   -   5        $ btnKolo��5      $��Rysuj Koło��6"   $
��Left=�67   $��371,262,0,0q�6R   $	��Top=�6g   $��89��6   6�   �� 5   
   -   5        $ 	btnDrzewo��5      $��Rysuj Drzewo��6$   $
��Left=�6;   $��371,297,0,0q�6V   $	��Top=�6k   $��89��6�   6�   5!      5"      