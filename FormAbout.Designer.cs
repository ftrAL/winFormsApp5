namespace WinFormsApp1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(372, 70);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(750, 72);
            label1.TabIndex = 0;
            label1.Text = "About Aplikasi E - Education";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 175);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(1244, 90);
            label2.TabIndex = 1;
            label2.Text = "Aplikasi ini dibuat sebagai media pembelajaran berbasis quiz. Aplikasi ini dibuat untuk\r\nmemenuhi tugas tengah semester mata kuliah Pemrograman Visual Kelas IF105\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(607, 336);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(235, 45);
            label3.TabIndex = 2;
            label3.Text = "Versi 1.0 (2025)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(491, 419);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(496, 270);
            label4.TabIndex = 3;
            label4.Text = "Dikembangkan Oleh Kelompok 7:\r\n1. Fathir Alghifari Ishaq\r\n2. Lulu Herliana Herawati\r\n3. Muhammad Rafly\r\n4. Miranda Dyah Salsabila\r\n5. Ardy Andriyansah";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.Location = new Point(653, 756);
            btnKembali.Margin = new Padding(6);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(147, 73);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(btnKembali);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnKembali;
    }
}
