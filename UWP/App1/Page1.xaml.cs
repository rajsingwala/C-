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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            App.val = textbox.Text;
            Frame.Navigate(typeof(Page2), textbox.Text);
        }
        private void HyperlinkButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hamburger));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!String.IsNullOrEmpty(App.val))
            {
                textbox.Text = App.val;
            }
        }

        private void CheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tx.Text = cb.IsChecked.ToString();
        }

        private void radio_Checked(object sender, RoutedEventArgs e)
        {
            tx2.Text = (bool)yes_radio.IsChecked ? "YES" : "NO";
        }

        private void comb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (tx3 == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            tx3.Text = item.Content.ToString();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = litb.Items.Cast<ListBoxItem>().Where(p => p.IsSelected).Select(t => t.Content.ToString()).ToArray();

            tx4.Text = string.Join(",",items);
        }

     
    }
}
