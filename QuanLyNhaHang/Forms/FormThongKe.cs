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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            float total = 0;
            InitializeComponent();
            timeFrom.Value=DateTime.Now;
            timeTo.Value = DateTime.Now;
            dgvThongKe.DataSource= BillDAO.Instance.getBillByDate(timeFrom.Value, timeTo.Value);
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                total += (float)Convert.ToDouble(row.Cells["Tổng tiền"].Value);
            }
            lbDoanhThu.Text = total.ToString()+" VND";
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            float total = 0;
            dgvThongKe.DataSource = BillDAO.Instance.getBillByDate(timeFrom.Value, timeTo.Value);
            foreach(DataGridViewRow row in dgvThongKe.Rows )
            {
                total += (float)Convert.ToDouble(row.Cells["Tổng tiền"].Value);
            }
            lbDoanhThu.Text = total.ToString()+" VND";
        }
    }
}
