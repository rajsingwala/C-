using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interface
{
    public interface IProduct
    {
        Task<bool> HasData();
        Task EnsureProductStore();
        Task<List<ZFormat>> GetProducts();
        Task AddProduct(ZFormat product);
        Task SaveProduct(ZFormat product);
        Task UpdateProduct(ZFormat product);
    }
}
