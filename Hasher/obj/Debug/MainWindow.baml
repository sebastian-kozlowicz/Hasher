   M S B A M L   `   `   `  ����A  =Hasher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HasherHasher  5   	       Hasher.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Hasher     5   	     � Title$  Hasher��5   	   $	��700��6   $	��400��6%   .��5	      ��  �� Padding$ 10q�6   ��5
   
   �� 5       �� 
StartPoint$ 0.5,0&�6"    �� EndPoint$ 0.5,1&�65   .��5      �  � Color$ #0087ef��6    � Offset$ 0Q�6/   � 5      $ 	#FFFFFFFF��6   $	 1.5Q�61   5      ._�5   
   �� .+�5      �� $��Text to encode��6   $
��Bold"�6.   �� 5      -   5         ��Name$ rawText��5      $��50��6<   $
��0 10q�6H   � 5      $��30��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ 
SaveButton��5      $��0��6F   $
��Save��6V   $
��Bold"�6e   $
��50 0q�6w   ���#00ad02$	��1.5q�6�   
�������6�   �� 5      -   5        $ ClearButton��5      $��1��6H   $��Clear��6X   $
��Bold"�6h   $
��50 0q�6z   ���#ffa807$	��1.5q�6�   
�������6�   5      �� 5"      $��MD5 Hash��6   $
��Bold"�6(   $
��0 10q�6:   �� 5#      -   5        $ MD5HashText��5#      $��50��6+   	 �� 
IsReadOnly	 . 67   �� 5%      $��
SHA-1 Hash��6   $
��Bold"�6*   $
��0 10q�6<   �� 5&      -   5        $ SHA1HashText��5&      $��50��6,   	 . 68   �� 5(      $��SHA-256 Hash��6   $
��Bold"�6,   $
��0 10q�6>   �� 5)      -   5        $ SHA256HashText��5)      $��50��6.   
 �� TextWrapping$

 Wrap=�6:   	 . 6N   �� 5+      $��SHA-384 Hash��6   $
��Bold"�6,   $
��0 10q�6>   �� 5,      -   5        $ SHA384HashText��5,      $��50��6.   $

 Wrap=�6:   	 . 6N   �� 5.      $��SHA-512 Hash��6   $
��Bold"�6,   $
��0 10q�6>   �� 5/      -   5        $ SHA512HashText��5/      $��50��6.   $

 Wrap=�6:   	 . 6N   �� 51      $��RIPEMD160 Hash��6   $
��Bold"�6.   $
��0 10q�6@   �� 52      -	   5        $ RIPEMD160HashText��52      $��50��61   $

 Wrap=�6=   	 . 6Q   54      55      56      