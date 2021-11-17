using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Model
{
    public class Invoices : InvoicesDetails
    {
        public int Id { get; set; }
        public int Id_Client { get; set; }
        public int Cod { get; set; }

    }
}
