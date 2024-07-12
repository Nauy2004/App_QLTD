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
        SqlConnection conn = ConnectDB.Connect();
        private SqlDataReader reader = null;
        public DataProject() { }

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
        }

    }

}
