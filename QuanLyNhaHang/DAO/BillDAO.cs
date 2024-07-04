using System;
using QuanLyNhaHang.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaHang.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();   
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BillDAO() { }

        public int GetUncheckBillIDbyTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill where idTable = "+id.ToString()+" and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
            //Thanh cong->ID ; that bai->-1
        }

        public void insertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_CreateBill @idTable", new object[] { idTable });
        }

        public void deleteBill(int idBill) {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DELETEBILL @idBill", new object[] { idBill });
        }
        public void updateBillTotal(int idBill,float TotalPrice, int Discount)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateTotalBill @idBill , @ToTalPrice , @Discount", new object[] { idBill ,TotalPrice,Discount});
        }
        public void updateBillTable(int idBill,int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateBillTable @idBill , @idTable",new object[] { idBill ,idTable });
        }
        public void payBill(int idBill)
        {
            DataProvider.Instance.ExecuteNonQuery("Update Bill set status=1 , DateCheckOut=GETDATE() where id=" + idBill);
        }
        public Bill getBillinfo(int idBill)
        {
            DataTable data;
            data = DataProvider.Instance.ExecuteQuery("Select * from Bill where id=" + idBill);           
            DataRow row= data.Rows[0];
            Bill billinfo=new Bill(row);
            return billinfo;
        }
        public DataTable getBillByDate(DateTime checkIn,DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDate @cin , @cout", new object[] {checkIn,checkOut});
        }
    }
}
