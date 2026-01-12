using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnKuliah_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
        }

        private void btnSma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }

        private void btnSmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terkunci! Masih dalam pengembangan.");
        }
    }
}
