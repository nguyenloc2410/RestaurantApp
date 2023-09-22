using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class Table
    {
        public Table(int id,string name,string status) {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow rows)
        {
            this.id = (int)rows["id"];
            this.name = rows["TenBan"].ToString();
            this.status = rows["status"].ToString();
        }
        private int id;
        public int Id { get => id; set => id = value; } 

        private string name;
        public string Name { get => name; set => name = value; }

        public string status;
        public string Status { get => status; set => status = value; }
    }
}
