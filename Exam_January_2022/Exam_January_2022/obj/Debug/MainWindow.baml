   M S B A M L   `   `   `  ����L  HExam_January_2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Exam_January_2022Exam_January_2022  5   	   "    Exam_January_2022.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Exam_January_2022     5   	     � Title$  Main Window��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ LSTBX_MembersList��5
      $
��Left=�6-   $	��245��6H   $��	40,90,0,0q�6U   $	��Top=�6h   $	��235��6�   6�   �� 5   
   $��Member List��6   $
��Left=�6&   $��	35,64,0,0q�6A   $	��Top=�6T   $��88��6l   �� 5   
   -   5         ��Name$ 	TBLK_Name��5      $
��Left=�6'   $��
310,99,0,0q�6B   $
��Wrap=�6V   $��	TextBlock��6j   $	��Top=�6{   $	��140��6�   �� 5   
   $��Member Details��6   $
��Left=�6)   $��
302,64,0,0q�6D   $	��Top=�6X   �� 5   
   $��
Basic Fee:��6   $
��Left=�6%   $��305,145,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $ TBLK_BasicFee��5      $
��Left=�6+   $��436,150,0,0q�6F   $
��Wrap=�6[   $��	TextBlock��6o   $	��Top=�6�   �� 5   
   $��Payment schedule:��6   $
��Left=�6,   $��305,172,0,0q�6G   $	��Top=�6\   �� 5   
   -   5        $ TBLK_PaymentSchedule��5      $
��Left=�62   $��438,178,0,0q�6M   $
��Wrap=�6b   $��	TextBlock��6v   $	��Top=�6�   �� 5   
   $��Renewal date:��6   $
��Left=�6(   $��305,200,0,0q�6C   $	��Top=�6X   �� 5   
   $��
Join Date:��6   $
��Left=�6%   $��305,119,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $ TBLK_RenewalDate��5      $
��Left=�6.   $��436,204,0,0q�6I   $
��Wrap=�6^   $��	TextBlock��6r   $	��Top=�6�   �� 5   
   -   5        $ TBLK_JoinDate��5      $
��Left=�6+   $��436,125,0,0q�6F   $
��Wrap=�6[   $��	TextBlock��6o   $	��Top=�6�   	� 5   
   -   5         	�Name$ 	RDBTN_All��5      $	��All��6)   $
��Left=�67   $��
40,365,0,0q�6R   $	��Top=�6f    	� 	GroupName$ 
FilterType��6~   6�   	� 5   
   -   5        $ RDBTN_Regular��5      $��Regular��6-   $
��Left=�6?   $��
85,365,0,0q�6Z   $	��Top=�6n   $ 
FilterType��6�   6�   	� 5   
   -	   5        $ RDBTN_Senior��5      $��Senior��6,   $
��Left=�6=   $��155,365,0,0q�6X   $	��Top=�6m   $ 
FilterType��6�   6�   	� 5   
   -
   5        $ RDBTN_Junior��5      $��Junior��6,   $
��Left=�6=   $��215,365,0,0q�6X   $	��Top=�6m   $ 
FilterType��6�   6�   �� 5   
   $��Days to renewal:��6   $
��Left=�6+   $��304,225,0,0q�6F   $	��Top=�6[   �� 5   
   -   5        $ TBLK_DaysToRenewal��5      $
��Left=�60   $��436,230,0,0q�6K   $
��Wrap=�6`   $��	TextBlock��6t   $	��Top=�6�   �� 5   
   $��Member Type:��6   $
��Left=�6'   $��304,250,0,0q�6B   $	��Top=�6W   �� 5   
   -   5        $ TBLK_MemberType��5      $
��Left=�6-   $��436,255,0,0q�6H   $
��Wrap=�6]   $��	TextBlock��6q   $	��Top=�6�   5      5       