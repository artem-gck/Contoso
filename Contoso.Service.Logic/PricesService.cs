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
    public class PricesService : IPricesService
    {
        private readonly HttpClient _httpClient;

        public PricesService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<int> AddPrice(Price price)
        {
            var resp = await _httpClient.PostAsJsonAsync("/price/add", price);

            return (int)resp.StatusCode;
        }

        public async Task<List<Price>> GetPrices()
        {
            var resp = await _httpClient.GetAsync("/price");
            var pricesString = await resp.Content.ReadAsStringAsync();
            var prices = JsonConvert.DeserializeObject<List<Price>>(pricesString);

            return prices;
        }
    }
}
