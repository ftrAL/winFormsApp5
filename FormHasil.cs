using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq; // Diperlukan jika Anda menggunakan query Linq

namespace WinFormsApp5
{
    public partial class FormHasil : Form
    {
        // Constructor dasar
        public FormHasil()
        {
            InitializeComponent();
            this.Text = "Hasil Kuis";
        }

        // Constructor yang menerima skor (Benar) dan Total Soal
        public FormHasil(int score, int totalQuestions)
        {
            InitializeComponent();
            this.Text = "Hasil Kuis Mata Kuliah";

            // 1. Hitung Persentase
            double ratio = (double)score / totalQuestions;
            int percentage = (int)Math.Round(ratio * 100);

            // 2. Tampilkan Skor Fraksi (X/Y)
            lblScore.Text = $"{score} / {totalQuestions}";

            // 3. Tampilkan Skor Persentase
            lblPercentage.Text = $"= {percentage}%";

            // Opsional: Logika Motivasi
            if (ratio > 0.8)
            {
                lblMotivasi.Text = "Selamat! Nilai Anda sangat memuaskan! 🎉";
                lblMotivasi.ForeColor = Color.White;
            }
            else if (ratio > 0.5)
            {
                lblMotivasi.Text = "Hasil yang bagus! Sedikit lagi menuju sempurna. ✨";
                lblMotivasi.ForeColor = Color.White;
            }
            else
            {
                lblMotivasi.Text = "Terus semangat! Latihan lagi dan pasti bisa lebih baik. 💪";
                lblMotivasi.ForeColor = Color.White;
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            // Menutup form hasil dan kembali ke FormUtama (Menu Kuis)
            this.Close();
        }

        
    }
}