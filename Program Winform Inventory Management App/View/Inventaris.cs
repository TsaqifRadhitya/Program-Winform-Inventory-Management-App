using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Winform_Inventory_Management_App.View
{
    public partial class Inventaris : Form
    {
        Controller controller;
        public Inventaris(Controller controller)
        {
            InitializeComponent();
            this.controller=controller;
            this.controller.load_data_inventaris();

        }

        private void Inventaris_Load(object sender, EventArgs e)
        {

        }
    }
}
