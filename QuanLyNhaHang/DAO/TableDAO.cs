using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyNhaHang.DAO
{
    public class TableDAO
    {
        public static int Width = 250;
        public static int Height = 150;   

        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)   
                    instance = new TableDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach(DataRow item in data.Rows) 
            {
                Table table = new Table(item);
                tableList.Add(table);
                
            }

            return tableList;
        }

        public void ChangeTableState(int idTable,int status)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_ChangeTableState @idTable , @status",new object[] { idTable,status});
        }
        public void AddTable(string TableName="")
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddTable @name",new object[] {TableName});
        }
        public void DeleteTable(int idTable) {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("UPDATE TableFood set isHidden=1 WHERE id=" + idTable);
            }
            catch {
                MessageBox.Show("Thất bại", "Thông báo");
            }
        }
        public void EditTable(int idTable,string name)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("EXEC USP_ChangeTableName @idTable , @name", new object[] {idTable,name});
            }
            catch
            {
                MessageBox.Show("Thất bại!", "Thông báo");
            }
            
        }
    }
}
