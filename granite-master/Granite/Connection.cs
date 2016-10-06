using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    class Connection
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;
        public Connection()
        {            
            string myConnectionString;
            myConnectionString = "server=einstein.etsu.edu;uid=bentleyp;pwd=12345;database=bentleyp";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                //do nothing
            }
        }

        public void Close()
        {
            conn.Close();
        }

        public MySql.Data.MySqlClient.MySqlConnection getConn()
        {
            return conn;
        }
    }
}

