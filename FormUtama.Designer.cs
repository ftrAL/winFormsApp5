namespace WinFormsApp5
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            panel1 = new Panel();
            btnKembaliDiFormPlhQuiz = new Button();
            lblIconSupport = new Label();
            lblHomeDiPemilihanQuiz = new Label();
            lblProfile = new Label();
            lblIconProfile = new Label();
            lblSupport = new Label();
            lblIconHome = new Label();
            btnLogout = new Button();
            btnAboutAppsUtama = new Button();
            btnStartQ2 = new Button();
            btnStartQ3 = new Button();
            btnStartQ1 = new Button();
            btnStartQ4 = new Button();
            btnStartQ5 = new Button();
            pctEnglish = new PictureBox();
            pctPemrogramanVisual = new PictureBox();
            pctSejarah = new PictureBox();
            pctBelumTauNanti = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pctFisika = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPemrogramanVisual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctSejarah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBelumTauNanti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFisika).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(btnKembaliDiFormPlhQuiz);
            panel1.Controls.Add(lblIconSupport);
            panel1.Controls.Add(lblHomeDiPemilihanQuiz);
            panel1.Controls.Add(lblProfile);
            panel1.Controls.Add(lblIconProfile);
            panel1.Controls.Add(lblSupport);
            panel1.Controls.Add(lblIconHome);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 112);
            panel1.TabIndex = 0;
            // 
            // btnKembaliDiFormPlhQuiz
            // 
            btnKembaliDiFormPlhQuiz.BackColor = Color.Transparent;
            btnKembaliDiFormPlhQuiz.FlatAppearance.BorderSize = 0;
            btnKembaliDiFormPlhQuiz.FlatStyle = FlatStyle.Flat;
            btnKembaliDiFormPlhQuiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembaliDiFormPlhQuiz.ForeColor = Color.White;
            btnKembaliDiFormPlhQuiz.Location = new Point(1339, 17);
            btnKembaliDiFormPlhQuiz.Name = "btnKembaliDiFormPlhQuiz";
            btnKembaliDiFormPlhQuiz.Size = new Size(150, 74);
            btnKembaliDiFormPlhQuiz.TabIndex = 23;
            btnKembaliDiFormPlhQuiz.Text = "Kembali";
            btnKembaliDiFormPlhQuiz.UseVisualStyleBackColor = false;
            btnKembaliDiFormPlhQuiz.Click += btnKembaliDiFormPlhQuiz_Click;
            // 
            // lblIconSupport
            // 
            lblIconSupport.AutoSize = true;
            lblIconSupport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconSupport.ForeColor = Color.White;
            lblIconSupport.Image = (Image)resources.GetObject("lblIconSupport.Image");
            lblIconSupport.Location = new Point(405, 38);
            lblIconSupport.Name = "lblIconSupport";
            lblIconSupport.Size = new Size(21, 32);
            lblIconSupport.TabIndex = 24;
            lblIconSupport.Text = ".";
            // 
            // lblHomeDiPemilihanQuiz
            // 
            lblHomeDiPemilihanQuiz.AutoSize = true;
            lblHomeDiPemilihanQuiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomeDiPemilihanQuiz.ForeColor = Color.White;
            lblHomeDiPemilihanQuiz.Location = new Point(262, 38);
            lblHomeDiPemilihanQuiz.Name = "lblHomeDiPemilihanQuiz";
            lblHomeDiPemilihanQuiz.Size = new Size(82, 32);
            lblHomeDiPemilihanQuiz.TabIndex = 23;
            lblHomeDiPemilihanQuiz.Text = "Home";
            lblHomeDiPemilihanQuiz.Click += lblHomeDiPemilihanQuiz_Click;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.ForeColor = Color.White;
            lblProfile.Location = new Point(72, 38);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(90, 32);
            lblProfile.TabIndex = 23;
            lblProfile.Text = "Profile";
            lblProfile.Click += lblProfile_Click;
            // 
            // lblIconProfile
            // 
            lblIconProfile.AutoSize = true;
            lblIconProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconProfile.ForeColor = Color.White;
            lblIconProfile.Image = (Image)resources.GetObject("lblIconProfile.Image");
            lblIconProfile.Location = new Point(45, 38);
            lblIconProfile.Name = "lblIconProfile";
            lblIconProfile.Size = new Size(21, 32);
            lblIconProfile.TabIndex = 2;
            lblIconProfile.Text = ".";
            // 
            // lblSupport
            // 
            lblSupport.AutoSize = true;
            lblSupport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupport.ForeColor = Color.White;
            lblSupport.Location = new Point(434, 38);
            lblSupport.Name = "lblSupport";
            lblSupport.Size = new Size(107, 32);
            lblSupport.TabIndex = 1;
            lblSupport.Text = "Support";
            lblSupport.Click += lblSupport_Click;
            // 
            // lblIconHome
            // 
            lblIconHome.AutoSize = true;
            lblIconHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconHome.ForeColor = Color.White;
            lblIconHome.Image = (Image)resources.GetObject("lblIconHome.Image");
            lblIconHome.Location = new Point(229, 38);
            lblIconHome.Name = "lblIconHome";
            lblIconHome.Size = new Size(21, 32);
            lblIconHome.TabIndex = 0;
            lblIconHome.Text = ".";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Indigo;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1339, 772);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 74);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAboutAppsUtama
            // 
            btnAboutAppsUtama.BackColor = Color.Indigo;
            btnAboutAppsUtama.FlatAppearance.BorderSize = 0;
            btnAboutAppsUtama.FlatStyle = FlatStyle.Flat;
            btnAboutAppsUtama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAboutAppsUtama.ForeColor = Color.White;
            btnAboutAppsUtama.Location = new Point(68, 772);
            btnAboutAppsUtama.Name = "btnAboutAppsUtama";
            btnAboutAppsUtama.Size = new Size(150, 93);
            btnAboutAppsUtama.TabIndex = 2;
            btnAboutAppsUtama.Text = "About Apps";
            btnAboutAppsUtama.UseVisualStyleBackColor = false;
            btnAboutAppsUtama.Click += btnAboutAppsUtama_Click;
            // 
            // btnStartQ2
            // 
            btnStartQ2.BackColor = Color.Indigo;
            btnStartQ2.FlatAppearance.BorderSize = 0;
            btnStartQ2.FlatStyle = FlatStyle.Flat;
            btnStartQ2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQ2.ForeColor = Color.White;
            btnStartQ2.Location = new Point(393, 628);
            btnStartQ2.Name = "btnStartQ2";
            btnStartQ2.Size = new Size(345, 74);
            btnStartQ2.TabIndex = 3;
            btnStartQ2.Text = "START QUIZ";
            btnStartQ2.UseVisualStyleBackColor = false;
            btnStartQ2.Click += btnStartQ2_Click;
            // 
            // btnStartQ3
            // 
            btnStartQ3.BackColor = Color.Indigo;
            btnStartQ3.FlatAppearance.BorderSize = 0;
            btnStartQ3.FlatStyle = FlatStyle.Flat;
            btnStartQ3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQ3.ForeColor = Color.White;
            btnStartQ3.Location = new Point(767, 628);
            btnStartQ3.Name = "btnStartQ3";
            btnStartQ3.Size = new Size(345, 74);
            btnStartQ3.TabIndex = 5;
            btnStartQ3.Text = "START QUIZ";
            btnStartQ3.UseVisualStyleBackColor = false;
            btnStartQ3.Click += btnStartQ3_Click;
            // 
            // btnStartQ1
            // 
            btnStartQ1.BackColor = Color.Indigo;
            btnStartQ1.FlatAppearance.BorderSize = 0;
            btnStartQ1.FlatStyle = FlatStyle.Flat;
            btnStartQ1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQ1.ForeColor = Color.White;
            btnStartQ1.Location = new Point(19, 628);
            btnStartQ1.Name = "btnStartQ1";
            btnStartQ1.Size = new Size(345, 74);
            btnStartQ1.TabIndex = 7;
            btnStartQ1.Text = "START QUIZ";
            btnStartQ1.UseVisualStyleBackColor = false;
            btnStartQ1.Click += btnStartQ1_Click;
            // 
            // btnStartQ4
            // 
            btnStartQ4.BackColor = Color.Indigo;
            btnStartQ4.FlatAppearance.BorderSize = 0;
            btnStartQ4.FlatStyle = FlatStyle.Flat;
            btnStartQ4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQ4.ForeColor = Color.White;
            btnStartQ4.Location = new Point(1138, 628);
            btnStartQ4.Name = "btnStartQ4";
            btnStartQ4.Size = new Size(345, 74);
            btnStartQ4.TabIndex = 9;
            btnStartQ4.Text = "START QUIZ";
            btnStartQ4.UseVisualStyleBackColor = false;
            btnStartQ4.Click += btnStartQ4_Click;
            // 
            // btnStartQ5
            // 
            btnStartQ5.BackColor = Color.Indigo;
            btnStartQ5.FlatAppearance.BorderSize = 0;
            btnStartQ5.FlatStyle = FlatStyle.Flat;
            btnStartQ5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQ5.ForeColor = Color.White;
            btnStartQ5.Location = new Point(1506, 628);
            btnStartQ5.Name = "btnStartQ5";
            btnStartQ5.Size = new Size(345, 74);
            btnStartQ5.TabIndex = 11;
            btnStartQ5.Text = "START QUIZ";
            btnStartQ5.UseVisualStyleBackColor = false;
            btnStartQ5.Click += btnStartQ5_Click;
            // 
            // pctEnglish
            // 
            pctEnglish.Image = (Image)resources.GetObject("pctEnglish.Image");
            pctEnglish.Location = new Point(393, 208);
            pctEnglish.Name = "pctEnglish";
            pctEnglish.Size = new Size(345, 429);
            pctEnglish.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEnglish.TabIndex = 13;
            pctEnglish.TabStop = false;
            // 
            // pctPemrogramanVisual
            // 
            pctPemrogramanVisual.Image = (Image)resources.GetObject("pctPemrogramanVisual.Image");
            pctPemrogramanVisual.Location = new Point(767, 208);
            pctPemrogramanVisual.Name = "pctPemrogramanVisual";
            pctPemrogramanVisual.Size = new Size(345, 429);
            pctPemrogramanVisual.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPemrogramanVisual.TabIndex = 15;
            pctPemrogramanVisual.TabStop = false;
            // 
            // pctSejarah
            // 
            pctSejarah.Image = (Image)resources.GetObject("pctSejarah.Image");
            pctSejarah.Location = new Point(1138, 208);
            pctSejarah.Name = "pctSejarah";
            pctSejarah.Size = new Size(345, 429);
            pctSejarah.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSejarah.TabIndex = 16;
            pctSejarah.TabStop = false;
            // 
            // pctBelumTauNanti
            // 
            pctBelumTauNanti.Image = (Image)resources.GetObject("pctBelumTauNanti.Image");
            pctBelumTauNanti.Location = new Point(1505, 208);
            pctBelumTauNanti.Name = "pctBelumTauNanti";
            pctBelumTauNanti.Size = new Size(345, 429);
            pctBelumTauNanti.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBelumTauNanti.TabIndex = 17;
            pctBelumTauNanti.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(476, 232);
            label3.Name = "label3";
            label3.Size = new Size(184, 44);
            label3.TabIndex = 18;
            label3.Text = "ENGLISH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(771, 244);
            label4.Name = "label4";
            label4.Size = new Size(340, 32);
            label4.TabIndex = 19;
            label4.Text = "PEMROGRAMAN VISUAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(1215, 232);
            label5.Name = "label5";
            label5.Size = new Size(198, 44);
            label5.TabIndex = 20;
            label5.Text = "SEJARAH";
            // 
            // pctFisika
            // 
            pctFisika.Image = (Image)resources.GetObject("pctFisika.Image");
            pctFisika.Location = new Point(19, 208);
            pctFisika.Name = "pctFisika";
            pctFisika.Size = new Size(345, 429);
            pctFisika.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFisika.TabIndex = 21;
            pctFisika.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(124, 232);
            label2.Name = "label2";
            label2.Size = new Size(139, 44);
            label2.TabIndex = 22;
            label2.Text = "FISIKA";
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(label2);
            Controls.Add(pctFisika);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pctBelumTauNanti);
            Controls.Add(pctSejarah);
            Controls.Add(pctPemrogramanVisual);
            Controls.Add(pctEnglish);
            Controls.Add(btnStartQ5);
            Controls.Add(btnStartQ4);
            Controls.Add(btnStartQ1);
            Controls.Add(btnStartQ3);
            Controls.Add(btnStartQ2);
            Controls.Add(btnAboutAppsUtama);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Name = "FormUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUtama";
            Load += FormUtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPemrogramanVisual).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSejarah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBelumTauNanti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFisika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblIconHome;
        private Button btnLogout;
        private Button btnAboutAppsUtama;
        private Button btnStartQ2;
        private Button btnStartQ3;
        private Button btnStartQ1;
        private Button btnStartQ4;
        private Button btnStartQ5;
        private Label lblSupport;
        private PictureBox pctEnglish;
        private PictureBox pctPemrogramanVisual;
        private PictureBox pctSejarah;
        private PictureBox pctBelumTauNanti;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pctFisika;
        private Label label2;
        private Label lblProfile;
        private Label lblIconProfile;
        private Label lblHomeDiPemilihanQuiz;
        private Label lblIconSupport;
        private Button btnKembaliDiFormPlhQuiz;
    }
}