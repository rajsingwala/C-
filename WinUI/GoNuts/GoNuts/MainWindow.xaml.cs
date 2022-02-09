using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GoNuts
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Donuts));
        }

        private void donutBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Donuts));
        }

        private void coffeeBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Coffee));
        }

        private void schBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Schedule));
        }

        private void comBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Complete));
        }

       

        
    }
}
