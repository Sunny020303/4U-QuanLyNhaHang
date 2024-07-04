using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.Forms
{
    public partial class FormNewFood : Form
    {
        int id=0;
        public FormNewFood()
        {
            InitializeComponent();
            loadCategory();
        }
        public FormNewFood(DataGridViewRow row)
        {
            InitializeComponent();
            string CategoryName= row.Cells["Danh mục"].Value.ToString();
            id = (int)Convert.ToInt32(row.Cells["id"].Value);
            loadCategory();
            tbFoodName.Text = row.Cells["Tên món ăn"].Value.ToString();
            tbGiaTien.Text = row.Cells["Giá tiền"].Value.ToString();
            cbCategory.SelectedIndex = cbCategory.FindStringExact(CategoryName);
            lbTitle.Text= "Sửa món ăn "+ row.Cells["Tên món ăn"].Value.ToString();
            //while(!CategoryName.Equals((cbCategory.SelectedItem as Category).Name))
            //{
            //    cbCategory.SelectedItem= CategoryName;
            //}    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if(tbFoodName.Text.Length == 0 || tbGiaTien.Text.Length==0) {
                return;
            }
            string name=tbFoodName.Text;
            float price = (float)Convert.ToDouble(tbGiaTien.Text);
            int category = (cbCategory.SelectedItem as Category).Id;
            if (id == 0)
            {
                if (MessageBox.Show("Xác nhận thêm món ăn", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FoodDAO.Instance.CreateFood(name, category, price);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa món ăn", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FoodDAO.Instance.UpdateFood(id,name, category, price);
                    this.Close();
                }
            }
        }
        public void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetCategoryList();
            
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
    }
}
