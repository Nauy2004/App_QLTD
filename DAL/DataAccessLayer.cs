using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        private SqlDataReader reader = null;
        public DataAccessLayer() { }

        public SqlDataReader Getall(string pra)
        {
            string query = $"SELECT * FROM {pra}";
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            return reader;
        }
        public void Delete(string id,string table, string DK)
        {
            SqlConnection conn = ConnectDB.Connect();
                conn.Open();

                // Create the delete statement
                string sql = $"DELETE FROM {table} WHERE {DK} = @id";

                // Prepare the command
                SqlCommand command = new SqlCommand(sql, conn);

                // Add parameter for the project ID
                command.Parameters.AddWithValue("@id", id);

                // Execute the command
                command.ExecuteNonQuery();

                Console.WriteLine("Project with ID: " + id + " deleted successfully.");
        }
        public SqlDataReader Getallby(string table,string DK, string pra)
        {
            string query = $"SELECT * FROM {table} where {DK} = @id";
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", pra);
            reader = cmd.ExecuteReader();
            return reader;
        }
        public void update(string id, string table, string DK,string col, string value)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();

            // Create the delete statement
            string sql = $"Update {table} SET {col} = @value WHERE {DK} = @id";

            // Prepare the command
            SqlCommand command = new SqlCommand(sql, conn);

            // Add parameter for the project ID
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@value", value);
            // Execute the command
            command.ExecuteNonQuery();

            Console.WriteLine("Project with ID: " + id + " deleted successfully.");
        }

    }
}
