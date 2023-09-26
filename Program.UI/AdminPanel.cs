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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadUsersList();
        }
        AppUserRepository appUserRepository;
        public void LoadUsersList()
        {
            lvUsers.Items.Clear();
            appUserRepository = new AppUserRepository();
            List<AppUser> appUsers = appUserRepository.GetAppUsers();
            foreach (var item in appUsers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Email.ToString());
                lvi.SubItems.Add(item.Password.ToString());
                lvi.Tag = item;
                lvUsers.Items.Add(lvi);
            }
        }
        AppUser selectedUser;
        private void lvUsers_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 1)
            {
                selectedUser = (AppUser)lvUsers.SelectedItems[0].Tag;
                txtEmail.Text = selectedUser.Email;
                txtPassword.Text = selectedUser.Password;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            appUserRepository.Delete(selectedUser);
            MessageBox.Show("User is deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedUser.Email = txtEmail.Text;
            string password = sha256_hash(txtPassword.Text);
            selectedUser.Password = password;
            appUserRepository.Update(selectedUser);
            MessageBox.Show("User is updated!");
        }
        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
