using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp5
{
    

    public partial class FormUtama : Form
    {
        List<int> daftarNilai = new List<int>();

        public FormUtama()
        {
            InitializeComponent();
        }



        private void btnStartQ2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void btnStartQ3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void btnStartQ4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void btnStartQ5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda telah keluar dari aplikasi.");
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnAboutAppsUtama_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void btnKembaliDiFormPlhQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartQ1_Click(object sender, EventArgs e)
        {
            MatkulFisika matkulFisika = new MatkulFisika();
            matkulFisika.Show();

        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void lblHomeDiPemilihanQuiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void lblSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
        }
    }
}




