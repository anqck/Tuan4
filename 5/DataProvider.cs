using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class DataProvider
    {
        private static string connectionString = "server=localhost;user=root;database=demo_1;port=3306;password=khanhan;";
        private static MySqlConnection conn;

        public static void InitializeConnection()
        {
            if (conn != null)
                conn.Close();

            conn = new MySqlConnection(connectionString);
        }

        public static DataTable ExecuseQuery(string strQuery)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, conn);

            DataTable result = new DataTable();
            result.Load(cmd.ExecuteReader());

            conn.Close();

            return result;
        }

        public static void ExecuseNonQuery(string strQuery)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
