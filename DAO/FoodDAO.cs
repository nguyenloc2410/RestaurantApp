using Coffee_Manage.DTO;
using Coffee_Manage.Solu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
            set => instance = value;
        }

        public List<Food> GetlisFood(int idCategory)
        {
            string query = "select * from Food where idCategory = " + idCategory;
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }
        public DataTable GetallFood() {
            return DataProvider.Instance.ExecuteQuery("select f.id,f.TenMonAn,f.Price,f.Unit,fc.DanhMuc from Food as f\r\nleft join FoodCategory as fc on f.idCategory = fc.id");
        }
        public int getidcategory(int idfood) {
            int id = 0;
            string query = "select f.idCategory from Food as f where id = " + idfood;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                id = (int)item["idCategory"];
            }
            return id;
        }
        public bool insertFood(string name, int id, float price,string unit)
        {
            string query = string.Format("insert Food (TenMonAn,Price,idCategory,unit)\r\nvalues(N'{0}',{1},{2},N'{3}')", name,price,id,unit);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updatefood(int idfood, string name, int idcategory, float price, string unit)
        {
            string query = string.Format("update Food set TenMonAn = N'{0}',Price = {1} , idCategory = {2} ,Unit = N'{3}' where id = {4}",name,price,idcategory,unit, idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deletefood(int idfood) {
            BillInFoDAO.Instance.deletebillinfo(idfood);
            string query = string.Format("delete Food where id = " + idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetFoodSearch(string name) {
            return DataProvider.Instance.ExecuteQuery(string.Format("select f.id,f.TenMonAn,f.Price,f.Unit,fc.DanhMuc from Food as f\r\nleft join FoodCategory as fc on f.idCategory = fc.id\r\nwhere f.TenMonAn like N'%{0}%'",name));
        }
    }
}
