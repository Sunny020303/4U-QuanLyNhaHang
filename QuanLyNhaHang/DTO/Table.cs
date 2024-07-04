using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Table
    {
        public Table(int id, string name,string status,int isHidden)
        {
            this.isHidden= isHidden;
            this.ID = id;
            this.Name = name;   
            this.Status = status;   
        }
        public Table(DataRow row)
        {
            this.isHidden = (int)row["isHidden"];
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status= row["status"].ToString();
        }
        private int isHidden;
        private int iD;
        private string status;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public int IsHidden { get => isHidden; set => isHidden = value; }
    }
}
