using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class ThucDon
    {
        private string name;
        private string unit;
        private int quantity;
        private double price;

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Price { get => price; set => price = value; }

        public ThucDon(string name,string unit,int quantity,int price) { 
            this.Name = name;
            this.Unit = unit;
            this.Quantity = quantity;
            this.Price = price;
        }
        public ThucDon(DataRow row) {
            this.Name = row["TenMonAn"].ToString();
            this.Quantity = (int)row["Quantity"];
            this.Unit = row["Unit"].ToString();
            double v = (double)Convert.ToDouble(row["Price"].ToString());
            this.Price = v;
        }
    }
}
