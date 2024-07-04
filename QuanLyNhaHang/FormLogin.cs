
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QuanLyNhaHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng","Thông báo",MessageBoxButtons.OKCancel) != DialogResult.OK) 
            {
                e.Cancel = true;
            }
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text;
            string password = tbMatKhau.Text;
            int type = Login(username, password); 
            if (type != -1)
            {
                
                FormMain form = new FormMain(type,username);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }
       
        int Login(string username, string password)
        {
            
            return AccountDAO.Instance.Login(username, password);
        }
    }
}
