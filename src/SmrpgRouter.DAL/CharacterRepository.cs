using System.Collections.Generic;
using System.Data;
using System.Linq;

using SmrpgRouter.Entities;

using Dapper;

using Npgsql; 

namespace SmrpgRouter.DAL
{
    public class CharacterRepository
    {
        private const string _connectionString =
            "Host=localhost;Port=5432;Database=smrpg-router;Username=smrpg-router;Password=smrpg-router";

        public CharacterRepository() { }

        public List<Character> GetAll()
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<Character>("select * from character").ToList();
            }
        }

        public void Insert(string name)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                db.Query($"insert into character (name) values ('{name}')");
            }
        }
    }
}
