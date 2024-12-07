using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.BASE
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=LocalHost;database=adm;uid=root;password=admin12345;sslmode=none";
            //string connectionString = "server=192.168.0.100;database=adm;uid=nsf;password=nsf@2018;sslmode=none";
            //string connectionString = "server=70.37.57.127;database=adm;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

    }
}
