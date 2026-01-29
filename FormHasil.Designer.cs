using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp5
{
    partial class FormHasil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHasil));
            label1 = new Label();
            label2 = new Label();
            lblScore = new Label();
            btnKembali = new Button();
            lblMotivasi = new Label();
            lblPercentage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 32);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 0;
            label1.Text = "Hasil Quiz Anda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(362, 97);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "Score Anda";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(387, 133);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(42, 21);
            lblScore.TabIndex = 2;
            lblScore.Text = "0 / 0";
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Indigo;
            btnKembali.Location = new Point(365, 332);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(92, 30);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += BtnKembali_Click;
            // 
            // lblMotivasi
            // 
            lblMotivasi.AutoSize = true;
            lblMotivasi.BackColor = Color.Transparent;
            lblMotivasi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMotivasi.ForeColor = Color.White;
            lblMotivasi.Location = new Point(166, 252);
            lblMotivasi.Name = "lblMotivasi";
            lblMotivasi.Size = new Size(456, 42);
            lblMotivasi.TabIndex = 4;
            lblMotivasi.Text = "Terima kasih sudah mencoba\nIstirahat sebentar, kamu sudah melakukan yang terbaik 🌸 ⭐";
            lblMotivasi.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.BackColor = Color.Transparent;
            lblPercentage.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.ForeColor = Color.White;
            lblPercentage.Location = new Point(366, 181);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(83, 37);
            lblPercentage.TabIndex = 5;
            lblPercentage.Text = " (0%)";
            // 
            // FormHasil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(836, 413);
            Controls.Add(lblPercentage);
            Controls.Add(lblMotivasi);
            Controls.Add(btnKembali);
            Controls.Add(lblScore);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHasil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasil Kuis";
            Load += FormHasil_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblMotivasi;
        private System.Windows.Forms.Label lblPercentage; // DEKLARASI BARU
    }
}