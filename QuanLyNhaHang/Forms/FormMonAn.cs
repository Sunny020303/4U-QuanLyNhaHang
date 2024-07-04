using Guna.UI2.WinForms;
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
    public partial class FormMonAn : Form
    {

        public FormMonAn()
        {
            InitializeComponent();
            LoadFoodbyCategory(0,"");
            LoadCategory();
        }

        private void tbTimMonAn_TextChanged(object sender, EventArgs e)
        {
            Category c= cbCategory.SelectedItem as Category;
            dgvMonAn.DataSource = FoodDAO.Instance.GetDataFoodListByCategory(c.Id, tbTimMonAn.Text);
        }
        void LoadFoodList()
        {
            string query = "Select * from food";
            dgvMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadFoodbyCategory(int id, string FoodName = "")
        {


            dgvMonAn.DataSource = FoodDAO.Instance.GetDataFoodListByCategory(id, FoodName);


            
        }
        void LoadCategory()
        {
            Category TatCa = new Category(0, "Tất cả");
            List<Category> listCategory = CategoryDAO.Instance.GetCategoryList();
            listCategory.Insert(0, TatCa);
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            Guna2ComboBox cb = sender as Guna2ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodbyCategory(id, tbTimMonAn.Text);
        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa món ăn?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)dgvMonAn.CurrentRow.Cells["id"].Value;
                FoodDAO.Instance.DeleteFoodbyId(id);

            }
            LoadFoodbyCategory((cbCategory.SelectedItem as Category).Id,tbTimMonAn.Text);
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            FormNewFood form= new FormNewFood();
            form.TopMost= true;
            form.ShowDialog();
            LoadFoodbyCategory((cbCategory.SelectedItem as Category).Id, tbTimMonAn.Text);
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMonAn.CurrentRow;
            FormNewFood form = new FormNewFood(row);
            form.TopMost = true;
            form.ShowDialog();
            LoadFoodbyCategory((cbCategory.SelectedItem as Category).Id, tbTimMonAn.Text);
        }
    }
}
