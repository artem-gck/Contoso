using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Location { get; set; }
        public string? ContactName { get; set; }
        public string? NumberOfPhone { get; set; }
        public string? Email { get; set; }
    }
}
