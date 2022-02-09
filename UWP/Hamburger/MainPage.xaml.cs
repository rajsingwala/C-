using System;
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

namespace Hamburger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            item1.IsSelected = true;
            back_btn.Visibility = Visibility.Collapsed;
        }

        private void ham_btn_Click(object sender, RoutedEventArgs e)
        {
            split_view.IsPaneOpen = !split_view.IsPaneOpen;
           
        }

        private void list_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (item1.IsSelected)
            {
                MyFrame.Navigate(typeof(Financial));
                item1.IsSelected = true;
                back_btn.Visibility = Visibility.Collapsed;
                tbl1.Text = "Financial";
            }
            else if (item2.IsSelected)
            {
                MyFrame.Navigate(typeof(Food));
                item2.IsSelected = true;
                back_btn.Visibility = Visibility.Visible;
                tbl1.Text = "Food";
            }
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                item1.IsSelected = true;
                back_btn.Visibility = Visibility.Collapsed;
            }
        }
    }
}
