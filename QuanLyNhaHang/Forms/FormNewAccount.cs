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
    public partial class FormNewAccount : Form
    {
        public FormNewAccount()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text.Length == 0)
            {
                return;
            }
            if(tbUserName.Text.Length == 0) { return; }
            if(MessageBox.Show("Xác nhận tạo tài Khoản mới?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK) { 
                int i=(cbAdmin.Checked==true) ? 1 : 0;  
                AccountDAO.Instance.CreateAccount(tbUserName.Text, i);
                this.Close();
            }
        }
    }
}
