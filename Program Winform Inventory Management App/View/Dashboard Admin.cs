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
    public partial class Dashboard_Admin : Form
    {
        Controller controller;
        public Dashboard_Admin(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.controller.load_data_dasboard();
        }

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}