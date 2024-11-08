using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Program_Winform_Inventory_Management_App
{
    public class Akun : connection
    {
        public bool Register(data_akun data)
        {
            return execute_no_return($"insert into Akun(username,password,admin) values ('{data.Username}','{data.Password}',false)");
        }

        public void login(data_akun data)
        {
            NpgsqlDataReader Data = execute_with_rturn($"select admin from akun where username = '{data.Username}' and password = '{data.Password}'");
            while (Data.Read())
            {
                Session.login_role = (bool)Data["admin"];
                Session.status_session = true;
            }
        }
    }

    public class data_akun
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
