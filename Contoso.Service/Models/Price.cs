using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal PriceOfProduct { get; set; }
    }
}
