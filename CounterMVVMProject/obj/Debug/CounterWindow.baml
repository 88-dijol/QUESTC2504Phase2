   M S B A M L   `   `   `  ����M  ICounterMVVMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CounterMVVMProjectCounterMVVMProject  5   	   &     CounterMVVMProject.CounterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CounterMVVMProject     5   	   -   5          �Name$  Counter_Window��5   	    � Title$ Counter App��5   	   $	��450��6   $	��800��6*   .��5	      �� .+�5
   
   �� -   5         ��Name$ 	txtNumber��5
       �� Left$	 285��6%    �� TextWrapping$
 Wrap=�67   
 �� Top$ 92��6K   $��94��6[    �� TextAlignment$ Center=�6f   $
��Left=�6~   $��34��5      $��Center=�6   {�.  $
��Bold"�6K   $��18(�6]   ��6k   �� *NewCounter.Number+�� 5   
   -   5         ��Name$ btnPlus��5      $��+��6"   $	 165��6.   $	 179��6@   $��Center=�6Q   $	��Top=�6n   $��95��6�   $��28��6�   $
��Bold"�6�   $��18(�6�   ��6�   �� *PlusCommand+�� 5   
   -   5        $ btnMinus��5      $��-��6#   $	 402��6/   $	 177��6A   $��95��6R   $��28��6]   $
��Left=�6i   $	��Top=�6�   $��18(�6�   $
��Bold"�6�   ��6�   �� *MinusCommand+5      5      