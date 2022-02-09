    using Microsoft.UI.Xaml;
using System.Linq;

using System.Collections.ObjectModel;
using API.Models;
using static API.Services;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace API
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<Datum> IdCollection { get; set; }
        public Lazy<ObservableCollection<ZFormat>> ProductCollection { get; set; }
        public MainWindow()
        {
            this.InitializeComponent();
            IdCollection = new ObservableCollection<Datum>();
            ProductCollection = new Lazy<ObservableCollection<ZFormat>>();
        }

        private async void ProductApi()
        {
            foreach (var item in IdCollection)
            {
                await GetProduct.ProductAsync(ProductCollection, item.ID);
            }
            //await GetProduct.ProductAsync(ProductCollection, 1003368);

        }
         
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    await ProductId.PopulateIdAsync(IdCollection);
            //    ProductApi();
            //}
            //catch
            //{
            //    tbl1.Text = "Enable to fetch data";
            //}


            //Get Product from database
            await ProductStore.EnsureProductStore();
            var items = await ProductStore.GetProducts();

            items.ToList().ForEach(ProductCollection.Value.Add);
        }
    }
}
