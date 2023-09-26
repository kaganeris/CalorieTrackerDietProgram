using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class HistoryScreen : Form
    {
        AppUser user;
        public HistoryScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }
        List<DateTime> dates = new List<DateTime>();
        UsersMealsHistoryRepository histrep = new();
        private void HistoryScreen_Load(object sender, EventArgs e)
        {
            dates = histrep.GetAllDatesOfUser(user);
            string[] arr = new string[2];
            foreach (DateTime dt in dates)
            {
                arr[0] = dt.ToShortDateString();
                arr[1] = histrep.TotalCalorieOfDay(user, dt).ToString();
                ListViewItem lvi = new ListViewItem(arr);
                lvDays.Items.Add(lvi);
            }
        }

        DateTime SelectedDate = new();
        NutritionRepository nutrep = new NutritionRepository();
        CategoryRepository catrep = new CategoryRepository();

        private void lvDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            histrep = new UsersMealsHistoryRepository();
            if (lvDays.SelectedItems.Count > 0)
            {
                lvMeals.Items.Clear();
                SelectedDate = Convert.ToDateTime(lvDays.SelectedItems[0].Text);
                int counter = 0;
                foreach (Meal meal in histrep.GetAllMealsOfDay(SelectedDate.Date, user))
                {
                    string[] arr = { string.Empty, meal.MealName, string.Empty, string.Empty, string.Empty, histrep.GetMealCalorie(user, meal, SelectedDate).ToString(), string.Empty };
                    ListViewItem lvi = new ListViewItem(arr);
                    lvi.Font = new Font(Font, FontStyle.Bold);
                    lvMeals.Items.Add(lvi);
                    lvi.Tag = meal;
                    counter = 0;
                    foreach (UsersMealsHistory item in histrep.GetUserMealHistoryOfMeal(meal.ID, SelectedDate, user.ID))
                    {
                        Nutrition nutrition = new Nutrition();
                        nutrition = nutrep.GetNutritionByID(item.NutritionID);
                        counter++;
                        string[] arr2 = { counter.ToString(), nutrition.Name, catrep.GetCategoryById(nutrition.CategoryID).CategoryName, nutrition.Calorie.ToString(), item.NumberOfNutritions.ToString(), (nutrition.Calorie * item.NumberOfNutritions).ToString(), nutrition.Measurement + " " + nutrition.PortionType.ToString() };
                        ListViewItem lvi2 = new ListViewItem(arr2);
                        lvMeals.Items.Add(lvi2);
                        lvi2.Tag = item;
                    }
                }
            }
        }
        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            foreach (UsersMealsHistory item in histrep.GetUserMealHistoryOfMeal(SelectedMeal.ID, SelectedDate.Date, user.ID))
            {
                histrep.Delete(item);
                MessageBox.Show("Selected meal is deleted!");
            }
        }
        Meal SelectedMeal;
        private void lvMeals_Click(object sender, EventArgs e)
        {
            if (lvMeals.SelectedItems.Count > 0)
            {
                try
                {
                    SelectedMeal = (Meal)lvMeals.SelectedItems[0].Tag;
                }
                catch (Exception)
                {
                    SelectedMeal = null;
                    throw;
                }
            }
        }

        private void btnDeleteDay_Click(object sender, EventArgs e)
        {

        }
    }
}
