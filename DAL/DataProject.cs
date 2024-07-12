using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DataProject
    {
        private SqlDataReader reader = null;
        public DataProject() {}

        public SqlDataReader GetProjectAll(string roleId)
        {

                SqlConnection conn = ConnectDB.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_GetAllProject", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", roleId);
                reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader sreachProject(string pra)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_sreachProject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pra", pra);
            cmd.Parameters.AddWithValue("@pra2", pra);
            reader = cmd.ExecuteReader();
            return reader;
        }
        public void CreateProject(string id, string name, string desc, DateTime start)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_InsertProject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ProjectName", name);
            cmd.Parameters.AddWithValue("@ProjectDescription", desc);
            cmd.Parameters.AddWithValue("@StartDate", start);
            cmd.ExecuteNonQuery();
        }
    }
}
