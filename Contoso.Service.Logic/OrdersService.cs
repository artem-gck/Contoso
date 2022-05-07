using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Logic
{
    public class OrdersService : IOrdersService
    {
        private readonly HttpClient _httpClient;

        public OrdersService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<List<Order>> GetOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Customer = "Чучхма Павел Иванович",
                    ProductName = "Ручка, Standart-L",
                    Color = "Белый",
                    Amount = 100,
                    Price = 10,
                    Date = DateTime.Now,
                    Pay = true,
                    Status = "Готов к отгрузке"
                },
                new Order()
                {
                    Customer = "Чучхма Павел Иванович",
                    ProductName = "Ручка, Standart-L",
                    Color = "Чёрный",
                    Amount = 100,
                    Price = 10,
                    Date = DateTime.Now,
                    Pay = true,
                    Status = "Готов к отгрузке"
                },
                new Order()
                {
                    Customer = "Чучхма Павел Иванович",
                    ProductName = "Ручка, Standart-L",
                    Color = "Коричневый",
                    Amount = 100,
                    Price = 10,
                    Date = DateTime.Now,
                    Pay = true,
                    Status = "Готов к отгрузке"
                },
                new Order()
                {
                    Customer = "Чучхма Павел Иванович",
                    ProductName = "Ручка, Standart-L",
                    Color = "Фиолетовый",
                    Amount = 100,
                    Price = 10,
                    Date = DateTime.Now,
                    Pay = true,
                    Status = "Готов к отгрузке"
                },
                new Order()
                {
                    Customer = "Чучхма Павел Иванович",
                    ProductName = "Ручка, Standart-L",
                    Color = "Зелёный",
                    Amount = 100,
                    Price = 10,
                    Date = DateTime.Now,
                    Pay = true,
                    Status = "Готов к отгрузке"
                },
            };
        }
    }
}
