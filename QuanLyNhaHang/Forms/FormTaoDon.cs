using QuanLyNhaHang.DTO;
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
using Guna.UI2.WinForms;
//using System.Web.UI.WebControls;

namespace QuanLyNhaHang.Forms
{
    public partial class FormTaoDon : Form
    {
        private int idTable=0;
        private Food currentFood= null;
        private int idBill;
        private List<Order> FoodOrders = new List<Order>();
        float total = 0;
        public FormTaoDon()
        {
            InitializeComponent();
        }
        //khởi tạo form
        public FormTaoDon(int TableID)
        {
            idTable = TableID;
            InitializeComponent();
            LoadCategory();
            LoadTable();
            idBill=BillDAO.Instance.GetUncheckBillIDbyTableID(TableID);
            if(idBill==-1)
            {
                lbSoHD.Text = "Đơn hàng mới";
                btnChinhDon.Enabled=false;
                btnHuyDon.Enabled=false;
                btnThanhToan.Enabled=false;
            }
            else
            {
                lbSoHD.Text = "Đơn hàng số " +idBill;
                
                lbSoHD.Text = "Đơn hàng số: " + idBill;
                ShowBill(TableID);
                btnTaoDon.Enabled=false;
                Bill bill=BillDAO.Instance.getBillinfo(idBill);
                nmGiamGia.Value =bill.Discount;
            }
           
        }
        private void ShowBill(int id)
        {
            lvDSMA.Items.Clear();
            total = 0;
            FoodOrders = OrderDAO.Instance.GetListOrderByTable(id);
            foreach(Order item in FoodOrders) { 
                ListViewItem lvItem =new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                lvItem.Tag = item;
                total += item.TotalPrice;
                lvDSMA.Items.Add(lvItem);
            }
            total = (1 - (float)nmGiamGia.Value/100) * total;
            tbTotal.Text = total.ToString();
        }

        private void LoadTable()
        {
            
            List<DTO.Table> listTable = TableDAO.Instance.LoadTableList();
            cbTable.DataSource = listTable;
            cbTable.DisplayMember = "Name";
            
            int id = idTable;
            foreach(Table item in cbTable.Items)
            {
                if(item.ID == idTable)
                {
                    cbTable.SelectedIndex = cbTable.Items.IndexOf(item);
                    return;
                }
            }
        }

        void LoadCategory()
        {
            
            List<Category> listCategory = CategoryDAO.Instance.GetCategoryList();
            Category TatCa = new Category(0, "Tất cả");
            listCategory.Insert(0, TatCa);
            cbCategory.DataSource= listCategory;
            cbCategory.DisplayMember= "Name";  
            
        }
        void LoadFoodbyCategory(int id,string FoodName="")
        {
            List<Food> food;
           
                food = FoodDAO.Instance.GetCategoryListByCategory(id,FoodName);
            

            foreach(Food item in food)
            {
                Guna2Button btn=new Guna2Button();
                btn.Width = 230;btn.Height = 130;
                btn.BorderRadius= 10;
                btn.Text = item.Name+Environment.NewLine+item.Price.ToString()+"đ";
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Click += Btn_Click;
                btn.Tag= item;
                flpFood.Controls.Add(btn);  
            }
        }
        


        #region event
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            Guna2ComboBox cb=sender as Guna2ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected=cb.SelectedItem as Category;
            id=selected.Id;
            flpFood.Controls.Clear();
            LoadFoodbyCategory(id,tbFoodFind.Text);
        }
        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Guna2ComboBox cb = sender as Guna2ComboBox;
            if (cb.SelectedItem == null) return;
            Table tb=cb.SelectedItem as Table;
            int newTable = tb.ID;
            
