namespace WinFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            label1 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lblSuksesAtauGagalLogin = new Label();
            btnRegisterBuat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(714, 520);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(762, 76);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(714, 56);
            label1.Name = "label1";
            label1.Size = new Size(677, 88);
            label1.TabIndex = 1;
            label1.Text = "MASUK APLIKASI";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(714, 299);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Masukkan Email atau Username";
            tbUsername.Size = new Size(762, 39);
            tbUsername.TabIndex = 6;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(714, 425);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Masukkan kata sandi";
            tbPassword.Size = new Size(762, 39);
            tbPassword.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1472, -143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2135, 1061);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(714, 251);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 9;
            label2.Text = "Email atau Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(714, 375);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 10;
            label3.Text = "Kata sandi";
            // 
            // lblSuksesAtauGagalLogin
            // 
            lblSuksesAtauGagalLogin.AutoSize = true;
            lblSuksesAtauGagalLogin.BackColor = Color.Transparent;
            lblSuksesAtauGagalLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuksesAtauGagalLogin.ForeColor = Color.LimeGreen;
            lblSuksesAtauGagalLogin.Location = new Point(714, 181);
            lblSuksesAtauGagalLogin.Name = "lblSuksesAtauGagalLogin";
            lblSuksesAtauGagalLogin.Size = new Size(0, 32);
            lblSuksesAtauGagalLogin.TabIndex = 11;
            lblSuksesAtauGagalLogin.Visible = false;
            // 
            // btnRegisterBuat
            // 
            btnRegisterBuat.BackColor = Color.Transparent;
            btnRegisterBuat.FlatAppearance.BorderSize = 0;
            btnRegisterBuat.FlatStyle = FlatStyle.Flat;
            btnRegisterBuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterBuat.ForeColor = Color.White;
            btnRegisterBuat.Location = new Point(714, 638);
            btnRegisterBuat.Name = "btnRegisterBuat";
            btnRegisterBuat.Size = new Size(762, 76);
            btnRegisterBuat.TabIndex = 12;
            btnRegisterBuat.Text = "Or Register";
            btnRegisterBuat.UseVisualStyleBackColor = false;
            btnRegisterBuat.Click += btnRegisterBuat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(btnRegisterBuat);
            Controls.Add(lblSuksesAtauGagalLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            ForeColor = Color.Coral;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin.cs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtA;
        private Button btnLogin;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label lblSuksesAtauGagalLogin;
        private Button btnRegisterBuat;
    }
}
