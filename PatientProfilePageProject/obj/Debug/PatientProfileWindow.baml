   M S B A M L   `   `   `  ����T  PPatientProfilePageProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PatientProfilePageProjectPatientProfilePageProject  5   	   4    .PatientProfilePageProject.PatientProfileWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PatientProfilePageProject     5   	     � Title$  Patient Profile Window��5   	   $	��450��6(   $	��800��65    � WindowState$ 	Maximized=�6A   .��5       � ��5!   
   �� 5"       �� ImageSource$ /background image.jpg��6    �� Opacity$
 0.95Q�6=    � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6    � ColumnDefinitions 5.   
   �� 5/      $��* �6   �� 50      $��* �6   .+�53   
   ��  �� TextAlignment$ Center=�6   $
��Wrap=�6,   $��PATIENT PROFILE ��6@   $	��799��54      $��62��6    $��36(�6,   $
��Bold"�6:   
�������$��Georgia)�55   '   $��0��6<   $��2��6I   $��Center=�6]   {�.  6x   �� 57   
   -   5         ��Name$ lblName��57      $
��Wrap=�6%   $
��Name��69   $��18(�58      
���**��$��1��59      $��0��6!   $��5q�61   $��Center=�6<   $
��Bold"�6W   $��Center=�6i   �� 5:   
   -   5         ��Name$ txtName��5:      	 �� TextWrapping$
	 Wrap=�6#   $	��300��5;      $��18(�6   ���	#FFDACACA$��1��5<      $��1��6   $��Center=�60   $��28��6K   $
��Left=�6W   �� 5>   
   -   5        $ lblDateofBirth��5>      $
��Wrap=�6,   $��Date of Birth��5?      $��18(�6)   
���**��$��2��5@   '   $��0��64   $��5q�6D   $��Center=�6O   $��Center=�6j   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5A   
   $��2��6   $��1��6"   $��5q�62   $	��300��5B      $��28��6"   $��Center=�6.   $
��Left=�6I   �� 5D   
   -   5        $ lblMedicalConditions��5D      $
��Wrap=�62   $��Medical Conditions��5E      $��18(�6.   $��Center=�6<   
���**��$��3��5F   '   $��0��64   $��5q�6D   $��Center=�6O   $
��Bold"�6j   �� 5G   
   -   5        $ txtMedicalConditions��5G      $
	 Wrap=�60   $	��300��5H      $��18(�6   ���	#FFDACACA$��3��5I      $��1��6   $��5q�6/   $��28��6:   $��Center=�6F   $
��Left=�6a   �� 5K   
   -   5        $ lblAllergies��5K      $
��Wrap=�6*   $��	Allergies��5L      $��18(�6%   $��Center=�63   
���**��$��4��5M   '   $��0��64   $��5q�6D   $��Center=�6O   $
��Bold"�6j   �� 5N   
   -   5        $ txtAllergies��5N      $
	 Wrap=�6(   $	��300��5O      $��18(�6   ���	#FFDACACA$��4��5P      $��1��6   $��5q�6/   $��28��6:   $��Center=�6F   $
��Left=�6a   �� 5R   
   -   5        $ lblEmergencyContacts��5R      $
��Wrap=�62   $��Emergency Contacts��5S      $��18(�6.   $��Center=�6<   
���**��$��5��5T   '   $��0��64   $��5q�6D   $��Center=�6O   $
��Bold"�6j   �� 5U   
   -	   5        $ txtEmergecyContacts��5U      $
	 Wrap=�6/   $	��300��5V      $��18(�6   ���	#FFDACACA$��5��5W      $��1��6   $��5q�6/   $��28��6:   $��Center=�6F   $
��Left=�6a   �� 5Y   
   -
   5        
 ��Name$
 btnSave��5Y      $��Save Profile��6"   $
��Left=�5Z      $��Center=�6,   $	��131��5[      $��31��6   $
��Bold"�6)   $��18(�6;   
���**��
���**��$��6��5]      $��1��6   $��5q�6.   �� 5_   
   $	��Top=�5`      ��5a      �� 5b       j� Stretch$
 Fill=�6   5d      5e      5f      