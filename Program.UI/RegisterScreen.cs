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
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }
        #region Design Codes
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
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
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        #endregion
        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtConfirmPassword.PasswordChar = '•';
            pbPhoto.Tag = "";

            txtEmail.Font = new Font("Century Gothic", 12);
            txtHeight.Font = new Font("Century Gothic", 12);
            txtWeight.Font = new Font("Century Gothic", 12);

            txtPassword.Font = new Font("Century Gothic", 12);
            txtConfirmPassword.Font = new Font("Century Gothic", 12);
            txtAnswer.Font = new Font("Century Gothic", 12);
            cmbSecurityQuestion.Font = new Font("Century Gothic", 8);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ControlNullOrNut();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            AppUserRepository appUserRepository = new AppUserRepository();

            if (true)
            {
                if (appUserRepository.RegisterControl(email))
                {
                    MessageBox.Show("There is a membership for this email address!");
                    return;
                }
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
                if(pbPhoto.Tag == "")
                {
                    MessageBox.Show("User Photo can not be empty!");
                    return;
                }

                string specialChar = "!:+*";
                int specialCharCount = password.Count(c => specialChar.Contains(c));

                if (specialCharCount < 2)
                {
                    MessageBox.Show("Password must contain at least 2 special characters!");
                    return;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please check!");
                    return;
                }
                
                AppUser newUser = new AppUser()
                {
                    Email = email,
                    Password = sha256_hash(txtPassword.Text),
                    SecurityQuestion = cmbSecurityQuestion.SelectedItem.ToString(),
                    Answer = txtAnswer.Text,
                    Picture = pbPhoto.Tag.ToString(),
                    UserDetails = new UserDetails()
                    {
                        BirthDate = dtpBirthDate.Value,
                        Height = float.Parse(txtHeight.Text),
                        Weight = float.Parse(txtWeight.Text),
                        Gender = (rbMale.Checked ? DATA.Enums.Gender.Male : DATA.Enums.Gender.Female),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text
                    }
                };
                appUserRepository.Add(newUser);
                MessageBox.Show("Registration succesfull!");
                this.Close();
            }
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
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

            if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                MessageBox.Show("Please choose gender.");
                return;
            }

            if (pbPhoto.Image == null)
            {
                MessageBox.Show("Photo uploading cannot be skipped.");
                return;
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

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = Color.Red;
                return;
            }
            else
            {
                txtConfirmPassword.BackColor = SystemColors.Window;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtConfirmPassword.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                return;
            }
            else
            {
                txtConfirmPassword.BackColor = SystemColors.Window;
                txtPassword.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.BackColor = Color.Red;
                return;
            }
            else
            {
                txtHeight.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.BackColor = Color.Red;
                return;
            }
            else
            {
                txtWeight.BackColor = SystemColors.Window;
            }

            try
            {
                int x = int.Parse(txtHeight.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            try
            {
                int x = int.Parse(txtWeight.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }
        private void linkAlreadyAcoount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void ptbPasswordInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• Your password must be at least 8 characters long.\n• It must contain at least 2 uppercase letters.\n• It must contain at least 3 lowercase letters.\n• It must contain at least 2 of the following characters: ! (exclamation), : (colon), + (plus), *(asterisk). (There may be more than one of the same character)", "Password information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "User Photo(png,jpg,gif)|*.png;*.jpg;*.gif";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(ofd.FileName);

                pbPhoto.Tag = ofd.FileName;
            }
        }
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
