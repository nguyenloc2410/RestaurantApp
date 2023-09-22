using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private double price;
        private int idcategory;
        private string unit;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Idcategory { get => idcategory; set => idcategory = value; }
        public string Unit { get => unit; set => unit = value; }

        public Food(int id,string name,double price,int idcategory,string unit) { 
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Idcategory = idcategory;
            this.Unit = unit;
        }
        public Food(DataRow row) {
            this.Id = (int)row["id"];
            this.Name = row["TenMonAn"].ToString();
            this.Price = (double)row["Price"];
            this.Idcategory = (int)row["idCategory"];
            this.Unit = row["Unit"].ToString();
        }


    }
}
