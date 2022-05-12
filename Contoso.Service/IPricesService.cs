using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public interface IPricesService
    {
        public Task<List<Price>> GetPrices();
        public Task<int> AddPrice(Price price);
    }
}
