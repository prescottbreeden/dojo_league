using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Options;
using dojo_league.Models;
using Dapper;
using System.Linq;

namespace dojo_league
{
    public class Factory
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
 
        public Factory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(MySqlConfig.Value.ConnectionString);
            }
        }
    }
}