using System;
using System.Drawing;
using System.Linq; // Diperlukan jika Anda menggunakan query Linq
using System.Windows.Forms;
using WinFormsApp5;
using System.Drawing.Printing;


namespace WinFormsApp5
{
    public partial class FormHasil : Form
    {
        List<int> daftarNilai;

        PrintDocument printDoc = new PrintDocument();

        private int finalScore;

        // Constructor dasar
        public FormHasil()
        {
            InitializeComponent();
            this.Text = "Hasil Kuis";
        }



        public FormHasil(int score, int totalQuestions, DateTime start, DateTime end, TimeSpan duration, List<int> daftarNilai)
        {
            InitializeComponent();

            printDoc.PrintPage += PrintDoc_PrintPage;
            this.daftarNilai = daftarNilai;
            this.finalScore = score;


            DateTime last = FileHelper.GetLastEditTime();

            if (last != DateTime.MinValue)
            {
                lblFileTime.Text = "Terakhir disimpan: " +
                    last.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                lblFileTime.Text = "File belum ada";
            }

            this.Text = "Hasil Kuis Mata Kuliah";


            double ratio = (double)score / totalQuestions;
            int percentage = (int)Math.Round(ratio * 100);


            lblScore.Text = $"{score} / {totalQuestions}";
            lblPercentage.Text = $"{percentage}%";


            lblStart.Text = start.ToString("HH:mm:ss");
            lblEnd.Text = end.ToString("HH:mm:ss");
            lblDuration.Text = duration.ToString(@"mm\:ss");


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

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text =
                "Hasil Kuis\n" +
                "Skor: " + finalScore + "\n" +
                "Tanggal: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            Font font = new Font("Arial", 14);

            // Hitung ukuran teks (Calculate Text)
            SizeF size = e.Graphics.MeasureString(text, font);

            // Posisi tengah
            float x = (e.PageBounds.Width - size.Width) / 2;
            float y = 100;

            // Alignment
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            // Cetak
            e.Graphics.DrawString(
                text,
                font,
                Brushes.Black,
                new RectangleF(0, y, e.PageBounds.Width, size.Height),
                format
            );
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        { 

            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FormGrafik fg = new FormGrafik(daftarNilai);
            fg.Show();

        }




        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

    }
}