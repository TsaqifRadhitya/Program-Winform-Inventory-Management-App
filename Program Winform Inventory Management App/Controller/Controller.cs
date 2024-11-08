using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program_Winform_Inventory_Management_App.Model;
using Program_Winform_Inventory_Management_App.View;

namespace Program_Winform_Inventory_Management_App
{
    public class Controller
    {
        Inventaris inventaris;
        Login login;
        Register register;
        Dashboard_Admin dashboard_Admin;
        Akun akun = new Akun();
        public void showInventaris()
        {
            inventaris = new Inventaris(this);
            inventaris.ShowDialog();
        }
        public void showILogin()
        {
            login = new Login(this);
            login.ShowDialog();
        }

        public void showIRegister()
        {
            register = new Register(this);
            register.ShowDialog();
        }

        public void showIDashboard()
        {
            dashboard_Admin = new Dashboard_Admin(this);
            dashboard_Admin.ShowDialog();
        }

        public void Login()
        {
            data_akun data_akun = new data_akun
            {
                Username = login.username.Text,
                Password = login.password.Text,
            };
            akun.login(data_akun);
            if (Session.status_session)
            {
                if (Session.login_role)
                {
                    login.Hide();
                    showIDashboard();
                    login.Close();
                }
                else
                {
                    login.Hide();
                    showInventaris();
                    login.Close();
                }
            }
        }

        public void Register()
        {
            if (String.IsNullOrEmpty(register.username.Text) || String.IsNullOrEmpty(register.password.Text) || register.password.Text != register.konfirmasi.Text)
            {
                return;
            }
            data_akun data_akun = new data_akun
            {
                Username = register.username.Text,
                Password = register.password.Text,
            };
            if (akun.Register(data_akun))
            {
                register.Hide();
                showILogin();
                register.Close();
            }
        }

        public void load_data_dasboard()
        {
            dashboard_Admin.dataGridView1.DataSource = data_barang.data_get;
            dashboard_Admin.dataGridView1.DataSource = null;
            dashboard_Admin.dataGridView1.DataSource = data_barang.data_get;
            dashboard_Admin.dataGridView1.Columns["data_get"].Visible = false;
        }

        public void load_data_inventaris()
        {
            inventaris.dataGridView1.DataSource = data_barang.data_get;
            inventaris.dataGridView1.Columns["data_get"].Visible = false;
        }
    }
}
