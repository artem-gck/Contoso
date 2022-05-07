using Contoso.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public interface IClientsService
    {
        public Task<List<Client>> GetClients();
    }
}
