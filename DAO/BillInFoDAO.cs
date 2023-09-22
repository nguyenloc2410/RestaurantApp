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
    public class BillInFoDAO
    {
        private static BillInFoDAO instance;

        public static BillInFoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInFoDAO();
                return instance;
            }
            set => instance = value;
        }

        public List<BillInfo> getlistbillinfo(int idBill){
            List<BillInfo> billinfolist = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from bilLInfo where idbill = "+idBill);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                billinfolist.Add(info);
            }
            return billinfolist;
        }


        public void InsertBillInfo(int idbill,int idfood,int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBillInfo @idbill , @idFood , @quantity", new object[] { idbill, idfood, quantity });
        }

        public void deletebillinfo(int idfood)
        {
            DataProvider.Instance.ExecuteQuery("delete billinfo where idFood = " + idfood);
        }
    }
}
