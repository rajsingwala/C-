using System.Windows;
using System.Collections.ObjectModel;
using API.Models;
using static API.Services;
using System;

namespace API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Datum> IdCollection { get; set; }
        public Lazy<ObservableCollection<ZFormat>> ProductCollection { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            IdCollection = new ObservableCollection<Datum>();
            ProductCollection = new Lazy<ObservableCollection<ZFormat>>();
        }

        private async void ProductApi()
        {
            //foreach (var item in IdCollection)
            //{
            //    await GetProduct.ProductAsync(ProductCollection, item.ID);
            //    dataGrid.ItemsSource = ProductCollection;
            //}
            //await GetProduct.ProductAsync(ProductCollection, 1003368);

        }
        
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //await ProductId.PopulateIdAsync(IdCollection);
            //ProductApi();

            await ProductStore.EnsureProductStore();
            var items = await ProductStore.GetProducts();

            items.ForEach(ProductCollection.Value.Add);
            
        }
    }
}
