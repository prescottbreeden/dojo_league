using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Options;
using dojo_league.Models;
using Dapper;
using System.Linq;

namespace dojo_league.Factories
{
    public class NinjaFactory : Factory
    {
        public NinjaFactory(IOptions<MySqlOptions> config) : base(config)
        {
        }

        // get all trails
        public List<Ninja> GetAllNinjas()
        {
            using(IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                   string query = "SELECT * FROM ninjas";
                   dbConnection.Open();
                  return dbConnection.Query<Ninja>(query).ToList();
                }
            }
        }

        // add a trail
        public void AddNewNinja(Ninja ninja)
        {
            using (IDbConnection dbConnection = Connection)
            {            
                string query = "INSERT INTO ninjas (name, level, description, dojo) ";
                query += "VALUES (@Name, @Description )";
    
                dbConnection.Open();
                dbConnection.Execute(query, ninja);               
            }
        }
    }
}
