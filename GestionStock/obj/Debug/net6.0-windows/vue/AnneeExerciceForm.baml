   M S B A M L   `   `   `  ����G  CGestionStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GestionStock.vueGestionStock.vue  5   	   7 clr-namespace:GestionStock.modelGestionStock.model  5   	   (    "GestionStock.vue.AnneeExerciceForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GestionStock.vue     5   	   2model clr-namespace:GestionStock.model     5   	     � Title$  AnneeExerciceForm��5	   	   $	��450��6#   $	��800��60   .��5
      � .+�5   
   �� $��Annee d'exrcice :��6   $
��Left=�6,   $��
10,145,0,0q�6G   $	��Top=�6[    J� RenderTransformOrigin$ 0.641,0.837&�6s   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ AnneeExerciceFrom��5      $
��Left=�60   $��135,124,0,0q�6K   $	��Top=�6`   $��93��6x   $	��209��6�      IsTodayHighlighted$
 True��6�   �� 5   
   -   5         ��Name$	 Add��5      $	��Add��6   $
��Left=�6,   $��433,373,0,0q�6G   $	��Top=�6\   $��26��6t   $��66��6�   4  .System.Windows.Automation.AutomationProperties   Name$	 Add��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ 	#FF7CD679��6#   	 � Offset$	 1Q�65   5      5      �� 5   
   $
��Edit��6   $
��Left=�6    $��512,373,0,0q�6;   $	��Top=�6P   $��26��6h   $��66��6t   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FFDAD20F��6#   $	 1Q�65   5      5      �� 5   
   $��Delete��6   $
��Left=�6"   $��593,373,0,0q�6=   $	��Top=�6R   $��26��6j   $��66��6v   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5       � $ Black��6#   � 5!      $ 	#FFE61212��6#   $	 1Q�65   5"      5$      �� 5%   
   -   5        $ Close��5%      $��Cancel��6    $
��Left=�61   $��673,373,0,0q�6L   $	��Top=�6a   $��26��6y   $��66��6�   ��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ Black��6#   � 5)      $ 	#FF0E83DE��6#   $	 1Q�65   5*      5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        
  Name$
 Grille��5-      $��400,0,0,101q�6N   $
��Left=�6c   $	��346��6~   $	��323��6�   $��Bottom=�6�    � DataContext 5.      &   GestionStock.model.AnneeExercice  5/      51      53      54      