            if (idBill!=-1)
            {
                BillDAO.Instance.updateBillTable(idBill, newTable);
                TableDAO.Instance.ChangeTableState(idTable, 0);
                idTable = newTable;
            }
            else
            {
                idTable = newTable;
            }
            
        } 
        private void cbTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guna2ComboBox cb = sender as Guna2ComboBox;
            if (cb.SelectedItem == null) return;
            Table tb = cb.SelectedItem as Table;
            int newTable = tb.ID;

            if (idBill != -1)
            {
                BillDAO.Instance.updateBillTable(idBill, newTable);
                TableDAO.Instance.ChangeTableState(idTable, 0);
                
            }
           
                idTable = newTable;
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            currentFood=(sender as Guna2Button).Tag as Food;
            lbDonGia.Text=currentFood.Price.ToString();
            lbTenMA.Text=currentFood.Name.ToString();
            foreach (Order item in FoodOrders)
            {

                if (currentFood.Id == item.IdFood)
                {
                    nmSoLuong.Value = item.Count;
                    return;
                }
            }
            nmSoLuong.Value = 0;
        }
        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            /*if (currentFood == null) return;
            if(FoodOrders is null)
            {
                FoodOrders = new List<Order>();
            }
            Guna2NumericUpDown nm=sender as Guna2NumericUpDown;
            
            Order currentOrder=new Order(currentFood.Id,currentFood.Name,(int)nm.Value,currentFood.Price,currentFood.Price*(float)nm.Value);
            if (nm.Value == 0) currentOrder = null;*/
        }

        
        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (currentFood == null) return;
            int idFood = currentFood.Id;
            int count = (int)nmSoLuong.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.insertBill(idTable);
                idBill = BillDAO.Instance.GetUncheckBillIDbyTableID(idTable);
                BillInfoDAO.Instance.insertBillInfo(idBill, idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.insertBillInfo(idBill, idFood, count);
            }
            ShowBill(idTable);
        }

       
        

        private void lvDSMA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            Order food = ((sender as ListView).SelectedItems[0].Tag as Order);
            nmSoLuong.Value = food.Count;
            lbDonGia.Text = food.Price.ToString();
            lbTenMA.Text = food.FoodName.ToString();
            currentFood = new Food(food.IdFood, food.FoodName, food.Price, 0);
        }
        
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            if (FoodOrders.Count == 0)
            {
                MessageBox.Show("Xin hãy thêm món ăn vào đơn!", "Thông báo");
                return;
            }
            TableDAO.Instance.ChangeTableState(idTable, 1);
            BillDAO.Instance.updateBillTotal(idBill, float.Parse(tbTotal.Text), (int)nmGiamGia.Value);
            this.Close(); 
        }
        private void btnChinhDon_Click(object sender, EventArgs e)
        {
            if (FoodOrders.Count == 0)
            {
                MessageBox.Show("Xin hãy thêm món ăn vào đơn!", "Thông báo");
                return;
            }
            TableDAO.Instance.ChangeTableState(idTable, 1);
            BillDAO.Instance.updateBillTotal(idBill, float.Parse(tbTotal.Text), (int)nmGiamGia.Value);
            this.Close();
        }
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (idTable == -1) this.Close();
            if (MessageBox.Show("Bạn có thực sự muốn hủy đơn?", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                DataProvider.Instance.ExecuteNonQuery("EXEC USP_DELETEBILL @idBill", new object[] { idBill });
                this.Close();
            }
            TableDAO.Instance.ChangeTableState(idTable, 0);
        }
       

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (idBill == -1) return;
            if(FoodOrders.Count==0)
            {
                DataProvider.Instance.ExecuteNonQuery("EXEC USP_DELETEBILL @idBill", new object[] { idBill });
                TableDAO.Instance.ChangeTableState(idTable, 0);
                return;
            }
            TableDAO.Instance.ChangeTableState(idTable, 1);
 
        }
       

        private void tbFoodFind_TextChanged(object sender, EventArgs e)
        {
            int id = 0;
            Category selected = cbCategory.SelectedItem as Category;
            id = selected.Id;
            flpFood.Controls.Clear();
            LoadFoodbyCategory(id, tbFoodFind.Text);
        }

        private void nmGiamGia_ValueChanged(object sender, EventArgs e)
        {
            
            float giamgia = (float)nmGiamGia.Value;
            float LastPrice = total * (1 - (giamgia/100));
            tbTotal.Text = LastPrice.ToString();
        }



        #endregion

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string thongbao="Bạn có muốn thanh toán hóa đơn số: "+idBill+"\nGiảm giá "+(int)nmGiamGia.Value+"%\nTổng tiền: "+tbTotal.Text+"VND";
            if(MessageBox.Show(thongbao,"Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Bill bill=BillDAO.Instance.getBillinfo(idBill);
                FormHoaDon form= new FormHoaDon(bill);
                form.TopMost= true;
                form.ShowDialog();
                TableDAO.Instance.ChangeTableState(idTable, 0);    
                BillDAO.Instance.payBill(idBill);
                this.Close();
                
            }    
        }

        private void cbTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
