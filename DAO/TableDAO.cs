using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DAO
{
    public class TableDAO
    {
        public static int tablewidth = 100;
        public static int tableheight = 100;
        private static TableDAO instance;
        public static TableDAO Instance {
            get 
            {
                if (instance == null) instance = new TableDAO();
                return instance;
            }
            private set => instance = value; }
        public TableDAO() { }

        public List<Table> LoadTableList() //tao table moi trong C#
        {
            List<Table> listTable = new List<Table>();
            var data = DataProvider.Instance.ExecuteQuery("exec loadTable");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }

        public void switch_table( int idtable1,int idtable2)
        {
            DataProvider.Instance.ExecuteQuery("exec switch_table @idtable1 , @idtable2", new object[] {idtable1,idtable2});

        }

    }
}
