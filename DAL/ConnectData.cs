using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConncectionData
    {
        public static SqlConnection Connect()
        {
            string strConn = @"data Source=DESKTOP-4976QMC;Initial Catalog=SQL_QLTD;Integrated Security=True";
            SqlConnection sConn = new SqlConnection(strConn);
            return sConn;
        }
    }
}
