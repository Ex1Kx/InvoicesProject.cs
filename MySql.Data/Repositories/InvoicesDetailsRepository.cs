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
    public class InvoicesDetailsRepository : IInvoicesDetails
    {
        private MySqlConfiguration _connectionString;
        public InvoicesDetailsRepository(MySqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<IEnumerable<InvoicesDetails>> GetAllInvoices()
        {
            var db = dbConnection();

            var sql = @"
                         SELECT IdD, Id_Invoice, Descriptioni, Valuei
                         From invoicesdetails";
            return await db.QueryAsync<InvoicesDetails>(sql, new { });
        }

        public Task<bool> InsertDetails()
        {
            throw new NotImplementedException();
        }
    }
}
