using Program.DAL.Mapping;
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
    public partial class PasswordRenewScreen : Form
    {
        public PasswordRenewScreen()
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
        private void PasswordRenewScreen_Load(object sender, EventArgs e)
        {
            txtAnswer.Font = new Font("Century Gothic", 12);
            txtEmail.Font = new Font("Century Gothic", 12);
            cmbSecurityQuestion.Font = new Font("Century Gothic", 8);
            txtNewPassword.Enabled = false;
            btnUpdatePassword.Enabled = false;
            txtNewPassword.Font = new Font("Century Gothic", 12);
            txtNewPassword.PasswordChar = '•';
        }

        private void btnCheckInfos_Click(object sender, EventArgs e)
        {
            ControlNullOrNot();
            string email = txtEmail.Text;
            string securityQuestion = cmbSecurityQuestion.Text;
            string answer = txtAnswer.Text;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                return;
            }
            else
            {
                txtEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                txtAnswer.BackColor = Color.Red;
                return;
            }
            else
            {
                txtAnswer.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(cmbSecurityQuestion.Text))
            {
                cmbSecurityQuestion.BackColor = Color.Red;
                return;
            }
            else
            {
                cmbSecurityQuestion.BackColor = SystemColors.Window;
            }

            AppUserRepository appUserRepository = new AppUserRepository();

            AppUser user = appUserRepository.CheckInfo(email, securityQuestion, answer);

            if (user != null)
            {
                btnUpdatePassword.Enabled = true;
                txtNewPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("User information is invalid");
            }
        }

        private void ControlNullOrNot()
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

            if (string.IsNullOrEmpty(cmbSecurityQuestion.Text))
            {
                cmbSecurityQuestion.BackColor = Color.Red;
                return;
            }
            else
            {
                cmbSecurityQuestion.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                txtAnswer.BackColor = Color.Red;
                return;
            }
            else
            {
                txtAnswer.BackColor = SystemColors.Window;
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string securityQuestion = cmbSecurityQuestion.Text;
            string answer = txtAnswer.Text;
            string password = txtNewPassword.Text;


            if (password.Length < 8)
            {
                MessageBox.Show("Password length must be at least 8 characters!");
                return;
            }
            if (password.Count(char.IsUpper) < 2)
            {
                MessageBox.Show("Password must contain at least 2 uppercase characters!");
                return;
            }
            if (password.Count(char.IsLower) < 3)
            {
                MessageBox.Show("Password must contain at least 3 lowercase characters!");
                return;
            }

            string specialChar = "!:+*";
            int specialCharCount = password.Count(c => specialChar.Contains(c));

            if (specialCharCount < 2)
            {
                MessageBox.Show("Password must contain at least 2 special characters!");
                return;
            }

            password = sha256_hash(txtNewPassword.Text);

            AppUserRepository appUserRepository = new AppUserRepository();

            AppUser user = appUserRepository.CheckInfo(email, securityQuestion, answer);
            AppUser selectedUser = appUserRepository.UserByUserId(user.ID);
            selectedUser.Password = password;
            appUserRepository.Update(selectedUser);
            MessageBox.Show("Password updated successfully");
            this.Close();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void ptbPasswordInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• Your password must be at least 8 characters long.\n• It must contain at least 2 uppercase letters.\n• It must contain at least 3 lowercase letters.\n• It must contain at least 2 of the following characters: ! (exclamation), : (colon), + (plus), *(asterisk). (There may be more than one of the same character)", "Password information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
