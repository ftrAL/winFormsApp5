namespace WinFormsApp5
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            lblBuatUsername = new Label();
            txtBuatUserName = new TextBox();
            txtBuatPassAnda = new TextBox();
            lblBuatPass = new Label();
            txtKonfirPass = new TextBox();
            lblKonfirPass = new Label();
            btnKonfirmPUserPass = new Button();
            btnMasukSkrg = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBuatUsername
            // 
            lblBuatUsername.AutoSize = true;
            lblBuatUsername.BackColor = Color.Transparent;
            lblBuatUsername.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuatUsername.ForeColor = Color.White;
            lblBuatUsername.Location = new Point(352, 217);
            lblBuatUsername.Name = "lblBuatUsername";
            lblBuatUsername.Size = new Size(330, 37);
            lblBuatUsername.TabIndex = 0;
            lblBuatUsername.Text = "Buat username anda";
            // 
            // txtBuatUserName
            // 
            txtBuatUserName.Location = new Point(762, 218);
            txtBuatUserName.Name = "txtBuatUserName";
            txtBuatUserName.PlaceholderText = "cth. fathir";
            txtBuatUserName.Size = new Size(470, 39);
            txtBuatUserName.TabIndex = 1;
            // 
            // txtBuatPassAnda
            // 
            txtBuatPassAnda.Location = new Point(762, 323);
            txtBuatPassAnda.Name = "txtBuatPassAnda";
            txtBuatPassAnda.PlaceholderText = "6 - 20 karakter huruf dan angka";
            txtBuatPassAnda.Size = new Size(470, 39);
            txtBuatPassAnda.TabIndex = 3;
            // 
            // lblBuatPass
            // 
            lblBuatPass.AutoSize = true;
            lblBuatPass.BackColor = Color.Transparent;
            lblBuatPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuatPass.ForeColor = Color.White;
            lblBuatPass.Location = new Point(350, 322);
            lblBuatPass.Name = "lblBuatPass";
            lblBuatPass.Size = new Size(328, 37);
            lblBuatPass.TabIndex = 2;
            lblBuatPass.Text = "Buat password anda";
            // 
            // txtKonfirPass
            // 
            txtKonfirPass.Location = new Point(762, 429);
            txtKonfirPass.Name = "txtKonfirPass";
            txtKonfirPass.PlaceholderText = "Masukkan kembali";
            txtKonfirPass.Size = new Size(470, 39);
            txtKonfirPass.TabIndex = 5;
            // 
            // lblKonfirPass
            // 
            lblKonfirPass.AutoSize = true;
            lblKonfirPass.BackColor = Color.Transparent;
            lblKonfirPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKonfirPass.ForeColor = Color.White;
            lblKonfirPass.Location = new Point(252, 428);
            lblKonfirPass.Name = "lblKonfirPass";
            lblKonfirPass.Size = new Size(427, 37);
            lblKonfirPass.TabIndex = 4;
            lblKonfirPass.Text = "Konfirmasi password anda";
            // 
            // btnKonfirmPUserPass
            // 
            btnKonfirmPUserPass.BackColor = Color.LimeGreen;
            btnKonfirmPUserPass.FlatAppearance.BorderSize = 0;
            btnKonfirmPUserPass.FlatStyle = FlatStyle.Flat;
            btnKonfirmPUserPass.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmPUserPass.ForeColor = Color.White;
            btnKonfirmPUserPass.Location = new Point(542, 583);
            btnKonfirmPUserPass.Name = "btnKonfirmPUserPass";
            btnKonfirmPUserPass.Size = new Size(379, 73);
            btnKonfirmPUserPass.TabIndex = 6;
            btnKonfirmPUserPass.Text = "Konfirmasi";
            btnKonfirmPUserPass.UseVisualStyleBackColor = false;
            btnKonfirmPUserPass.Click += btnKonfirmPUserPass_Click;
            // 
            // btnMasukSkrg
            // 
            btnMasukSkrg.BackColor = Color.LimeGreen;
            btnMasukSkrg.FlatAppearance.BorderSize = 0;
            btnMasukSkrg.FlatStyle = FlatStyle.Flat;
            btnMasukSkrg.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasukSkrg.ForeColor = Color.White;
            btnMasukSkrg.Location = new Point(1194, 761);
            btnMasukSkrg.Name = "btnMasukSkrg";
            btnMasukSkrg.Size = new Size(276, 73);
            btnMasukSkrg.TabIndex = 7;
            btnMasukSkrg.Text = "Masuk sekarang";
            btnMasukSkrg.UseVisualStyleBackColor = false;
            btnMasukSkrg.Click += btnMasukSkrg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1194, 716);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 8;
            label1.Text = "Sudah punya akun?";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(label1);
            Controls.Add(btnMasukSkrg);
            Controls.Add(btnKonfirmPUserPass);
            Controls.Add(txtKonfirPass);
            Controls.Add(lblKonfirPass);
            Controls.Add(txtBuatPassAnda);
            Controls.Add(lblBuatPass);
            Controls.Add(txtBuatUserName);
            Controls.Add(lblBuatUsername);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuatUsername;
        private TextBox txtBuatUserName;
        private TextBox txtBuatPassAnda;
        private Label lblBuatPass;
        private TextBox txtKonfirPass;
        private Label lblKonfirPass;
        private Button btnKonfirmPUserPass;
        private Button btnMasukSkrg;
        private Label label1;
    }
}