using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class Account
    {
        private string username;
        private string displayname;
        private string password;
        private int type;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public int Type { get => type; set => type = value; }

        public Account(string username,string displayname,string password,int type) {
            this.Username = username;
            this.Displayname = displayname;
            this.Password = password;
            this.Type = type;
        }
        public Account(DataRow row) { 
            this.Username = row["id"].ToString();
            this.Displayname = row["Displayname"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["type"];
        }
    }
}
