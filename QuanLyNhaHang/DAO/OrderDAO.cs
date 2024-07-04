using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private OrderDAO() { }

        public List<Order> GetListOrderByTable(int id)
        {
            List<Order> listOrder = new List<Order>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select Food.id, Food.Name, BillInfo.count ,Food.price, Food.price*BillInfo.count as total\r\nfrom BillInfo,Bill,Food \r\nwhere Bill.id=BillInfo.idBill and BillInfo.idFood=Food.id and bill.status=0 and Bill.idTable=" + id.ToString());
            foreach(DataRow item in data.Rows)
            {
                Order order = new Order(item);
                listOrder.Add(order);
            }
            return listOrder;

        }
    }
}
