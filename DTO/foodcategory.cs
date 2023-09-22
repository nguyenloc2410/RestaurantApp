using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class foodcategory
    {
        private int id;
        private string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public foodcategory(int id,string name) {
            this.Id = id;
            this.Name = name;
        }
        public foodcategory(DataRow row) { 
            this.Id = (int)row["id"];
            this.Name = row["DanhMuc"].ToString();
        }
    }
}
