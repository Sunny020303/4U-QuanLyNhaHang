using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();   
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfos(int id)
        {
            List <BillInfo> listBillInfo= new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill=" + id);
            foreach(DataRow row in data.Rows) {
                BillInfo info= new BillInfo(row);
                listBillInfo.Add(info); 
            }
            return listBillInfo;
        }

        public void insertBillInfo(int idBill,int idFood,int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_CreateBillInfo @idBill , @idFood , @count", new object[] { idBill,idFood,count });
        }
    }
}
