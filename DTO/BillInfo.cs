using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manage.DTO
{
    public class BillInfo
    {
        private int id;
        private int idbill;
        private int idfood;
        private int quantity;

        public int Id { get => id; set => id = value; }

        public int Idfood { get => idfood; set => idfood = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Idbill { get => idbill; set => idbill = value; }

        public BillInfo(int id,int idbill,int idfood,int quantity) { 
            this.Id = id;
            this.Idbill = idbill;
            this.Idfood = idfood;
            this.Quantity = quantity;
        }
        public BillInfo(DataRow row) { 
            this.Id = (int)row["id"];
            this.Idbill = (int)row["idbill"];
            this.Idfood = (int)row["idFood"];
            this.Quantity = (int)row["Quantity"];
            
        }
    }
}
