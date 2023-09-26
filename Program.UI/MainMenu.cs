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
using static System.Windows.Forms.DataFormats;

namespace Program.UI
{
    public partial class MainMenu : Form
    {
        #region Tasarim Kodlari
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
        AppUser user;
        LoginScreen loginScreen;
        public MainMenu(AppUser appUser, LoginScreen lgnScreen)
        {
            InitializeComponent();
            user = appUser;
            loginScreen = lgnScreen;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadHomeScreen();
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString();
        }
        public void LoadHomeScreen()
        {
            HomeScreen homeScreen = new HomeScreen(user);
            homeScreen.MdiParent = this;
            homeScreen.Dock = DockStyle.Fill;
            homeScreen.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            LoadHomeScreen();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoScreen userInfoScreen = new UserInfoScreen(user);
            userInfoScreen.MdiParent = this;
            userInfoScreen.Dock = DockStyle.Fill;
            userInfoScreen.Show();
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.Show();
        }

        private void btnHealthStatus_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            HealthStatusScreen healthStatusScreen = new HealthStatusScreen(user);
            healthStatusScreen.MdiParent = this;
            healthStatusScreen.Dock = DockStyle.Fill;
            healthStatusScreen.Show();
        }

        private void btnAddNutrition_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            AddNutritionScreen addNutritionScreen = new AddNutritionScreen(user);
            addNutritionScreen.MdiParent = this;
            addNutritionScreen.Dock = DockStyle.Fill;
            addNutritionScreen.Show();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            AddMealScreen addMealScreen = new AddMealScreen(user);
            addMealScreen.MdiParent = this;
            addMealScreen.Dock = DockStyle.Fill;
            addMealScreen.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            HistoryScreen historyScreen = new HistoryScreen(user);
            historyScreen.MdiParent = this;
            historyScreen.Dock = DockStyle.Fill;
            historyScreen.Show();
        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            AnalizeScreen analizeScreen = new AnalizeScreen(user);
            analizeScreen.MdiParent = this;
            analizeScreen.Dock = DockStyle.Fill;
            analizeScreen.Show();
        }
    }
}
