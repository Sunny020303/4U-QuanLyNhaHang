using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QuanLyNhaHang.DTO
{
    public class Bill
    {
        private int status;

        private int iD;

        private DateTime? dateCheckIn;

        private DateTime? dateCheckOut;

        private float total;

        private int discount;
        private int idTable;
        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            ID = iD;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            Status = status;
        }
        public Bill(DataRow row)
        {
            ID = (int)row["ID"];    
            DateCheckIn = (DateTime?)row["dateCheckIn"];
            var temp = row["dateCheckOut"];
            if (temp.ToString() != "")
            {
                DateCheckOut = (DateTime?)row["dateCheckOut"];
            }
            Status = (int)row["status"];
            total= float.Parse(row["TotalPrice"].ToString());
            discount = (int)row["Discount"];
            IdTable = (int)row["idTable"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public float Total { get => total; set => total = value; }
        public int Discount { get => discount; set => discount = value; }
        public int IdTable { get => idTable; set => idTable = value; }
    }
}
