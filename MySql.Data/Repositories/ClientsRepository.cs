using MySql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace MySqlE.Data.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private MySqlConfiguration _connectionString;
        public ClientsRepository(MySqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public  async Task<IEnumerable<Clients>> GetClients()
        {
            var db = dbConnection();

            var sql = @"
                         SELECT Id, Namei, Last_Name, Document_Id
                         From clients";
            return await db.QueryAsync<Clients>(sql, new { });
        }

        public Task<Clients> GetClientsDetail()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertClient(Clients clients)
        {
            var db = dbConnection();

            var sql = @"
                         INSERT INTO clients (Id, Namei, Last_Name, Document_Id)
                         VALUES (@Id, @Namei, @Last_Name, @Document_Id)";
            var result = await db.ExecuteAsync(sql, new {clients.Id, clients.Namei, clients.Last_Name, clients.Document_Id });

            return result > 0;
        }
    }
}
