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

using SQL_Lite.Model;
using SQLite;
using System.Collections.ObjectModel;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SQL_Lite
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public List<Contact> list;
        public MainWindow()
        {
            this.InitializeComponent();
            list = new List<Contact>();
            ReadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact con = new Contact()
            {
                Name = name.Text,
                Email = email.Text,
                Phone = contact.Text
            };
           
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(con);
            }
            ReadData();
        }

        void ReadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                list = (connection.Table<Contact>().ToList()).OrderBy(p=>p.Name).ToList();

                listView.ItemsSource = list;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = (TextBox)sender;

            var data = list.Where(p => p.Name.ToLower().Contains(item.Text.ToLower())).ToList();
            listView.ItemsSource = data;
        }

       
    }
}
