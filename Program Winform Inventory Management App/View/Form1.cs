namespace Program_Winform_Inventory_Management_App
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Inventaris_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.showInventaris();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.showIRegister();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.showILogin();
            this.Close();
        }
    }
}
