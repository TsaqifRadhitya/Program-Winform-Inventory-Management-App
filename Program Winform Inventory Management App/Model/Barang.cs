using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Program_Winform_Inventory_Management_App.Model
{
     public class Barang : connection
    {
        public void get()
        {
            NpgsqlDataReader data = execute_with_rturn("select * from barang");
            data_barang.data_get = new List<data_barang1>();
            while (data.Read()){
                data_barang1 barang = new data_barang1
                {
                    nama = data["nama"].ToString(),
                    jumlah =(int) data["jumlah"],
                    harga = (int)data["harga"],
                    jenis = data["kategori"].ToString()
                };
                data_barang.data_get.Add(barang);
            }
        }

        public void set() 
        { 

        }
    }

    public class data_barang1
    {
        public string nama {  get; set; }
        public int jumlah {  get; set; }
        public int harga {  get; set; }
        public string jenis { get; set; }
        
    }

    public class data_barang
    {
        public static List<data_barang1> data_get { get; set; }
    }

}
