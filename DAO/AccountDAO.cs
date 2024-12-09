using Qlyquancafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Qlyquancafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
            }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {

            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {userName, passWord});
            return result.Rows.Count > 0;
            
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @passWord , @newPassWord", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("select UserName, DisplayName, Type from Account");
        }

        public Account GetAccountByUserName(string userName)
        {
           DataTable data = DataProvider.Instance.ExcuteQuery("select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }


            return null;
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT INTO Account (UserName, DisplayName, Type) VALUES (N'{0}', N'{1}' , {2})", name, displayName, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;

        }
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET DisplayName = N'{1}', Type = {2} where UserName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;

        }
        public bool DeleteAccount(string name)
        {

            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;

        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("Update Account set passWord = N'0' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    } 
}
