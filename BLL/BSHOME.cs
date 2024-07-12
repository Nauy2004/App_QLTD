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
    }
}
