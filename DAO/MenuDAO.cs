using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get
            {
                if(instance == null) instance = new MenuDAO();
                return instance;
            }
           set => instance = value; 
        }
        public List<ThucDon> GetlisMenu(int idTable)
        {
            List<ThucDon> listmenu = new List<ThucDon>();
            string query = "select f.TenMonAn,f.Unit,b.Quantity,f.Price from Food as f\r\nleft join bilLInfo as b on b.idFood = f.id\r\nleft join bill on bill.id = b.idbill\r\nwhere bill.status = 0 and bill.idTable = " + idTable;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThucDon menu = new ThucDon(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
    }
}
