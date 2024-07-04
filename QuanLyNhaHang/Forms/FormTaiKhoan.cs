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
    public partial class FormTaiKhoan : Form
    {
        string UserName;
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        public FormTaiKhoan(string username,int type)
        {
            InitializeComponent();
            UserName = username;
            Account user=AccountDAO.Instance.GetAccountByUserName(UserName);
            lblDisplayName.Text = user.Name;
            txtUserName.Text = user.Username;
            txtDisplayName.Text= user.Name; 
            if(type== 0 )
            {
                txtUserName.ReadOnly= true;
            }
            
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(AccountDAO.Instance.Login(txtUserName.Text,txtPassWord.Text)==-1)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!\nVui lòng nhập lại!", "Thông báo");
                return;
            }
            if (txtNewPassWord.Text.Equals(txtConfirmPW.Text))
            {
                if (MessageBox.Show("Xác nhận cập nhật tài khoản?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (AccountDAO.Instance.UpdateAccount(txtUserName.Text, txtDisplayName.Text, txtNewPassWord.Text) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    }
                    else MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                }
            }
            else MessageBox.Show("Mật khẩu nhập lại không khớp với mật khẩu cần đổi!\nVui lòng nhập lại!", "Thông báo");

            
        }
    }
}
