using Contoso.Service.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Logic
{
    public class ProductionService : IProductionService
    { 
        private readonly HttpClient _httpClient;

        public ProductionService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<int> AddProduct(Product product)
        {
            var resp = await _httpClient.PostAsJsonAsync("/products/add", product);

            return (int)resp.StatusCode;
        }

        public async Task<List<Product>> GetProducts()
        {
            var resp = await _httpClient.GetAsync("/products");
            var productsString = await resp.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(productsString);

            return products;
        }
    }
}
