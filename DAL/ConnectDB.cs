using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDB
    {
        public static SqlConnection Connect()
        {
            string strconn = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=SQL_QLTD;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }
}
