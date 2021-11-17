using MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlE.Data.Repositories
{
    public interface IClientsRepository
    {
        Task<IEnumerable<Clients>> GetClients();
        Task<Clients> GetClientsDetail();
        Task<bool> InsertClient();
    }
}
