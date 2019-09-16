using Dapper;
using MySql.Data.MySqlClient;
using Sample.Core.Models;
using Sample.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Persistence.MySQL.Repositories
{
    public class CompanyRepository : ICompanyRepository<Company>
    {
        public int Insert(Company data)
        {
            throw new NotImplementedException();
        }

        public Company Load(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM companies where id = { id }";

                return conn.Query<Company>(query).FirstOrDefault();
            }
        }

        public List<Company> LoadAll()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString))
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
            using (MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString))
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
