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
    public class FoodCategoryDAO
    {
        public static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodCategoryDAO();
                return instance;
            }
            set => instance = value;
        }

        public List<foodcategory> GetListFoodCategory()
        {
            List<foodcategory> foodcategorylist = new List<foodcategory>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                foodcategory foodcategory = new foodcategory(item);
                foodcategorylist.Add(foodcategory);
            }
            return foodcategorylist;
        }

        public foodcategory GetFoodCategory(int idfood)
        {
            int id = FoodDAO.Instance.getidcategory(idfood);
            foodcategory category = null;
            string query = "select * from FoodCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new foodcategory(item);
                return category;
            }
            return category;
        }
    }
}
