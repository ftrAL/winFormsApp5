using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnKonfirmPUserPass_Click(object sender, EventArgs e)
        {
            if (txtBuatPassAnda.Text != txtKonfirPass.Text)
            {
                MessageBox.Show("Password dan konfirmasi tidak sama");
                return;
            }

            UserStore.Save(txtBuatUserName.Text, txtBuatPassAnda.Text);

            MessageBox.Show("Registrasi berhasil");
            this.Close();
        }

        private void btnMasukSkrg_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
