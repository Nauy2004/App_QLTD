using DAL;
using DOT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;

namespace BLL
{
    public class BSHOME
    {
        private GetDataUser GetDatUser;
        private DataProject DataProjet;
        private DAL_Task DAL_Task;
        private DataAccessLayer DataAccessLayer;
        SqlConnection conn = ConnectDB.Connect();
        public BSHOME()
        {
            GetDatUser = new GetDataUser();
            DataProjet = new DataProject();
            DAL_Task = new DAL_Task();
            DataAccessLayer = new DataAccessLayer();
        }
        public Employyees GetEml(string id)
        {
            Employyees eml = null;
            try
            {
                eml = GetDatUser.GetEmployyees(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            return eml;
        }
        public List<Project> GetProjects(string id)
        {
            List<Project> projects = new List<Project>();
            // Get reader containing project data
            using (SqlDataReader reader = DataProjet.GetProjectAll(id))
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

        public List<Project> sreachProjects(string pra)
        {
            List<Project> projects = new List<Project>();
            // Get reader containing project data
            using (SqlDataReader reader = DataProjet.sreachProject(pra))
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

        public List<UsersProject> UserProjects(string id_emp)
        {
            List<UsersProject> projects = new List<UsersProject>();
            // Get reader containing project data
            using (SqlDataReader reader = DataProjet.GetRoleUserProject(id_emp))
            {
                // Read data from reader
                while (reader.Read())
                {
                    UsersProject project = new UsersProject();
                    project.emp_id = reader.GetString(0);
                    project.project_id = reader.GetString(1);
                    project.role = reader.GetString(2);
                    // Create a new Project object and add it to the list
                    projects.Add(project);
                }
                conn.Close();
            }
            return projects;
        }


        public List<Tasks> GetTask(string id)
        {
            List<Tasks> Tasks = new List<Tasks>();
            // Get reader containing project data
            using (SqlDataReader reader = DAL_Task.ReaderTaskProject(id))
            {
                // Read data from reader
                while (reader.Read())
                {
                    Tasks Taski = new Tasks();
                    Taski.TaskID = reader.GetString(0); // Assuming TaskID is string
                    Taski.TaskName = reader.GetString(1); // Assuming TaskName is string
                    Taski.TaskDescription = reader.GetString(2); // Assuming TaskDescription is string
                    Taski.DuaDate = reader.GetDateTime(3); // DuaDate is likely DateTime
                    Taski.Status = reader.GetString(4); // Assuming Status is string
                    Taski.ProjectID = reader.GetString(5); // Assuming Priority is string
                    Taski.Priority = reader.GetString(6); // EstimatedEffort is likely int
                    Taski.EstimatedEffort = reader.GetString(7); // Assuming ProjectID is string

                    // Add Taski to the list
                    Tasks.Add(Taski);
                }
                conn.Close();
            }
            return Tasks;
        }

        public void AddProject(string id, string name, string description, DateTime startDate, DateTime EndDate)
        {
            try
            {
                DataProjet.CreateProject(id, name, description, startDate, EndDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating project: " + ex.Message);
            }
            conn.Close();
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

        public void setProjectUser(String id_emp, string id_Project, string role)
        {
            try
            {
                DataProjet.SetUserProject(id_emp, id_Project, role);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void UPProject(string id, string name, string description, DateTime startDate, DateTime EndDate)
        {
            try
            {
                DataProjet.UpdateProjecct(id, name, description, startDate, EndDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void DeleteProject(string id_project)
        {
            DataProjet.DeleteProject(id_project);
        }
    
        public void updateTaskStatus(string id_task,string value)
        {
            try
            {
                DataAccessLayer.update(id_task, "Tasks", "TaskID", "Status", value);

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
