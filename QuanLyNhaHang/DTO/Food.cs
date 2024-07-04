using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private float price;
        private int iDcategory;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int IDcategory { get => iDcategory; set => iDcategory = value; }

        public Food(int id, string name, float price, int iDcategory)
        {
            Id = id;
            Name = name;
            Price = price;
            IDcategory = iDcategory;
        }
        public Food(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
            Price = float.Parse(row["price"].ToString());
            IDcategory = (int)row["idcategory"];
        }
    }
}
