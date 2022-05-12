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

        public async Task<int> AddProductsFromFile(string fileContent)
        {
            int statusCode = -1;
            var lines = fileContent.Split('\n');

            foreach (var line in lines)
            {
                var fields = line.Split('#');

                var product = new Product()
                {
                    Name = fields[0],
                    Type = fields[1],
                    Color = fields[2],
                    Amount = int.Parse(fields[3]),
                    Price = decimal.Parse(fields[4]),
                };

                statusCode = await AddProduct(product);
            }

            return statusCode;
        }

        public async Task<List<Product>> GetProducts()
        {
            var resp = await _httpClient.GetAsync("/products");
            var productsString = await resp.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(productsString);

            return products;
        }

        public async Task<int> UpdateProduct(Product product)
        {
            var resp = await _httpClient.PostAsJsonAsync("/products/update", product);

            return (int)resp.StatusCode;
        }
    }
}
