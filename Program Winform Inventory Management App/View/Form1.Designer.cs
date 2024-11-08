namespace Program_Winform_Inventory_Management_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inventaris = new Button();
            Register = new Button();
            Login = new Button();
            SuspendLayout();
            // 
            // Inventaris
            // 
            Inventaris.Location = new Point(12, 12);
            Inventaris.Name = "Inventaris";
            Inventaris.Size = new Size(227, 426);
            Inventaris.TabIndex = 0;
            Inventaris.Text = "Inventaris";
            Inventaris.UseVisualStyleBackColor = true;
            Inventaris.Click += Inventaris_Click;
            // 
            // Register
            // 
            Register.Location = new Point(245, 12);
            Register.Name = "Register";
            Register.Size = new Size(238, 426);
            Register.TabIndex = 1;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Login
            // 
            Login.Location = new Point(489, 12);
            Login.Name = "Login";
            Login.Size = new Size(299, 426);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(Register);
            Controls.Add(Inventaris);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Halaman Welcome";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Inventaris;
        private Button Register;
        private Button Login;
    }
}
