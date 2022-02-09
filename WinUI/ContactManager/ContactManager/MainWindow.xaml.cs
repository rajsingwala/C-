using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using ContactManager.Model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ContactManager
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private ObservableCollection<Contact> list { get; set; }
        private List<Icon> imgList { set; get; }
        public MainWindow()
        {
            this.InitializeComponent();
            list = new ObservableCollection<Contact>();
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            imgList = new List<Icon>();
            imgList.Add(new Icon { path="Images/female-01.png" });
            imgList.Add(new Icon { path="Images/female-02.png" });
            imgList.Add(new Icon { path="Images/female-03.png" });
            imgList.Add(new Icon { path="Images/male-01.png" });
            imgList.Add(new Icon { path="Images/male-02.png" });
            imgList.Add(new Icon { path="Images/male-03.png" });
        
            listimg.ItemsSource = imgList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = ((Icon)listimg.SelectedValue).path;
            list.Add(new Contact { f_name = fname.Text,l_name=lname.Text,img=path});

            fname.Text = "";
            lname.Text = "";
           listimg.SelectedIndex= -1;
        }
    }
}
