using MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlE.Data.Repositories
{
    public interface IInvoicesRepository
    {
        Task<IEnumerable<Invoices>> GetInvoices();
        Task<bool> InsertInvoices(Invoices invoices);
    }
}
