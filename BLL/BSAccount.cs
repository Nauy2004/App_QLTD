using DAL;
using DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BSAccount
    {
        private DAL_Account dalAccount = new DAL_Account();

        public List<Accounts> GetAllAccounts()
        {
            return dalAccount.GetAllAccounts();
        }

        public void AddAccount(Accounts account)
        {
            dalAccount.AddAccount(account);
        }

        public void UpdateAccount(Accounts account)
        {
            dalAccount.UpdateAccount(account);
        }

        public void DeleteAccount(char accountId)
        {
            dalAccount.DeleteAccount(accountId);
        }

        public List<Accounts> SearchAccounts(string keyword)
        {
            return dalAccount.SearchAccounts(keyword);
        }
    }
}
