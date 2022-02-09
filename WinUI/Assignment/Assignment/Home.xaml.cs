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

using Assignment.Models;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Payload payload { set; get; }
      
        public Home()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            payload = (Payload)e.Parameter;
            payload.Framework = new List<Collection>();
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textbox.Text) || combox.SelectedIndex == -1 || (react.IsChecked == false && vue.IsChecked == false && angular.IsChecked == false && mongo.IsChecked == false && node.IsChecked == false) || (radio_no.IsChecked == false && radio_yes.IsChecked == false) || date.SelectedDate == null)
            {
                warning.Text = "Please add all fields";
                return;
            }

            payload.Text = textbox.Text;
            Frame.Navigate(typeof(Details),payload);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
            combox.SelectedIndex = -1;
            react.IsChecked = false;
            vue.IsChecked = false;
            angular.IsChecked = false;
            mongo.IsChecked = false;
            node.IsChecked = false;
            radio_yes.IsChecked = false;
            radio_no.IsChecked = false;
            date.SelectedDate = null;
            warning.Text = "";

        }

        private void combox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            if(combox.SelectedValue != null)
            payload.Language = item.Content.ToString();
        }

        private void date_SelectedDateChanged(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
        {
            if(date.SelectedDate != null)
            payload.Date = date.SelectedDate.Value.Date.ToString("dd/MM/yy");
        }

        private void radio_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)radio_yes.IsChecked)
            {
                payload.Val = "Yes";
            }
            else if ((bool)radio_no.IsChecked)
            {
                payload.Val = "No";
            }
        }

        private void react_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)react.IsChecked)
            {
                payload.Framework.Add(new Collection { Val = "React" });
            }
            else
            {
                payload.Framework.RemoveAll(item => item.Val == "React");
            }
        }

        private void vue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)vue.IsChecked)
            {
                payload.Framework.Add(new Collection { Val = "Vue" });
            }
            else
            {
                payload.Framework.RemoveAll(item => item.Val == "Vue");
            }
        }

        private void angular_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)angular.IsChecked)
            {
                payload.Framework.Add(new Collection { Val = "Angular" });
            }
            else
            {
                payload.Framework.RemoveAll(item => item.Val == "Angular");
            }
        }

        private void mongo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)mongo.IsChecked)
            {
                payload.Framework.Add(new Collection { Val = "MongoDB" });
            }
            else
            {
                payload.Framework.RemoveAll(item => item.Val == "MongoDB");
            }
        }

        private void node_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)node.IsChecked)
            {
                payload.Framework.Add(new Collection { Val = "Nodejs" });
            }
            else
            {
                payload.Framework.RemoveAll(item => item.Val == "Nodejs");
            }
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            payload.Text = textbox.Text;
        }
    }
}
