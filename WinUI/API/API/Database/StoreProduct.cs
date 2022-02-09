using API.Interface;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Database
{
    public class StoreProduct : IProduct
    {

        protected DataDBContext dBContext;

        public StoreProduct(DataDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task AddProduct(ZFormat product)
        {
            dBContext.ProductData.Add(product);
            await dBContext.SaveChangesAsync();
        }

        public async Task EnsureProductStore()
        {
            await dBContext.Database.EnsureCreatedAsync();
        }

        public Task<List<ZFormat>> GetProducts()
        {
            return Task.FromResult(dBContext.ProductData.ToList());
        }

        public async Task<bool> HasData()
        {
            return dBContext.ProductData.Count() > 0;
        }

        public async Task SaveProduct(ZFormat product)
        {
            dBContext.ProductData.RemoveRange(dBContext.ProductData);
            dBContext.ProductData.Add(product);
            await dBContext.SaveChangesAsync();
        }

        public async Task UpdateProduct(ZFormat product) 
        {
            dBContext.ProductData.Update(product);
            await dBContext.SaveChangesAsync();
        }
    }
}
