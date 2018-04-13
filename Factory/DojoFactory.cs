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
    public class DojoFactory : Factory
    {
        public DojoFactory(IOptions<MySqlOptions> config) : base(config)
        {
        }

        // get all trails
        public List<Dojo> GetAllDojos()
        {
            using(IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                   string query = "SELECT * FROM ninjas";
                   dbConnection.Open();
                  return dbConnection.Query<Dojo>(query).ToList();
                }
            }
        }

        // add a trail
        public void AddNewDojo(Dojo dojo)
        {
            using (IDbConnection dbConnection = Connection)
            {            
                string query = "INSERT INTO ninjas (name, level, description, team) ";
                query += "VALUES (@Name, @Description )";
    
                dbConnection.Open();
                dbConnection.Execute(query, dojo);               
            }
        }
    }
}
