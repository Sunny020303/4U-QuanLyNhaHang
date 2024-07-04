using Guna.UI2.WinForms;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyNhaHang.Forms
{
    public partial class FormDatMon : Form
    {
        public bool DeleteMode=false;
        public bool EditMode=false;
        public FormDatMon()
        {
            InitializeComponent();
            LoadTable();
        }
        
        public void LoadTable()
        {
            flpBanAn.Controls.Clear();
            List<DTO.Table> tableList = TableDAO.Instance.LoadTableList();
            foreach(DTO.Table item in tableList)
            {
                if (item.IsHidden == 1) continue;
                Guna2Button btn = new Guna2Button() { Width = TableDAO.Width, Height = TableDAO.Height };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Click += btn_Click;
                btn.BorderRadius = 10;
                if(item.Status.Equals("Có người"))
                {
                    btn.FillColor = Color.Red;
                }
                btn.Font = new Font("Segoe UI", 15,FontStyle.Bold);
                
                flpBanAn.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Guna2Button).Tag as Table).ID;
            if (DeleteMode == false && EditMode == false)
            {
                
                FormTaoDon form = new FormTaoDon(tableID);
                form.TopMost = true;
                form.ShowDialog();
                flpBanAn.Controls.Clear();   
            }
            if(DeleteMode)
            {
                if(BillDAO.Instance.GetUncheckBillIDbyTableID(tableID)==-1)
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?","Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        TableDAO.Instance.DeleteTable(tableID);
                    }
                }
                else
                {
                    MessageBox.Show("Bàn này có đơn chưa thanh toán nên không xóa được!", "Thông báo");
                }
            }
            if (EditMode)
            {
                if (tbTenBan.Text.Equals("")) tbTenBan.PlaceholderText = "Xin hãy nhập tên bàn!!!";
                else
                {
                    TableDAO.Instance.EditTable(tableID, tbTenBan.Text);
                }
            }
            LoadTable();
        }
        private void FormBanAn_Load(object sender, EventArgs e)
        {
            
        }
        private void btnXoaBan_Click(object sender, EventArgs e)
        { 
            if(DeleteMode) { DeleteMode= false; }
            else { DeleteMode= true; }  
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm bàn?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.AddTable("Chưa đặt tên");
                LoadTable();
            }
        }

        private void btnXoaBan_Click_1(object sender, EventArgs e)
        {
            if (DeleteMode) {
                btnXoaBan.BorderThickness = 0;
                DeleteMode = false; }
            else {
                btnXoaBan.BorderThickness = 5;
                btnDoiTen.BorderThickness = 0;
                tbTenBan.Visible = false;
                tbTenBan.Text = "";
                EditMode = false;
                DeleteMode= true; 
            }  
        }

        private void btnDoiTen_Click(object sender, EventArgs e)
        {
            if (EditMode) {
                btnDoiTen.BorderThickness = 0;
                tbTenBan.Visible= false;
                EditMode = false; 
            }
            else { 
                btnDoiTen.BorderThickness=5;
                btnXoaBan.BorderThickness = 0;
                tbTenBan.Visible= true;
                tbTenBan.Text = "";
                EditMode = true;
                DeleteMode = false;
            }
        }
    }
}
