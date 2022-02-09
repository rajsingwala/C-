using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Threading.Tasks;
using API.Models;
using static API.Services;
using System.IO;

namespace API
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string path = $@"{appData}\API";
        public static string DB = $@"{path}\Products.db";
        public static List<ZFormat> Products = new List<ZFormat>();
        private async Task InitializeData()
        {
            try
            {
                await ProductStore.EnsureProductStore();
                Products = await ProductStore.GetProducts();
            }
            catch (Exception)
            {
                File.Delete(DB);
                await InitializeData();
            }
        }

        protected async override void OnStartup(StartupEventArgs e)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            await InitializeData();
        }

    }
}
