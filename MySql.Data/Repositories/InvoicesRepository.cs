using Dapper;
using MySql.Data.MySqlClient;
using MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlE.Data.Repositories
{
    public class InvoicesRepository : IInvoicesRepository
    {
        private MySqlConfiguration _connectionString;
        public InvoicesRepository(MySqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<IEnumerable<Invoices>> GetInvoices()
        {
            var db = dbConnection();

            var sql = @"
                        select i.Id, i.Id_Client, i.Cod, ind.IdD, ind.Id_Invoice, ind.Descriptioni, ind.Valuei
                        from invoice i, invoicesdetails ind";
            return await db.QueryAsync<Invoices>(sql, new { });
        }

        public Task<bool> InsertClient()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertInvoices(Invoices invoices)
        {
            var db = dbConnection();

            var sql = @"
                         INSERT INTO invoice (Id, Id_Client, Cod)
                         VALUES (@Id, @Id_Client, @Cod);
                         INSERT INTO invoicesdetails (IdD, Id_Invoice, Descriptioni, Valuei)
                         VALUES (@IdD, @Id_Invoice, @Descriptioni, @Valuei)";
            var result = await db.ExecuteAsync(sql, new { invoices.Id, invoices.Id_Client, invoices.Cod, invoices.IdD, invoices.Id_Invoice, invoices.Descriptioni, invoices.Valuei });

            return result > 0;
        }
    }
}
