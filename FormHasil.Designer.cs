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
            lblStart = new Label();
            lblEnd = new Label();
            lblDuration = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblFileTime = new Label();
            btnGrafik = new Button();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(563, 25);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 71);
            label1.TabIndex = 0;
            label1.Text = "Hasil Quiz Anda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(673, 207);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 45);
            label2.TabIndex = 1;
            label2.Text = "Score Anda";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(719, 283);
            lblScore.Margin = new Padding(6, 0, 6, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(84, 45);
            lblScore.TabIndex = 2;
            lblScore.Text = "0 / 0";
            // 
            // btnKembali
            // 
            btnKembali.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Indigo;
            btnKembali.Location = new Point(678, 709);
            btnKembali.Margin = new Padding(6);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(171, 64);
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
            lblMotivasi.Location = new Point(308, 537);
            lblMotivasi.Margin = new Padding(6, 0, 6, 0);
            lblMotivasi.Name = "lblMotivasi";
            lblMotivasi.Size = new Size(917, 90);
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
            lblPercentage.Location = new Point(679, 386);
            lblPercentage.Margin = new Padding(6, 0, 6, 0);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(161, 71);
            lblPercentage.TabIndex = 5;
            lblPercentage.Text = " (0%)";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.Indigo;
            lblStart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStart.ForeColor = Color.White;
            lblStart.Location = new Point(167, 52);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(110, 37);
            lblStart.TabIndex = 6;
            lblStart.Text = "label3";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.BackColor = Color.Indigo;
            lblEnd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnd.ForeColor = Color.White;
            lblEnd.Location = new Point(167, 124);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(110, 37);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "label4";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.BackColor = Color.Indigo;
            lblDuration.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuration.ForeColor = Color.White;
            lblDuration.Location = new Point(1254, 106);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(110, 37);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1161, 52);
            label3.Name = "label3";
            label3.Size = new Size(298, 37);
            label3.TabIndex = 9;
            label3.Text = "Durasi pengerjaan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 52);
            label4.Name = "label4";
            label4.Size = new Size(91, 37);
            label4.TabIndex = 10;
            label4.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 124);
            label5.Name = "label5";
            label5.Size = new Size(76, 37);
            label5.TabIndex = 11;
            label5.Text = "End";
            label5.Click += label5_Click;
            // 
            // lblFileTime
            // 
            lblFileTime.AutoSize = true;
            lblFileTime.BackColor = Color.Transparent;
            lblFileTime.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFileTime.ForeColor = Color.White;
            lblFileTime.Location = new Point(27, 806);
            lblFileTime.Name = "lblFileTime";
            lblFileTime.Size = new Size(219, 28);
            lblFileTime.TabIndex = 12;
            lblFileTime.Text = "Terakhir Disimpan :";
            // 
            // btnGrafik
            // 
            btnGrafik.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrafik.Location = new Point(1309, 751);
            btnGrafik.Name = "btnGrafik";
            btnGrafik.Size = new Size(150, 46);
            btnGrafik.TabIndex = 18;
            btnGrafik.Text = "Lihat grafik";
            btnGrafik.UseVisualStyleBackColor = true;
            btnGrafik.Click += btnGrafik_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1309, 675);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 46);
            btnPrint.TabIndex = 19;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // FormHasil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(btnPrint);
            Controls.Add(btnGrafik);
            Controls.Add(lblFileTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDuration);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(lblPercentage);
            Controls.Add(lblMotivasi);
            Controls.Add(btnKembali);
            Controls.Add(lblScore);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHasil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasil Kuis";
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
        private Label lblStart;
        private Label lblEnd;
        private Label lblDuration;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblFileTime;
        private Button btnGrafik;
        private Button btnPrint;
    }
}