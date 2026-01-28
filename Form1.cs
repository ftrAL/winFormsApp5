using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string savedUser, savedPass;

            
            if (!UserStore.Load(out savedUser, out savedPass))
            {
                MessageBox.Show("Belum ada akun terdaftar");
                return;
            }

            // String & String Methods
            savedUser = savedUser.Trim().ToUpper();
            savedPass = savedPass.Trim();

            string inputUser = tbUsername.Text.Trim().ToUpper();
            string inputPass = tbPassword.Text.Trim();

            int panjangUsername = inputUser.Length;
            if (inputUser == savedUser && inputPass == savedPass)
            {
                MessageBox.Show(
                    "Login berhasil!\n" +
                    "Username: " + inputUser +
                    "\nPanjang username: " + panjangUsername
                    );

                FormHome formHome = new FormHome();
                formHome.Show();
                this.Hide();   
            }
            else
            {
                MessageBox.Show("Username / password salah");
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterBuat_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
