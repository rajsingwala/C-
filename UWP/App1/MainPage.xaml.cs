﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            frame.Navigate(typeof(BlankPage1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(BlankPage1));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (frame.CanGoForward)
            {
                frame.GoForward();
            }
        }
    }
}
