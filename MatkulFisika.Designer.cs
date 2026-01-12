using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp5
{
    partial class MatkulFisika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatkulFisika));
            panelHeader = new Panel();
            lblJudul = new Label();
            lblSoal = new Label();
            radioA = new RadioButton();
            radioB = new RadioButton();
            radioC = new RadioButton();
            radioD = new RadioButton();
            btnJawab = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Indigo;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(6, 7, 6, 7);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1583, 123);
            panelHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(26, 30);
            lblJudul.Margin = new Padding(6, 0, 6, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(411, 51);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Kuis Fisika - Soal 1/10";
            // 
            // lblSoal
            // 
            lblSoal.BackColor = Color.Transparent;
            lblSoal.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoal.ForeColor = Color.White;
            lblSoal.Location = new Point(56, 172);
            lblSoal.Margin = new Padding(6, 0, 6, 0);
            lblSoal.Name = "lblSoal";
            lblSoal.Size = new Size(1422, 222);
            lblSoal.TabIndex = 1;
            lblSoal.Text = "Teks Pertanyaan akan muncul di sini. Misalnya: Berapakah besar percepatan gravitasi di permukaan bumi?";
            // 
            // radioA
            // 
            radioA.AutoSize = true;
            radioA.BackColor = Color.Transparent;
            radioA.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioA.ForeColor = Color.White;
            radioA.Location = new Point(65, 384);
            radioA.Margin = new Padding(6, 7, 6, 7);
            radioA.Name = "radioA";
            radioA.Size = new Size(377, 48);
            radioA.TabIndex = 2;
            radioA.TabStop = true;
            radioA.Text = "Pilihan Jawaban A";
            radioA.UseVisualStyleBackColor = false;
            // 
            // radioB
            // 
            radioB.AutoSize = true;
            radioB.BackColor = Color.Transparent;
            radioB.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioB.ForeColor = Color.White;
            radioB.Location = new Point(65, 458);
            radioB.Margin = new Padding(6, 7, 6, 7);
            radioB.Name = "radioB";
            radioB.Size = new Size(378, 48);
            radioB.TabIndex = 3;
            radioB.TabStop = true;
            radioB.Text = "Pilihan Jawaban B";
            radioB.UseVisualStyleBackColor = false;
            // 
            // radioC
            // 
            radioC.AutoSize = true;
            radioC.BackColor = Color.Transparent;
            radioC.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioC.ForeColor = Color.White;
            radioC.Location = new Point(65, 532);
            radioC.Margin = new Padding(6, 7, 6, 7);
            radioC.Name = "radioC";
            radioC.Size = new Size(378, 48);
            radioC.TabIndex = 4;
            radioC.TabStop = true;
            radioC.Text = "Pilihan Jawaban C";
            radioC.UseVisualStyleBackColor = false;
            // 
            // radioD
            // 
            radioD.AutoSize = true;
            radioD.BackColor = Color.Transparent;
            radioD.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioD.ForeColor = Color.White;
            radioD.Location = new Point(65, 606);
            radioD.Margin = new Padding(6, 7, 6, 7);
            radioD.Name = "radioD";
            radioD.Size = new Size(378, 48);
            radioD.TabIndex = 5;
            radioD.TabStop = true;
            radioD.Text = "Pilihan Jawaban D";
            radioD.UseVisualStyleBackColor = false;
            // 
            // btnJawab
            // 
            btnJawab.BackColor = Color.ForestGreen;
            btnJawab.FlatAppearance.BorderSize = 0;
            btnJawab.FlatStyle = FlatStyle.Flat;
            btnJawab.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJawab.ForeColor = Color.White;
            btnJawab.Location = new Point(1148, 706);
            btnJawab.Margin = new Padding(6, 7, 6, 7);
            btnJawab.Name = "btnJawab";
            btnJawab.Size = new Size(282, 107);
            btnJawab.TabIndex = 6;
            btnJawab.Text = "JAWAB";
            btnJawab.UseVisualStyleBackColor = false;
            // 
            // MatkulFisika
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1552, 890);
            Controls.Add(btnJawab);
            Controls.Add(radioD);
            Controls.Add(radioC);
            Controls.Add(radioB);
            Controls.Add(radioA);
            Controls.Add(lblSoal);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MatkulFisika";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kuis Fisika";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSoal;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Button btnJawab;
    }
}