using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WinFormsProject.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsProject.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            //Mã hóa mật khẩu khi đăng nhập
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;    
            }


            string query = "select * from Account where username = @username and password = @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hasPass });
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string password, string newPass)
        {

            //Mã hóa mật khẩu cũ 
            byte[] tempPassword = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasDataPassword = new MD5CryptoServiceProvider().ComputeHash(tempPassword);

            //Mã hóa mật khẩu mới 
            byte[] tempNewPassword = ASCIIEncoding.ASCII.GetBytes(newPass);
            byte[] hasDataNewPassword = new MD5CryptoServiceProvider().ComputeHash(tempNewPassword);

            string hasPassPassword = "";
            foreach (byte item in hasDataPassword)
            {
                hasPassPassword += item;
            }

            string hasPassNewPassword = "";
            foreach (byte item in hasDataNewPassword)
            {
                hasPassNewPassword += item;
            }


            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, hasPassPassword, hasPassNewPassword });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT [username] , [displayname] , [role] FROM [dbo].[Account]");
        }

        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where username = '" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }


        public bool InsertAccount(string username, string displayName, int role)
        {
            string query = string.Format("insert Account ([username], displayname, role, [password]) values(N'{0}' , N'{1}' , {2}, N'{3}')", username, displayName, role, "20720532132149213101239102231223249249135100218");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string username, string displayName, int role)
        {
            string query = string.Format("UPDATE[dbo].[Account] SET [displayname] = N'{0}' ,[role] = {1} WHERE username = N'{2}' ", displayName, role, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete Account WHERE username = N'{0}' ", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE[dbo].[Account] SET password = N'20720532132149213101239102231223249249135100218' WHERE username = N'{0}' ", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
