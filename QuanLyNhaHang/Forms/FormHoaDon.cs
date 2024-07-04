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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        public FormHoaDon(Bill bill)
        { 
            InitializeComponent();
            lbTotal.Text=bill.Total.ToString()+" VND";
            lbDiscount.Text=bill.Discount.ToString();
            string dt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lbNgayXuat.Text=dt;
            lbBillid.Text=bill.ID.ToString();
            lbBan.Text=bill.IdTable.ToString();
            List<Order> OrderList=OrderDAO.Instance.GetListOrderByTable(bill.IdTable);
            foreach(Order item in OrderList )
            {
                ListViewItem lvItem = new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                lvHoaDon.Items.Add(lvItem);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
