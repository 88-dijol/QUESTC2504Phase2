   M S B A M L   `   `   `  ����I  EBankingProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BankingProjectBankingProject  5   1  &     BankingProject.AccountListWindow   6	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    64   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6v   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   .localclr-namespace:BankingProject     61  -   5          � Title$  AccountListWindow��5   m  $	��450��6�  $	��800��6�  .��5      � $
��1000��6   $��10 10 10 10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5	   
   �� $��0��6   $��Account Manager��6!   $��24(�5
      $
��bold"�5       �� TextAlignment$ center=�5      �� 5   
   -   5        $��1��5      $��Add Account��6   $	��200��64   $��30��6@   $��0 10 0 0q�6L   $
��left=�6^   
��� ���
���   �$
��bold"�5   4   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdAccounts��5      $��2��6(   $��0 10 0 0q�65      
IsReadOnly .    AreRowDetailsFrozen .    AutoGenerateColumns .     SelectionMode$ Single=�5       �� SelectedItem 5   Y   �� *SelectedAccount+	 �� Mode$	 TwoWay=���5   &   �� *
Accounts+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Account Number��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *AccNo+  5      $
 Name��6%    63   �� *Name+  5      $ Balance��6%    66   �� *	Balance+  5      $
 Type��6%    63   �� *	AccType+  5      $ Email��6%    64   �� *Email+  5      $ Phone Number��6%    6;   �� *PhoneNumber+  5      $ Address��6%    66   �� *	Address+  5      $ IsActive��6%    67   �� *
IsActive+  5      $ Interest Percentage��6%    6B   �� *InterestPercentage+  5      $ Transaction Count��6%    6@   �� *TransactionCount+  5      $ Last Transaction Date��6%    6D   �� *LastTransactionDate+5"      �� 5$   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5&      �� -   5         ��Name$ btnView��5&      $��View Account��6&   $	��190��6=   $��30��6I   
��� ���
���   �$
��bold"�5'   4   $��
0 10 10 10q�5(      6!   �� 5*      -   5        $��3��5*      $��Update Account��6"   $	��200��6;   $��30��6G   $��0,5,0,5q�5+      $
��Left=�6   
��� ���
���   �$
��bold"�5,   4   5-      54      58      59      