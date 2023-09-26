using Program.DAL.Repositories;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        #region Tasarim Kodlari
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        #endregion

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtPassword.Font = new Font("Century Gothic", 12);
            txtEmail.Font = new Font("Century Gothic", 12);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControlNullOrNut();

            string password = sha256_hash(txtPassword.Text);
            string email = txtEmail.Text;
            AppUserRepository userRepository = new AppUserRepository();
            AppUser user = userRepository.Control(email, password);

            if (user != null)
            {
                MainMenu mainMenu = new MainMenu(user,this);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect. Please try again!");
            }
        }
        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void ControlNullOrNut()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                return;
            }
            else
            {
                txtEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Red;
                return;
            }
            else
            {
                txtPassword.BackColor = SystemColors.Window;
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRenewScreen passwordRenewScreen = new PasswordRenewScreen();
            passwordRenewScreen.ShowDialog();
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.ShowDialog();
        }
    }
}
