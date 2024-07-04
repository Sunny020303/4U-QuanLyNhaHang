using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class BillInfo
    {
        
        private int iD;
        private int iDBill;
        private int iDFood;
        private int count;

        public BillInfo(int iD, int iDBill, int iDFood, int count)
        {
            ID = iD;
            IDBill = iDBill;
            IDFood = iDFood;
            Count = count;
        }

        public BillInfo(DataRow row) {
            ID = (int)row["ID"];
            IDBill = (int)row["IDBill"];
            IDFood = (int)row["IDFood"];
            Count = (int)row["Count"];  
        }

        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
