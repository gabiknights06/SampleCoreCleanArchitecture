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
    public class PersonRepository : IPersonRepository<Person>
    {
        public int Insert(Person data)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"INSERT INTO persons (FirstName, MiddleName, LastName, Company, RecordState,Timestamp,ModifiedTimestamp) VALUES (@FirstName, @MiddleName, @LastName, @Company, 1, @Timestamp, @ModifiedTimestamp)";

                conn.Execute(query, data);

                return 0;
            }
        }

        public Person Load(int id)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM persons where id = { id}";

                return conn.Query<Person>(query).FirstOrDefault();
            }
        }

        public List<Person> LoadAll()
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionManager.ConnectionString))
            {
                string query = $@"SELECT * FROM persons";

                return conn.Query<Person>(query).ToList();
            }
        }

        public void Remove(Person data)
        {
            throw new NotImplementedException();
        }

        public void Update(Person data)
        {
            throw new NotImplementedException();
        }
    }
}
