using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)   
                    instance = new FoodDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private FoodDAO() { }

       

        public List<Food> GetCategoryListByCategory(int id,string FoodName)
        {
            List<Food> list = new List<Food>();

            DataTable data;
            if (id > 0)
            {
                data = DataProvider.Instance.ExecuteQuery("select * from Food where idcategory=" + id+"and name like N'%"+FoodName+"%'");
            }
            else
            {
                data = DataProvider.Instance.ExecuteQuery("select * from Food where name like N'%"+FoodName+"%'");
            }    
            foreach (DataRow dr in data.Rows)
            {
                Food food = new Food(dr);
                list.Add(food);
            }
            return list;
        }
        public DataTable GetDataFoodListByCategory(int id, string FoodName)
        {
           

            DataTable data;
            if (id > 0)
            {
                data = DataProvider.Instance.ExecuteQuery("select food.id , food.name as [Tên món ăn] , foodcategory.name as [Danh mục] ,price as [Giá tiền]  from Food,foodcategory where  food.name like N'%" + FoodName + "%' and idCategory=foodcategory.id and idcategory=" + id +" and Food.ishidden=0");
            }
            else
            {
                data = DataProvider.Instance.ExecuteQuery("select food.id , food.name as [Tên món ăn] , Foodcategory.name as [Danh mục] ,price as [Giá tiền]  from Food,foodcategory where  food.name like N'%" + FoodName + "%' and idCategory=foodcategory.id and food.ishidden=0");
            }
            
            return data;
        }

        public void DeleteFoodbyId(int id)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("update food set ishidden=1 where id="+id);
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch {
                MessageBox.Show("Thất bại!", "Thông báo");
            }
        }
        public void CreateFood(string name,int idCategory,float price)
        { 
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_CreateFood @name , @category , @price",new object[] {name,idCategory,price});
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thất bại!", "Thông báo");
            }
        }

        public void UpdateFood(int id,string name, int idCategory, float price)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_UpdateFood @id , @name , @category , @price", new object[] { id,name, idCategory, price });
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thất bại!", "Thông báo");
            }
        }
    }
}
