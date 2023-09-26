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
    public partial class AnalizeScreen : Form
    {
        AppUser user;
        public AnalizeScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }
        UsersMealsHistoryRepository histrep;
        private void AnalizeScreen_Load(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
            LoadWhatDidIEat();
        }
        public void LoadCompareYourself()
        {
            lvConsumption.Items.Clear();
            int CompareDay = 7;
            if (rbMonthlyCompare.Checked == true) CompareDay = 30;
            histrep = new UsersMealsHistoryRepository();
            foreach (Category category in histrep.GetAllCategories())
            {
                string[] arr = { category.CategoryName, histrep.TotalConsumptionOfCategory(category.CategoryID, CompareDay).ToString(), histrep.ConsumptionOfCategoryByUser(user, category, CompareDay).ToString(), histrep.TotalCalorieOfCategory(category.CategoryID, CompareDay).ToString(), histrep.TotalCalorieOfCategoryByUser(category.CategoryID, user, CompareDay).ToString() };
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Tag = category;
                lvConsumption.Items.Add(lvi);
            }
        }
        public void LoadCompareMeals()
        {
            lvCompareByMeal.Items.Clear();
            int CompareDay = 7;
            if (rbMonthlyCompare.Checked == true) CompareDay = 30;
            histrep = new UsersMealsHistoryRepository();
            foreach (Meal meal in histrep.GetAllMeals(user))
            {
                string[] arr = new string[5];
                arr[0] = meal.MealName;
                arr[1] = histrep.GetMealConsumptionsOfAllUsers(meal, CompareDay);
                arr[2] = histrep.GetMealConsumptionsOfAllUsers(meal, user, CompareDay);
                arr[3] = histrep.GetMealCaloriesOfAllUsers(meal, CompareDay);
                arr[4] = histrep.GetMealCaloriesOfAllUsers(meal, user, CompareDay);
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Tag = meal;
                lvCompareByMeal.Items.Add(lvi);

            }
        }
        NutritionRepository nutrep;
        public void LoadWhatDidIEat()
        {
            lvWhatDidIEat.Items.Clear();
            histrep = new UsersMealsHistoryRepository();
            int counter = 0;
            foreach (Meal meal in histrep.GetAllMeals(user))
            {
                string[] arr = new string[4];
                arr[0] = string.Empty;
                arr[1] = meal.MealName;
                arr[2] = histrep.GetCountOfUsersSpecificMeal(meal, user).ToString();
                arr[3] = histrep.GetTotalCalorieOfSpecificMealOfUser(meal, user);
                ListViewItem lvi = new ListViewItem(arr);
                lvi.Font = new Font(Font, FontStyle.Bold);
                lvWhatDidIEat.Items.Add(lvi);
                lvi.Tag = meal;
                counter = 0;
                foreach (UsersMealsHistory item in histrep.GetUserMealHistoryOfMeal(meal.ID))
                {
                    Nutrition nutrition = new Nutrition();
                    nutrep = new NutritionRepository();
                    nutrition = nutrep.GetNutritionByID(item.NutritionID);
                    counter++;
                    string[] arr2 = new string[4];
                    arr2[0] = counter.ToString();
                    arr2[1] = nutrition.Name;
                    arr2[2] = item.NumberOfNutritions.ToString();
                    arr2[3] = (nutrition.Calorie * item.NumberOfNutritions).ToString();
                    ListViewItem lvi2 = new ListViewItem(arr2);
                    lvWhatDidIEat.Items.Add(lvi2);
                    lvi2.Tag = item;
                }
            }
        }

        private void rbMonthlyCompare_CheckedChanged(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
        }

        private void rbWeeklyCompare_CheckedChanged(object sender, EventArgs e)
        {
            LoadCompareYourself();
            LoadCompareMeals();
        }
    }
}
