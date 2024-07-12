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
        public DataProject() { }

<<<<<<< HEAD
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

        public void DeleteProject(string id) 
        { 
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader GetRoleUserProject(string roleId)
        {

            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_checkRoleProject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", roleId);
            reader = cmd.ExecuteReader();
            return reader;
=======
        public SqlDataReader getDataProject(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Invalid project ID provided.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllProject", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    // Open connection and execute reader within using block for auto-closing
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions during database operations
                throw new Exception("An error occurred while retrieving project data.", ex);
            }
>>>>>>> 949e6139a3a91b6a3d4b9c39565fb369b04a66d4
        }

    }

}
