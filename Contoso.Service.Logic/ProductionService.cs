using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Logic
{
    public class ProductionService : IProductionService
    { 
        private readonly HttpClient _httpClient;

        public ProductionService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<List<Product>> GetProducts()
        {
            return new List<Product>() { 
                new Product()
                {
                    Id = 1,
                    Name = "Ручка",
                    Type = "Standart-L",
                    Color = "Черный",
                    Amount = 12,
                    Price = 10,
                    Date = DateTime.Now,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Карандаш",
                    Type = "Standart-M",
                    Color = "Красный",
                    Amount = 1,
                    Price = 12,
                    Date = DateTime.Now,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Ручка",
                    Type = "Medium-XL",
                    Color = "Жёлтый",
                    Amount = 34,
                    Price = 5,
                    Date = DateTime.Now,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Ручка",
                    Type = "Standart-M",
                    Color = "Черный",
                    Amount = 102,
                    Price = 2,
                    Date = DateTime.Now,
                },
                new Product()
                {
                    Id = 5,
                    Name = "Карандаш",
                    Type = "Medium-XL",
                    Color = "Фиолетовый",
                    Amount = 29,
                    Price = 45,
                    Date = DateTime.Now,
                },
            };
        }
    }
}
