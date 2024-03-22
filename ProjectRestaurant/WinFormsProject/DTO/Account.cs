using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsProject.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private int role;

        public string UserName { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }

        public Account(string userName, string displayName, int role, string password = null)
        {
            UserName = userName;
            DisplayName = displayName;
            Password = password;
            Role = role;
        }

        public Account(DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.DisplayName = row["displayname"].ToString();
            this.Password = row["password"].ToString();
            this.Role = (int)row["role"];
        }
    }
}
