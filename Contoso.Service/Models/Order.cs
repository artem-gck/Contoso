using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public string? ProductName { get; set; }
        public string? Color { get; set; }
        public int? Amount { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Date { get; set; }
        public bool? Pay { get; set; }
        public string? Status { get; set; }
    }
}
