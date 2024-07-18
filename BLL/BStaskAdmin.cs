using DAL;
using DOT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BStaskAdmin
    {
        private DataAccessLayer accessLayer;
        private DataProject dataProject;
        private DAL_Task task;
        SqlConnection conn = ConnectDB.Connect();
        public BStaskAdmin() 
        { 
            accessLayer = new DataAccessLayer();
            dataProject = new DataProject();
            task = new DAL_Task();
        }
        // Hàm trả về danh sách Task
        public List<Tasks> GetTasks()
        {
            List<Tasks> tasks = new List<Tasks>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("Tasks"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    Tasks task = new Tasks();
                    task.TaskID = reader.GetString(0); // Assuming TaskID is string
                    task.TaskName = reader.GetString(1); // Assuming TaskName is string
                    task.TaskDescription = reader.GetString(2); // Assuming TaskDescription is string
                    task.DuaDate = reader.GetDateTime(3); // DuaDate is likely DateTime
                    task.Status = reader.GetString(4); // Assuming Status is string
                    task.ProjectID = reader.GetString(5); // Assuming Priority is string
                    task.Priority = reader.GetString(6); // EstimatedEffort is likely int
                    task.EstimatedEffort = reader.GetString(7); // Assuming ProjectID is string
                    tasks.Add(task);
                }
                conn.Close();
            }
            return tasks;
        }

        // Hàm trả về danh sách Employyees
        public List<Employyees> GetEMPS()
        {
            List<Employyees> emps = new List<Employyees>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("Employees"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    Employyees emp = new Employyees();
                    emp.EmployeeID = reader.GetString(0);
                    emp.EmployeeName = reader.GetString(1); 
                    emp.EmployeeEmail = reader.GetString(2); 
                    emp.EmployeeRole = reader.GetString(3); 
                    emps.Add(emp);
                }
                conn.Close();
            }
            return emps;
        }
        // Hàm trả về danh sách TaskAssignments
        public List<TaskAssignments> GetTaskAssignments() 
        {
            List<TaskAssignments> taskAssignments = new List<TaskAssignments>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("TaskAssignments"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    TaskAssignments taskAssignment = new TaskAssignments();
                    taskAssignment.EmployeeID = reader.GetString(1);
                    taskAssignment.TaskID = reader.GetString(0);
                    taskAssignments.Add(taskAssignment);
                }
                conn.Close();
            }
            return taskAssignments;
        }
        // Hàm trả về danh sách TaskEmp
        public List<TaskEmp> GetTaskAssignmentsByID(string id)
        {
            List<TaskEmp> TaskEmp1 = new List<TaskEmp>();
            // Get reader containing project data
            using (SqlDataReader reader = task.ReaderTaskAssginByID(id))
            {
                // Read data from reader
                while (reader.Read())
                {
                    TaskEmp TaskEmp2 = new TaskEmp();
                    TaskEmp2.TaskID = reader.GetString(0);
                    TaskEmp2.TaskName = reader.GetString(1);
                    TaskEmp2.EmployeeName = reader.GetString(2);
                    TaskEmp2.EmployeeRole = reader.GetString(3);
                    TaskEmp1.Add(TaskEmp2);
                }
                conn.Close();
            }
            return TaskEmp1;
        }
        // Hàm trả về danh sách TaskComments
        public List<TaskComments> GetCommentByID(string id)
        {
            List<TaskComments> comments = new List<TaskComments>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getallby("TaskComments","TaskID",id))
            {
                // Read data from reader
                while (reader.Read())
                {
                    TaskComments comment = new TaskComments();
                    comment.CommentID = reader.GetInt32(0);
                    comment.CommentText = reader.GetString(1);
                    comment.CommentedBy = reader.GetString(2);
                    comment.TaskID = reader.GetString(3);
                    comment.CommentedOn = reader.GetDateTime(4);
                    comments.Add(comment);
                }
                conn.Close();
            }
            return comments;
        }
       
        //Hàm phân công công việc
        public void addTaskAssignment(string id_emp,string id_task)
        {
            try
            {
                task.CreateTaskAssignments(id_emp, id_task);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        
        //Hàm update công việc
        public void UPTask(string id, string name, string desc, DateTime start, string Status, string Priority, string Estima)
        {
            try
            {
                task.UpdateTask(id, name,desc,start,Status,Priority, Estima);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //Hàm thêm công việc
        public void AddTask(string id_T, string name, string desc, DateTime start, string Status, string Priority, string Estima, string id_P)
        {
            try
            {
                task.CreateTask(id_T,name,desc,start,Status,Priority,Estima,id_P);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating project: " + ex.Message);
            }
            conn.Close();
        }
        //Hàm Kiểm tra Task_id có tồn tại hay không trong danh sách Task
        public bool checkIdTask(string id, List<Tasks> tasks) 
        {
            foreach (Tasks task in tasks) 
            {
                if (task.TaskID.Trim() == id.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        //Hàm Kiểm tra Task_id có tồn tại hay không trong danh sách TaskAssignments
        public bool checkIdTaskAssign(string id, List<TaskAssignments> tasks,string emp)
        {
            foreach (TaskAssignments task in tasks)
            {
                if (task.TaskID.Trim() == id.Trim() && task.EmployeeID == emp)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteTask(string id) 
        {
            try
            {
                accessLayer.Delete(id, "TaskAssignments", "TaskID");
                accessLayer.Delete(id, "TaskComments", "TaskID");
                accessLayer.Delete(id, "Tasks", "TaskID");
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating project: " + ex.Message);
            }
            conn.Close();
        }
    
    }
}
