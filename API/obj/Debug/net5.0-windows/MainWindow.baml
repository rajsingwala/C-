   M S B A M L   `   `   `  ����>  :API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:API.ViewModel.ValueConverterAPI.ViewModel.ValueConverter  5      clr-namespace:APIAPI  5          API.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @	converter*clr-namespace:API.ViewModel.ValueConverter     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:API     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5	      $	��800��5
      $	��450��5      .��5      N� -   5         � 	Resources 5   
   *   $API.ViewModel.ValueConverter.Graphic   graphic��%   &	          5      6    5      .��5   
   � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AlternatingRowBackground
 �����   AutoGenerateColumns$ False��5         GridLinesVisibility$	 All=�5      ��5      �� *ProductCollection+ �� IsAsync$
 True��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product SKU��5      	   
IsReadOnly$
	 True��5      1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5      �� *
ProductSKU+5        5       $ Product Name��5"      $
	 True��5#      
 5!      �� *ProductName+5#        5$      $ Product Type��5&      $
	 True��5'      
 5%      �� *Product_type+5'        5(      $ Graphic��5*      $
	 True��5+      
 5)      �� *	Graphic+ �� 	Converter# [  5+        5,      $ Color��5.      $
	 True��5/      
 5-      �� *Color+5/        50      $ 
ColorInHex��52      $
	 True��53      
 51      �� *
ColorInHex+53        54      $
 Size��56      $
	 True��57      
 55      �� *Size+57        58      $ Weight��5:      $
	 True��5;      
 59      �� *Weight+5;      5=      5>      5?      5@      