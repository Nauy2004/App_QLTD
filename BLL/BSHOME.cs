using DAL;
using DOT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
        
        public void DeleteProject( string id_project )
        {
            DataProjet.DeleteProject(id_project);
        }
    }
}
