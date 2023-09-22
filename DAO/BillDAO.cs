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
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get
            {
                if(instance == null) instance = new BillDAO();
                return instance;
            }
            private set => instance = value; 
        }
        public int GetidBillUncheck(int idTable)
        {
            var data = DataProvider.Instance.ExecuteQuery("select * from bill where idTable = " + idTable + " and status = 0");
            if(data.Rows.Count > 0 )
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            else
            {
                return -1;
            }
        } 
        public void InsertBill(int idtable)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBill @idTable",new object[] {idtable});
        }

        public int GetMaxIdBill() {
            return (int)DataProvider.Instance.ExecuteScalar("select max(id)from bill");
        }


        public DataTable GetDoanhThu(DateTime checkin,DateTime checkout)
        {
           return DataProvider.Instance.ExecuteQuery("exec getdoanhthu @datecheckin , @datecheckout", new object[] {checkin, checkout});
        }
        public int Gettongsoluongbill(DateTime checkin,DateTime checkout)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec tongsoluongbill @checkin  , @checkout ", new object[] { checkin, checkout });
        }
        public DataTable GetDoanhThuAndPage(DateTime checkin, DateTime checkout,int pagenum)
        {
            return DataProvider.Instance.ExecuteQuery("exec getdoanhthuandpage @checkin , @checkout , @page", new object[] {checkin,checkout,pagenum});
        }
        public void ThanhToan(int idbill,int discount,float tongtien,float tiengoc)
        {
            DataProvider.Instance.ExecuteNonQuery($"update bill  set bill.status = 1, discount = {discount},totalprice = {tongtien}, tiengoc = {tiengoc}, DateCheckOut = GETDATE() where bill.id = " + idbill);
        }
    }
}
