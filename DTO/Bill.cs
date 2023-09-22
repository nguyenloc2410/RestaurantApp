using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class Bill
    {
        

        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public DateTime Datecheckin { get => datecheckin; set => datecheckin = value; }
        public DateTime Datecheckout { get => datecheckout; set => datecheckout = value; }
        public int Idtable { get => idtable; set => idtable = value; }
        public int Discount { get => discount; set => discount = value; }

        private int id;
        private int idtable;
        private int status;
        private int discount;
        private DateTime datecheckin;
        private DateTime datecheckout;
        public Bill(int id,int idtable,int status,DateTime? In,DateTime? Out,int discount = 0) { 
            this.Id = id;
            this.Idtable = idtable;
            this.Status = status;
            this.Datecheckin = (DateTime)In;
            this.Datecheckout = (DateTime)Out;
            this.Discount = discount;
        }
        public Bill(DataRow row) {
            this.Id = (int)row["id"];
            this.Idtable = (int)row["idTable"];
            this.Status = (int)row["status"];
            this.Datecheckin = (DateTime)row["DateCheckIn"];
            this.Discount = (int)row["discount"];
            var datecheckoutmp = row["DateCheckOut"];
            if(datecheckoutmp.ToString() != "")
                this.Datecheckout = (DateTime)row["DateCheckOut"];
        }   

    }
}
