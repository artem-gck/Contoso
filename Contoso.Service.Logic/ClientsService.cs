using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Logic
{
    public class ClientsService : IClientsService
    {
        private readonly HttpClient _httpClient;

        public ClientsService(HttpClient httpClient)
            => _httpClient = httpClient;

        public async Task<List<Client>> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ProductName = "Ручка",
                    Location = "Минск",
                    ContactName = "Головов Пётр Львович",
                    NumberOfPhone = "+375447865764",
                    Email = "Golovov@mail.com"
                },
                new Client()
                {
                    ProductName = "Карандаш",
                    Location = "Москва",
                    ContactName = "Королёва Эльвира Алексанровна",
                    NumberOfPhone = "+23445670100",
                    Email = "Korolova@outlook.com"
                },
                new Client()
                {
                    ProductName = "Карандаш",
                    Location = "Киев",
                    ContactName = "Федоров Андрей Алексеевич",
                    NumberOfPhone = "+4524462634",
                    Email = "Fedorov@gmail.com"
                },
                new Client()
                {
                    ProductName = "Ручка",
                    Location = "Вильнюс",
                    ContactName = "Толкочова Алёна Николаевна",
                    NumberOfPhone = "+345234624547",
                    Email = "Tolkochova@yandex.by"
                },
                new Client()
                {
                    ProductName = "Ручка",
                    Location = "Бразилиа",
                    ContactName = "Мароков Миромир Авдосьевич",
                    NumberOfPhone = "+34523453425",
                    Email = "Marokov@mail.com"
                },
            };
        }
    }
}
