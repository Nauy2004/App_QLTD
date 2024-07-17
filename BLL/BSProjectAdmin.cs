using DAL;
using DOT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BSProjectAdmin
    {
        private DataAccessLayer accessLayer;
        private DataProject dataProject;
        private DAL_Task task;
        SqlConnection conn = ConnectDB.Connect();
        public BSProjectAdmin() 
        {
            accessLayer = new DataAccessLayer();
            dataProject = new DataProject();
            task = new DAL_Task();
        }
        public List<Project> GetProjectsAll()
        {
            List<Project> projects = new List<Project>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("Projects"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    Project project = new Project();
                    project.ProjectID = reader.GetString(0);
                    project.ProjectName = reader.GetString(1);
                    project.ProjectDescription = reader.GetString(2);
                    project.StartDate = reader.GetDateTime(3);
                    project.EndDate = reader.GetDateTime(4);
                    // Create a new Project object and add it to the list
                    projects.Add(project);
                }
                conn.Close();
            }
            return projects;
        }

        public List<UsersProject> getEmpProjectAll()
        {
            List<UsersProject> projects = new List<UsersProject>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("user_projects"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    UsersProject project = new UsersProject();
                    project.project_id = reader.GetString(0);
                    project.emp_id = reader.GetString(1);
                    project.role = reader.GetString(2);
                    // Create a new Project object and add it to the list
                    projects.Add(project);
                }
                conn.Close();
            }
            return projects;
        }

        public List<Employyees> getEmpAll()
        {
            List<Employyees> projects = new List<Employyees>();
            // Get reader containing project data
            using (SqlDataReader reader = accessLayer.Getall("Employees"))
            {
                // Read data from reader
                while (reader.Read())
                {
                    Employyees Emp = new Employyees();
                    Emp.EmployeeID = reader.GetString(0);
                    Emp.EmployeeName = reader.GetString(1);
                    Emp.EmployeeEmail = reader.GetString(2);
                    Emp.EmployeeRole = reader.GetString(3);
                    // Create a new Project object and add it to the list
                    projects.Add(Emp);
                }
                conn.Close();
            }
            return projects;
        }
        
        
        public void setProjectUser(String id_emp, string id_Project, string role)
        {
            try
            {
                dataProject.SetUserProject(id_emp, id_Project, role);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public bool checkUserProjectNull(List<UsersProject> ds, string id_project)
        {
            bool check = true;
            foreach (UsersProject item in ds)
            {
                if (item.project_id == id_project)
                {
                    check = false;
                }
            }
            return check;
        }

        public void DeleteProject(string idP,List<Tasks> taskID)
        {
            try
            {

                //xóa khóa ngoại bảng user_projects
                accessLayer.Delete(idP, "user_projects", "project_id");
                // xóa công việc
                foreach (Tasks item in taskID)
                {
                    accessLayer.Delete(item.TaskID, "TaskAssignments", "TaskID");
                    accessLayer.Delete(item.TaskID, "TaskComments", "TaskID");
                    accessLayer.Delete(item.TaskID, "Tasks", "TaskID");
                }
                accessLayer.Delete(idP, "Projects", "ProjectID");

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
