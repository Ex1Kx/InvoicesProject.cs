using MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlE.Data.Repositories
{
    public interface IInvoicesDetails
    {
        Task<IEnumerable<InvoicesDetails>> GetAllInvoices();
        Task<bool> InsertDetails();
    }
}
