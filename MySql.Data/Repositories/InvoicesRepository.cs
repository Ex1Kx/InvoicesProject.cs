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
                         SELECT Id, Id_Client, Cod
                         From invoice";
            return await db.QueryAsync<Invoices>(sql, new { });
        }

        public Task<bool> InsertClient()
        {
            throw new NotImplementedException();
        }
    }
}
