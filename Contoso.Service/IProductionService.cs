using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public interface IProductionService
    {
        public Task<List<Product>> GetProducts();
    }
}
