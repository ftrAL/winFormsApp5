using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;


namespace WinFormsApp5
{
    // --- 1. DEFINISI STRUKTUR SOAL ---
    // Struktur ini menyimpan data untuk setiap pertanyaan
    public struct QuizQuestion
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; } // Array 4 elemen (A, B, C, D)
        public int CorrectAnswerIndex { get; set; } // 0=A, 1=B, 2=C, 3=D
    }

    public partial class MatkulFisika : Form
    {
        List<int> daftarNilai = new List<int>();

        DateTime startTime, endTime;
        TimeSpan duration;
        // Variabel untuk menyimpan semua soal dan melacak posisi saat ini
        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0; // Skor awal

        public MatkulFisika()
        {
            InitializeComponent();
            startTime = DateTime.Now;

            // Pendaftaran Event Handler (di Designer.cs tidak ada, jadi didaftarkan manual)
            this.btnJawab.Click += new System.EventHandler(this.BtnJawab_Click);

            // --- 2. TEMPAT ANDA MENULIS SEMUA SOAL ---
            InitializeQuestions();

            // Memuat soal pertama saat form dibuka
            LoadQuestion();
        }

        // Metode untuk mendefinisikan dan menuliskan semua soal kuis
        private void InitializeQuestions()
        {
            questions = new List<QuizQuestion>
            {
                // SOAL 1 (Index 0)
                new QuizQuestion
                {
                    QuestionText = "Berapakah besar percepatan gravitasi rata-rata di permukaan bumi?",
                    Options = new string[] { "A. 9.8 m/s²", "B. 10 m/s²", "C. 6.67 m/s²", "D. 1.62 m/s²" },
                    CorrectAnswerIndex = 0 // Jawaban benar adalah A
                },
                
                // SOAL 2 (Index 1)
                new QuizQuestion
                {
                    QuestionText = "Satuan internasional (SI) untuk usaha (work) adalah?",
                    Options = new string[] { "A. Watt", "B. Newton", "C. Joule", "D. Pascal" },
                    CorrectAnswerIndex = 2 // Jawaban benar adalah C
                },
                
                // SOAL 3 (Index 2)
                new QuizQuestion
                {
                    QuestionText = "Hukum Newton yang menjelaskan tentang kelembaman atau inersia adalah Hukum Newton ke...",
                    Options = new string[] { "A. Satu", "B. Dua", "C. Tiga", "D. Nol" },
                    CorrectAnswerIndex = 0 // Jawaban benar adalah A
                },
                
                // Anda bisa tambahkan soal 4, 5, ... sampai 10 di sini
                // SOAL 4 (Index 3)
                new QuizQuestion
                {
                    QuestionText = "Apa rumus dasar untuk menghitung Daya (Power) dalam fisika?",
                    Options = new string[] { "A. P = W * t", "B. P = F * v", "C. P = W / t", "D. P = m * a" },
                    CorrectAnswerIndex = 2 // Jawaban benar adalah C
                },
                
                // SOAL 5 (Index 4)
                new QuizQuestion
                {
                    QuestionText = "Apa yang terjadi pada volume gas jika tekanannya ditingkatkan (suhu dijaga konstan)? (Berdasarkan Hukum Boyle)",
                    Options = new string[] { "A. Volume bertambah", "B. Volume berkurang", "C. Volume tetap", "D. Volume menjadi nol" },
                    CorrectAnswerIndex = 1 // Jawaban benar adalah B
                }
                // Tambahkan sisa soal Anda di sini!
            };
        }

        // Metode untuk menampilkan soal berdasarkan indeks saat ini
        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                QuizQuestion currentQuestion = questions[currentQuestionIndex];

                // Update Judul (Header)
                lblJudul.Text = $"Kuis Fisika - Soal {currentQuestionIndex + 1}/{questions.Count}";

                // Update Teks Soal
                lblSoal.Text = currentQuestion.QuestionText;

                // Update Pilihan Jawaban
                radioA.Text = currentQuestion.Options[0];
                radioB.Text = currentQuestion.Options[1];
                radioC.Text = currentQuestion.Options[2];
                radioD.Text = currentQuestion.Options[3];

                // Bersihkan pilihan yang telah dipilih
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;

                btnJawab.Text = "JAWAB";
                btnJawab.BackColor = Color.ForestGreen;
            }
            else
            {
                // Kuis Selesai
                ShowQuizResults();
            }
        }

        // Event Handler saat tombol JAWAB diklik
        private void BtnJawab_Click(object sender, EventArgs e)
        {
            // Cek apakah ada jawaban yang dipilih
            RadioButton checkedButton = this.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);

            if (checkedButton == null)
            {
                MessageBox.Show("Mohon pilih salah satu jawaban sebelum melanjutkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dapatkan index jawaban yang dipilih (0=A, 1=B, dst.)
            int selectedAnswerIndex = -1;
            if (checkedButton == radioA) selectedAnswerIndex = 0;
            else if (checkedButton == radioB) selectedAnswerIndex = 1;
            else if (checkedButton == radioC) selectedAnswerIndex = 2;
            else if (checkedButton == radioD) selectedAnswerIndex = 3;

            // Cek Jawaban
            if (selectedAnswerIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                score++;
              
            }
            else
            {
                
            }
           
            currentQuestionIndex++;

            LoadQuestion();
        }

        // Metode untuk menampilkan hasil kuis
        private void ShowQuizResults()
        {
            // 1. Simpan dulu nilainya
            daftarNilai.Add(this.score);

            // 2. Baru bikin text
            string hasil = "Riwayat Nilai:\n\n";

            foreach (int nilai in daftarNilai)
            {
                hasil += "- " + nilai + "\n";
            }

            // 3. Tampilkan
            MessageBox.Show(hasil, "Riwayat Nilai");

            endTime = DateTime.Now;
            duration = endTime - startTime;

            FileHelper.SaveResult(this.score, this.questions.Count);

            FormHasil hasilForm = new FormHasil(
                this.score,
                this.questions.Count,
                startTime,
                endTime,
                duration,
                daftarNilai
            );

            hasilForm.ShowDialog();
            this.Close();
        }




    }
}