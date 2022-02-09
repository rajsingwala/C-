using System.Threading.Tasks;
using System.Net.Http;
using API.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

using static API.Services;
using System;

namespace API
{
    public class GetProduct
    {
        public const string PRODUCT_ENDPOINT = "demo/Api2/GetProduct?Format=JSON&IncludeAllPublisher=false&IncludeCategories=false&IncludeCosts=false&IncludePricing=false&IncludeQuantityPacks=false&IncludeStorePurchaseOptionOverrides=false&ProductId={0}&TierUniqueId=";

        public static async Task ProductAsync(Lazy<ObservableCollection<ZFormat>> ProductCollection, int id)
        {
            var callProduct = await GetAsync(id);
            var product = callProduct.Data;

           foreach(var style in product.Styles)
            {
                foreach(var size in style.Sizes)
                {
                    //ProductCollection.Add(new ZFormat { ProductSKU=product.ID,ProductName=product.Name,Product_type=product.ProductType,Graphic=product.DesignOnline,Color=style.Name,ColorInHex=style.HtmlColor1,Size=size.LongName,Weight=size.Weight})

                        var item = new ZFormat
                        {
                            ProductSKU = product.ID,
                            ProductName = product.Name,
                            Product_type = product.ProductType,
                            Graphic = product.DesignOnline,
                            Color = style.Name,
                            ColorInHex = style.HtmlColor1,
                            Size = size.LongName,
                            Weight = size.Weight
                        };

                        await ProductStore.AddProduct(item);
                        ProductCollection.Value.Add(item);
                    }
                }
            }

            //var data = JsonConvert.SerializeObject(product);

            //var item = JsonConvert.DeserializeObject<Dictionary<string, Object>>(data);

            //dict.Add(product.ID,product);
        public static async Task<RootProduct> GetAsync(int id)
        {           

            string url = string.Format(PRODUCT_ENDPOINT, id);

            using (var http = new HttpClient())
            {
                
                var res = await http.GetAsync(ProductId.BASE_URL + url);

                //add header
                //http.DefaultRequestHeaders.Add("api-key","45skspwpx");

                var result = await res.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<RootProduct>(result);

                return data;
            }

        }
    }
}
