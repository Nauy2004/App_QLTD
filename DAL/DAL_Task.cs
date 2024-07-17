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

        public SqlDataReader ReaderTaskAssginByID(string idtask)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_getTaskByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTask", idtask);
            reader = cmd.ExecuteReader();
            return reader;
        }


        public void UpdateTask(string id, string name, string desc, DateTime start, string Status,string Priority,string Estima)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Sp_UpdateTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_task", id);
            cmd.Parameters.AddWithValue("@taskName", name);
            cmd.Parameters.AddWithValue("@tasDesc", desc);
            cmd.Parameters.AddWithValue("@DueDate", start);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Priority", Priority);
            cmd.Parameters.AddWithValue("@Estima", Estima);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Task updated successfully.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error updating Task: " + ex.Message);
            }
        }

        public void CreateTask(string id_T, string name, string desc, DateTime start, string Status, string Priority, string Estima,string id_P)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_insertTaks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idT", id_T);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@DueDate", start);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@Priority", Priority);
            cmd.Parameters.AddWithValue("@Estima", Estima);
            cmd.Parameters.AddWithValue("@idP", id_P);
            cmd.ExecuteNonQuery();
        }
    
        public void CreateTaskAssignments(string id_emp,string id_task)
        {
            SqlConnection conn = ConnectDB.Connect();
            conn.Open();

            // Create the delete statement
            string sql = $"Insert into TaskAssignments(TaskID,EmployeeID)" +
                $"Values(@TaskID,@EmployeeID);";

            // Prepare the command
            SqlCommand command = new SqlCommand(sql, conn);

            // Add parameter for the project ID
            command.Parameters.AddWithValue("@TaskID", id_task);
            command.Parameters.AddWithValue("@EmployeeID", id_emp);

            // Execute the command
            command.ExecuteNonQuery();
        }
    }
}
