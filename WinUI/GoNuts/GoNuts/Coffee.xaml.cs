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
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffee : Page
    {
        private string _roast;
        private string _sweet;
        private string _cream;
        public Coffee()
        {
            this.InitializeComponent();
        }

       
        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            display();
        }

        private void Sweetner_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweet = selected.Text;
            display();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _cream = selected.Text;
            display();
        }

        private void display()
        {
            if(_roast == "None" || string.IsNullOrEmpty(_roast))
            {
                coffee.Text = "None";
                return;
            }

            coffee.Text = _roast;

            if (_cream != "None" || !string.IsNullOrEmpty(_cream))
                coffee.Text += "+" + _cream;


            if (_sweet != "None" || !string.IsNullOrEmpty(_sweet))
                coffee.Text += "+" + _sweet;
        }
    }
}
