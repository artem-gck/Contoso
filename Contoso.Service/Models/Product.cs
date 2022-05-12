using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Color { get; set; }
        public bool? ExistsOfProduct { get; set; }
        public int? Amount { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Date { get; set; }
    }
}
