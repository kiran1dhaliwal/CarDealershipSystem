   M S B A M L   `   `   `  ����N  JCarDealershipSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CarDealershipSystemCarDealershipSystem  5      M+clr-namespace:CarDealershipSystem.Models.DBCarDealershipSystem.Models.DB  5      '    !CarDealershipSystem.AddEmployeeUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CarDealershipSystem     5      :DB+clr-namespace:CarDealershipSystem.Models.DB     5      -   5        $��626.223��5      $��489.017��6/     � 	Resources  5	         employeeViewSource��%   &	        �� 5
   
   6   5      .��5      � .+�5   
   �� -   5        $��btnAdd��5      $	��ADD��5      $��20(�6   $
��Left=�5      $��239,379,0,0q�6,   $	��Top=�6A   $	��119��6Y   6e   � 5   
   -   5         �Name$ grid1��5       � DataContext# [  6   $
��Left=�6P   $��
198,81,0,0q�6k   $	��Top=�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Office Address:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5       -   5         ��Name$ officeAddressTextBox��5       $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��0��6v   $��Center=�6�   $	��120��6  ��6�   �� *OfficeAddress+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  �� 5!      $��	Password:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��1��6^   $��Center=�6k   �� 5"      -   5        $ passwordTextBox��5"      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��1��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
Password+$ TwoWay=� .  . 6�   �� 5#      $��Phone Extension:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��2��6e   $��Center=�6r   �� 5$      -   5        $ phoneExtensionTextBox��5$      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��2��6w   $��Center=�6�   $	��120��6  ��6�   �� *PhoneExtension+$ TwoWay=� .  . 6  �� 5%      $��Role:��6   $��0��6$   $
��Left=�64   $��3q�6O   $��3��6Z   $��Center=�6g   �� 5&      -   5        $ roleTextBox��5&      $��1��6+   $
��Left=�6;   $��23��6V   $��3q�6b   $��3��6m   $��Center=�6�   $	��120��6�   ��6z   �� *Role+$ TwoWay=� .  . 6�   �� 5'      $��	Username:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��4��6^   $��Center=�6k   �� 5(      -   5        $ usernameTextBox��5(      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��4��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
Username+$ TwoWay=� .  . 6�   �� 5)      $��Address:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��5��6]   $��Center=�6j   �� 5*      -	   5        $ addressTextBox��5*      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��5��6p   $��Center=�6�   $	��120��6  ��6}   �� *EmployeeNavigation.Address+$ TwoWay=� .  . 6  �� 5+      $��Name:��6   $��0��6$   $
��Left=�64   $��3q�6O   $��6��6Z   $��Center=�6g   �� 5,      -
   5        $ nameTextBox��5,      $��1��6+   $
��Left=�6;   $��23��6V   $��3q�6b   $��6��6m   $��Center=�6�   $	��120��6  ��6z   �� *EmployeeNavigation.Name+$ TwoWay=� .  . 6  �� 5-      $��Phone:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��7��6[   $��Center=�6h   �� 5.      -   5        $ phoneTextBox��5.      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��7��6n   $��Center=�6�   $	��120��6  ��6{   �� *EmployeeNavigation.Phone+$ TwoWay=� .  . 6  5/      51      52      