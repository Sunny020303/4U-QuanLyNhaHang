 using QuanLyNhaHang.DAO;
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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            LoadAccounList();
        }


        void LoadAccounList(string name="")
        {
            string query = "Select id as[Mã số] , name as[Tên hiển thị] , UserName as[Tên tài khoản] from Account where name like N'%"+name+"%'";
            dgvNhanVien.DataSource= DataProvider.Instance.ExecuteQuery(query);   
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormNewAccount form = new FormNewAccount(); 
            form.TopMost= true;
            form.ShowDialog();
            LoadAccounList();
        }

        private void btnDatMK_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận đặt lại mật khẩu?","Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                int id = (int)dgvNhanVien.CurrentRow.Cells["Mã số"].Value;
                AccountDAO.Instance.DefaultPassWord(id);
            }    
            
            LoadAccounList();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tài khoản?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = (int)dgvNhanVien.CurrentRow.Cells["Mã số"].Value;
                AccountDAO.Instance.deleteAccount(id);
                
            }
            LoadAccounList();
        }

        private void tbTimNV_TextChanged(object sender, EventArgs e)
        {
            LoadAccounList(tbTimNV.Text);
        }

       
    }
}
