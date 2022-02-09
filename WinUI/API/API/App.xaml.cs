using API.Models;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using static API.Services;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace API
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string path = $@"{appData}\API";
        public static string DB = $@"{path}\Products.db";
        public static List<ZFormat> Products = new List<ZFormat>();

        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        
        private async Task InitializeData()
        {
            try
            {
                await ProductStore.EnsureProductStore();
                Products = await ProductStore.GetProducts();
            }
            catch(Exception ) {
                File.Delete(DB);
                await InitializeData();
            }
        } 

        protected async override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            await InitializeData();
        }

        private Window m_window;
    }
}
