using DAL;
using DOT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BSHOME
    {
        private GetDataUser GetDatUser;
        private DataProject DataProjet;
        SqlConnection conn = ConnectDB.Connect();
        public BSHOME() { 
            GetDatUser = new GetDataUser(); 
            DataProjet = new DataProject();
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
            conn.Close() ;
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
                DataProjet.SetUserProject( id_emp,id_Project,role);
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
        public void DeleteProject( string id_project )
        {
            DataProjet.DeleteProject(id_project);
        }
    }
}
