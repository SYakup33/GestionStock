   M S B A M L   `   `   `  ����G  CGestionStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GestionStock.vueGestionStock.vue  5   	   %    GestionStock.vue.CategoriesForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GestionStock.vue     5   	     � Title$  CategoriesForm��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� $��Nom Catégorie :��6   $
��Left=�6*   $��
10,140,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Annee d'exercice :��6   $
��Left=�6-   $��
10,207,0,0q�6H   $	��Top=�6\    J� RenderTransformOrigin$ 0.641,0.837&�6t   �� 5   
   $
��Left=�6   $��127,144,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��120��6n   �� 5   
   $
��Left=�6   $��127,211,0,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��120��6n   � 5   
   $��490,76,31,205q�6   ��5      
� 5      .��5      �  � Color$ Black��6#    � Offset$ 1Q�61   � 5      $ White��6#   $ 0Q�61   5       � ColumnDefinitions 5      �� 5      -   5         ��Name$ GRIDReferenceCategorie��5   #   �� 5      -   5        $ GRIDNomCategorie��5   #   �� 5      -   5        $ GRIDAnneeExercice��5   #   5      �� 5   
   $	��Add��6   $
��Left=�6   $��433,373,0,0q�6:   $	��Top=�6O   $��26��6g   $��66��6s   4  .System.Windows.Automation.AutomationProperties   Name$	 Add��6~   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FF7CD679��6#   $ 1Q�65   5       5"      �� 5#   
   $
��Edit��6   $
��Left=�6    $��512,373,0,0q�6;   $	��Top=�6P   $��26��6h   $��66��6t   ��5$      �� 5%      $ 0.5,1&�6&   $	 0.5,0&�67   .��5&      � $ Black��6#   � 5'      $ 	#FFDAD20F��6#   $ 1Q�65   5(      5*      �� 5+   
   $��Delete��6   $
��Left=�6"   $��593,373,0,0q�6=   $	��Top=�6R   $��26��6j   $��66��6v   ��5,      �� 5-      $ 0.5,1&�6&   $	 0.5,0&�67   .��5.      � $ Black��6#   � 5/      $ 	#FFE61212��6#   $ 1Q�65   50      52      �� 53   
   $��Cancel��6   $
��Left=�6"   $��673,373,0,0q�6=   $	��Top=�6R   $��26��6j   $��66��6v   ��54      �� 55      $ 0.5,1&�6&   $	 0.5,0&�67   .��56      � $ Black��6#   � 57      $ 	#FF0E83DE��6#   $ 1Q�65   58      5:      5<      5=      