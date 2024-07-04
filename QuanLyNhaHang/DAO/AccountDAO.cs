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
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();    
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }

        public int Login(string username, string password)
        {

            string query = "EXEC USP_Login @userName , @passWord";
            DataTable result=DataProvider.Instance.ExecuteQuery(query,new object[] { username,password});
            if (result.Rows.Count > 0)
            {
                DataRow row= result.Rows[0];    
                int type= (int)row["type"];
                return type;
            }
            return -1;
        }

        public int UpdateAccount(string username,string name,string password)
        {
            
            return (int)(DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @username , @name , @password", new object[] { username, name, password }));
                     
        }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where UserName=N'"+username+"'");
            DataRow dataRow= data.Rows[0];
            Account account= new Account(dataRow);
            return account;
        }
        public void deleteAccount(int id)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("delete from account where id="+id);
                MessageBox.Show("Tài khoản đã xóa thành công!","Thông báo");
            }
            catch {
                MessageBox.Show("Thao tác thất bại!", "Thất bại");
            }
            
        }
        public void DefaultPassWord(int id)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("Update account set password=1 where id=" + id);
                MessageBox.Show("Mật khẩu đã được đổi về mặt định!\nMật khẩu mặt định là: 1", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại!", "Thất bại");
            }
        }
        public void CreateAccount(string username, int admin)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_CreateAccount @username , @type",new object[] { username, admin });
                MessageBox.Show("Tạo tài Khoản mới thành công!\nMật khẩu: 1");
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại!", "Thất bại");
            }
        }
    }
}
