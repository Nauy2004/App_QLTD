using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Task
    {
        private SqlDataReader reader = null;
        public DAL_Task() { }

        public SqlDataReader ReaderTask(string idProject, string id_emp)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GetAllProject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", idProject);
            cmd.Parameters.AddWithValue("@id_emp", id_emp);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader ReaderTaskProject(string idProject)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GetALLTaskProject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", idProject);
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
