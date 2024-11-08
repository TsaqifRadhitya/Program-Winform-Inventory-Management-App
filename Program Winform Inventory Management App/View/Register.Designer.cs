namespace Program_Winform_Inventory_Management_App.View
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            label3 = new Label();
            konfirmasi = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 292);
            button1.Name = "button1";
            button1.Size = new Size(319, 55);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // password
            // 
            password.Location = new Point(126, 144);
            password.Name = "password";
            password.Size = new Size(304, 23);
            password.TabIndex = 6;
            // 
            // username
            // 
            username.Location = new Point(126, 103);
            username.Name = "username";
            username.Size = new Size(304, 23);
            username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 11;
            label3.Text = "Konfirmasi Password";
            // 
            // konfirmasi
            // 
            konfirmasi.Location = new Point(126, 184);
            konfirmasi.Name = "konfirmasi";
            konfirmasi.Size = new Size(304, 23);
            konfirmasi.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(label3);
            Controls.Add(konfirmasi);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        public TextBox username;
        public TextBox password;
        public TextBox konfirmasi;
    }
}