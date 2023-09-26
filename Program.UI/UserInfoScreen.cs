using Castle.Core.Internal;
using Program.DAL.Mapping;
using Program.DAL.Repositories;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI
{
    public partial class UserInfoScreen : Form
    {
        AppUser user;
        public UserInfoScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }

        private void UserInfoScreen_Load(object sender, EventArgs e)
        {
            LoadScreen();
            if(user.UserType == DATA.Enums.UserType.User)
            {
                btnAdminPanel.Visible = false;
            }
            else
            {
                btnAdminPanel.Visible = true;
            }
        }

        private void btnUpdateHeightWeight_Click(object sender, EventArgs e)
        {
            if (txtUpdateHeight.Text.IsNullOrEmpty() || txtUpdateWeight.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Height or Weight can not be empty!");
                return;
            }
            else
            {
                AppUser updatedUser = user;
                updatedUser.UserDetails.Height = float.Parse(txtUpdateHeight.Text);
                updatedUser.UserDetails.Weight = float.Parse(txtUpdateWeight.Text);
                new AppUserRepository().Update(updatedUser);
                MessageBox.Show("Height and Weight succesfuly updated!");
                txtUpdateHeight.Text = "";
                txtUpdateWeight.Text = "";
                LoadScreen();
            }
            string deneme = Application.StartupPath + "\\FoodPhotos\\1.jpg";
        }

        public void LoadScreen()
        {
            pbPicture.Image = Image.FromFile(user.Picture);
            lblFirstName.Text = user.UserDetails.FirstName;
            lblLastName.Text = user.UserDetails.LastName;
            lblBirthDate.Text = user.UserDetails.BirthDate.ToShortDateString();
            lblGender.Text = user.UserDetails.Gender.ToString();
            lblHeight.Text = user.UserDetails.Height.ToString();
            lblWeight.Text = user.UserDetails.Weight.ToString();
            lblUserType.Text = user.UserType.ToString();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }
    }
}
