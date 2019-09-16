using Dapper;
using Sample.Core.Models;
using Sample.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Sample.Persistence.SQLite.Repositories
{
    public class CompanyRepository : ICompanyRepository<Company>
    {
        public int Insert(Company data)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"INSERT INTO companies (Name, Address, RecordState,Timestamp,ModifiedTimestamp) VALUES (@Name, @Address, 1, @Timestamp, @ModifiedTimestamp)";

                conn.Execute(query, data);

                return 0;
            }
        }

        public Company Load(int id)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM companies where id = { id }";

                return conn.Query<Company>(query).FirstOrDefault();
            }
        }

        public List<Company> LoadAll()
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM companies";

                return conn.Query<Company>(query).ToList();
            }
        }

        public void Remove(Company data)
        {
            throw new NotImplementedException();
        }

        public Company SearchCompanyById(int id)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM companies WHERE id = { id }";

                return conn.Query<Company>(query).FirstOrDefault();
            }
        }

        public void Update(Company data)
        {
            throw new NotImplementedException();
        }
    }
}
