using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ADO_Pro
{
    class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io;Database=MISSILO_biblio;Uid=MISSILO;password=09082001";
        private static MySqlConnection maConnection = new MySqlConnection(connectionString);
        public static MySqlConnection MaConnection { get => maConnection; }
    }
}
