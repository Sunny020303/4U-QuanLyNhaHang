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

namespace QuanLyNhaHang.Forms
{
    public partial class FormMain : Form
    {
        string UserName;
        int Type;
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(int type,string AccountName)
        {
            Type= type;
            UserName= AccountName;
            InitializeComponent();
            if(type == 0)
            {
                //btnTaiKhoan.Visible=false;
                btnNhanVien.Visible=false;
                btnMonAn.Visible=false;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
        
        Form CurrentForm;

        private void OpenForm(Form form)
        {
            CurrentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnView.Controls.Add(form);
            this.pnView.Tag = form;
            form.BringToFront();
            form.Show();
        }

        

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormDatMon());
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormMonAn());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormNhanVien());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormThongKe());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.FormTaiKhoan(UserName,Type));
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*private void OpenChildForm(Form childForm)
{
if (currentChildForm != null)
{
//Chi mo form
currentChildForm.Close();
if (currentChildForm.IsHandleCreated)
{
return;
}
}
//ActivateButton(btnSender);
currentChildForm = childForm;
childForm.TopLevel = false;
childForm.FormBorderStyle = FormBorderStyle.None;
childForm.Dock = DockStyle.Fill;
this.pnDesktop.Controls.Add(childForm);
this.pnDesktop.Tag = childForm;
childForm.BringToFront();
childForm.Show();

lblCurentChildForm.Text = childForm.Text.ToUpper();

}*/
    }
}
