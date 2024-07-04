using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Order
    {
        private int idFood;
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int IdFood { get => idFood; set => idFood = value; }

        public Order(int idFood,string foodName, int count, float price, float totalPrice)
        {
            FoodName = foodName;
            Count = count;
            Price = price;
            TotalPrice = totalPrice;
            IdFood = idFood;
        }
        public Order(DataRow row)
        {
            FoodName = row["Name"].ToString();
            Count = (int)row["count"];
            IdFood = (int)row["id"];
            Price = (float)Convert.ToDouble(row["price"].ToString()) ;
            TotalPrice = (float)Convert.ToDouble(row["total"].ToString());
        }
    }
}
