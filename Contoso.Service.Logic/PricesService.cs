using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Logic
{
    public class PricesService : IPricesService
    {
        private readonly HttpClient _httpClient;

        public PricesService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<List<Price>> GetPrices()
        {
            return new List<Price>()
            {
                new Price()
                {
                    ProductName = "Ручка, Standart-L",
                    Date = DateTime.Now,
                    PriceOfProduct = 12
                },
                new Price()
                {
                    ProductName = "Ручка, Medium-L",
                    Date = DateTime.Now,
                    PriceOfProduct = 93
                },
                new Price()
                {
                    ProductName = "Карандаш, Standart-L",
                    Date = DateTime.Now,
                    PriceOfProduct = 2
                },
                new Price()
                {
                    ProductName = "Ручка, Standart-L",
                    Date = DateTime.Now,
                    PriceOfProduct = 100
                },
                new Price()
                {
                    ProductName = "Карандаш, Standart-M",
                    Date = DateTime.Now,
                    PriceOfProduct = 7
                },
            };
        }
    }
}
