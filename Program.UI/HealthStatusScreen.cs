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
    public partial class HealthStatusScreen : Form
    {
        AppUser user;
        public HealthStatusScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }

        private void HealthStatusScreen_Load(object sender, EventArgs e)
        {
            lblUserAge.Text = (DateTime.Now.Year - user.UserDetails.BirthDate.Year).ToString();
            lblUserGender.Text = user.UserDetails.Gender.ToString();
            lblUserHeight.Text = user.UserDetails.Height.ToString();
            lblUserWeight.Text = user.UserDetails.Weight.ToString();

            UsersMealsHistoryRepository usersMealsHistoryRepository = new UsersMealsHistoryRepository();
            MealRepository mealRepository = new MealRepository();
            foreach (var item in mealRepository.GetMealsNames(user.ID))
            {
                MealTotalCalorieControl mealTotalCalorieControl = new MealTotalCalorieControl();
                mealTotalCalorieControl.mealName = item;
                mealTotalCalorieControl.mealTotalCalorie = (usersMealsHistoryRepository.TodayTotalMealCalorie(user.ID, item)).ToString();
                flpUsersMealsCalories.Controls.Add(mealTotalCalorieControl);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbSedentary.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.2).ToString();
            if (rbLight.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.3).ToString();
            if (rbModerate.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.4).ToString();
            if (rbActive.Checked)
                lblCalorieNeed.Text = (CalculateBMR() * 1.5).ToString();

            double calorieNeed = double.Parse(lblCalorieNeed.Text);
            pbCalorieStatus.Maximum = (int)Math.Round(calorieNeed);
            double todayTotalCalorie = 0;
            foreach (var item in flpUsersMealsCalories.Controls)
            {
                if (item is MealTotalCalorieControl)
                {
                    todayTotalCalorie += int.Parse(((MealTotalCalorieControl)item).mealTotalCalorie);
                }
            }

            if (todayTotalCalorie > pbCalorieStatus.Maximum)
            {
                pbCalorieStatus.Value = pbCalorieStatus.Maximum;
                MessageBox.Show("You have reach to maximum calorie!");
            }
            else
            {
                pbCalorieStatus.Value = (int)Math.Round(todayTotalCalorie);
            }
        }
        public double CalculateBMR()
        {
            double bMR = 0;
            if (lblUserGender.Text == "Male")
            {
                bMR = 66.5 + (13.75 * user.UserDetails.Weight) + (5 * user.UserDetails.Height) - (6.77 * (DateTime.Now.Year - user.UserDetails.BirthDate.Year));
            }
            else
            {
                bMR = 655.1 + (9.56 * user.UserDetails.Weight) + (1.85 * user.UserDetails.Height) - (4.67 * (DateTime.Now.Year - user.UserDetails.BirthDate.Year));
            }
            return bMR;
        }
    }
}
