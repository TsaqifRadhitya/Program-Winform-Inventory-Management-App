using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Program_Winform_Inventory_Management_App
{
    public abstract class connection
    {
        string addres = "Host=localhost;Username=postgres;Password=;Database=PBO_UTS";
        protected NpgsqlConnection conn;

        public bool execute_no_return(string query)
        {
            conn = new NpgsqlConnection(addres); 
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public NpgsqlDataReader execute_with_rturn(string query)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}
