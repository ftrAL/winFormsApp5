namespace WinFormsApp5
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            btnSmp = new Button();
            btnSma = new Button();
            btnKuliah = new Button();
            lblJenjangPendidika = new Label();
            pctEnglish = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSmp
            // 
            btnSmp.BackColor = Color.Indigo;
            btnSmp.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSmp.ForeColor = Color.White;
            btnSmp.Location = new Point(104, 598);
            btnSmp.Name = "btnSmp";
            btnSmp.Size = new Size(317, 89);
            btnSmp.TabIndex = 1;
            btnSmp.Text = "SMP";
            btnSmp.UseVisualStyleBackColor = false;
            btnSmp.Click += btnSmp_Click;
            // 
            // btnSma
            // 
            btnSma.BackColor = Color.Indigo;
            btnSma.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSma.ForeColor = Color.White;
            btnSma.ImageAlign = ContentAlignment.TopCenter;
            btnSma.Location = new Point(609, 598);
            btnSma.Name = "btnSma";
            btnSma.Size = new Size(318, 89);
            btnSma.TabIndex = 2;
            btnSma.Text = "SMA";
            btnSma.UseVisualStyleBackColor = false;
            btnSma.Click += btnSma_Click;
            // 
            // btnKuliah
            // 
            btnKuliah.BackColor = Color.Indigo;
            btnKuliah.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKuliah.ForeColor = Color.White;
            btnKuliah.Location = new Point(1088, 598);
            btnKuliah.Name = "btnKuliah";
            btnKuliah.Size = new Size(319, 89);
            btnKuliah.TabIndex = 3;
            btnKuliah.Text = "KULIAH";
            btnKuliah.UseVisualStyleBackColor = false;
            btnKuliah.Click += btnKuliah_Click;
            // 
            // lblJenjangPendidika
            // 
            lblJenjangPendidika.AutoSize = true;
            lblJenjangPendidika.BackColor = Color.Indigo;
            lblJenjangPendidika.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenjangPendidika.ForeColor = Color.White;
            lblJenjangPendidika.Location = new Point(349, 101);
            lblJenjangPendidika.Name = "lblJenjangPendidika";
            lblJenjangPendidika.Size = new Size(843, 56);
            lblJenjangPendidika.TabIndex = 4;
            lblJenjangPendidika.Text = "PILIH JENJANG PENDIDIKAN ANDA";
            // 
            // pctEnglish
            // 
            pctEnglish.Image = (Image)resources.GetObject("pctEnglish.Image");
            pctEnglish.Location = new Point(104, 217);
            pctEnglish.Name = "pctEnglish";
            pctEnglish.Size = new Size(314, 380);
            pctEnglish.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEnglish.TabIndex = 14;
            pctEnglish.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(609, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1088, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 380);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pctEnglish);
            Controls.Add(lblJenjangPendidika);
            Controls.Add(btnKuliah);
            Controls.Add(btnSma);
            Controls.Add(btnSmp);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)pctEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSmp;
        private Button btnSma;
        private Button btnKuliah;
        private Label lblJenjangPendidika;
        private PictureBox pctEnglish;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}