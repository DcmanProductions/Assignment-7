   M S B A M L   `   `   `  ����`  \Assignment 7 - Cypher Encoder Decoder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Assignment_7___Cypher_Encoder_Decoder%Assignment_7___Cypher_Encoder_Decoder  5   	   6    0Assignment_7___Cypher_Encoder_Decoder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:Assignment_7___Cypher_Encoder_Decoder     5   	     � Title$  Caesar Cipher��5   	   $	��600��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��205* �6   �� 5      $
��312* �6   .+�5   
   � $
��Left=�6   $
��auto��6*   $��	10,10,0,0q�68   $	��Top=�6K   $
��auto��6c   $��2��6p   o� 5   
   $
��Left=�6   $
��auto��6*   $	��Top=�68   $
��auto��6P   $��2��6]   o� 5   
   $
��Left=�6   $��26��6*   $	��Top=�66   $	��100��6N   .@�5      m� -   5         m�Name$ 	File_Menu��5      $
��File��6*   $��26��68   $	��789��6D   .@�5      m� -   5        $��	Save File��5      $
��Left=�6.   $��39��6I   $	��140��6U   6a   m� 5      -   5        $ Open_File_Menu��5      $��	Open File��63   $
��Left=�6F   $��32��6a   $	��140��6m   6y   5      5      �� 5   
   -   5         ��Name$ EncryptButton��5      $��Encrypt��6(   $
��Left=�6:   $��
95,530,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ DecryptButton��5      $��Decrypt��6(   $��1��6:   $
��Left=�6J   $��252,530,0,0q�6e   $	��Top=�6z   $��74��6�   6�   �� 5   
   -   5         ��Name$ EncryptionText��5      $
��Left=�6*   $	��461��6E   $��	10,31,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��756��6�   $��2��6�   ]� 5   
   $
��Left=�6   $��31��6/   ��.  $	��Top=�6Q   $	��782��6i   $��2��6u   5      5      