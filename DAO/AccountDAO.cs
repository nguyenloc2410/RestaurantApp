using Coffee_Manage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manage.Solu
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get
            {
                if (instance == null)  instance = new AccountDAO(); 
                return instance;
            }
            private set => instance = value; 
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasdata)
            {
                hasPass += item;
            }
            string query = "exec Login @username , @password";
            var kq = DataProvider.Instance.ExecuteQuery(query,new object[] {username, hasPass});
            return kq.Rows.Count > 0;
        }

        public Account getacc(string username) { 
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where id = '"+username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool updatepassword(string username, string password,string newpassword)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("exec Changpassword @username , @password , @newpassword ",new object[] { username,password,newpassword });
            return data > 0;
        }

        public DataTable getlistacc()
        {
           return DataProvider.Instance.ExecuteQuery("select acc.id,acc.DisplayName,acc.Type from Account as acc");
        }

        public bool InsertAccount(string taikhoan,string displayname,int type)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("exec InsertAccount @id , @display , @type ", new object[] { taikhoan, displayname, type });
                return kq > 0;
            }
            catch
            {
                MessageBox.Show("Tài Khoản đã tồn tại !");
            }
            return false;
        }
        public bool UpdateAccount(string taikhoan,string displayname,int type)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery(string.Format("update Account set DisplayName = '{0}', Type = {1} where id = '{2}' \r\n", displayname, type, taikhoan));
                return kq > 0;
            }
            catch
            {
                MessageBox.Show("Tài Khoản không tồn tại !");
            }
            return false;
        }

        public bool DeleteAccount(string taikhoan)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery(string.Format("delete Account where id = '{0}'",taikhoan));
                return kq > 0;
            }
            catch
            {
                MessageBox.Show("Tài khoản không tồn tại !");
                return false;
            }
        }
    }
}
