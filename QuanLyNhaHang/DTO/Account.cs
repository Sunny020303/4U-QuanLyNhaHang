using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Account
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private int type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }

        public Account(int id, string name, string username, string password, int type)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Type = type;
        }

        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Username = row["UserName"].ToString();
            this.Name = row["name"].ToString();
            this.Type = (int)row["Type"];
            this.Password = row["PassWord"].ToString();

        }
    }
}
