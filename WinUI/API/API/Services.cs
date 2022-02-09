using API.Database;
using API.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public static class Services
    {
        public static ServiceProvider serviceProvider = new ServiceCollection()
            .AddDbContext<DataDBContext>(options =>
            {
                options.UseSqlite($@"Data Source = {App.DB}");
            })
            .AddScoped<IProduct>(provider => new StoreProduct(provider.GetService<DataDBContext>()))
            .BuildServiceProvider();

        public static IProduct ProductStore = serviceProvider.GetService<IProduct>();


    }
}
