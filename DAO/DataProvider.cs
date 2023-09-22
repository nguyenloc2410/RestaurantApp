using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace Coffee_Manage.Solu
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            } 
            private set => instance = value; 
        }
        public DataProvider() { }

        private string path = "Data Source=DESKTOP-70M8S9I\\SQLEXPRESS;Initial Catalog=Quan_Ly_Quan_Cafe;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i++]);
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            } ;
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue (item, parameters[i++]);
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            };
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listpara)
                    {
                        if(item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i++]);
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            };
            return data;
        }
    }

}
