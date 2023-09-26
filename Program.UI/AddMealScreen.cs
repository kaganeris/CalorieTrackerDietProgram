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
    public partial class AddMealScreen : Form
    {
        AppUser user;
        public AddMealScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }
        MealRepository mealRepository;
        private void AddMealScreen_Load(object sender, EventArgs e)
        {
            mealRepository = new MealRepository();
            GetAllMeals();
        }
        private void GetAllMeals()
        {
            lstMeals.Items.Clear();
            var meals = mealRepository.GetMeals();

            foreach (var item in meals)
            {
                ListViewItem lv = new ListViewItem(item.ID.ToString());
                lv.SubItems.Add(item.MealName);

                lv.SubItems.Add(item.IsActive.ToString());
                lv.SubItems.Add(item.CreatedDate.ToString());
                lv.SubItems.Add(item.DeletedDate.ToString());
                lstMeals.Items.Add(lv);
                lv.Tag = item;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mealName = txtMealName.Text;
            if (txtMealName.Text == string.Empty)
            {
                MessageBox.Show("Food name cannot be left blank!");
            }
            else
            {
                if (mealRepository.CheckEntries(mealName))
                {
                    MessageBox.Show("Has been recorded before!");
                }
                else
                {
                    var meal = new Meal()
                    {
                        UserId = user.ID,
                        MealName = txtMealName.Text,
                    };
                    mealRepository.Add(meal);
                    MessageBox.Show("Successful");
                    GetAllMeals();
                    ClearItems(gbxAddMeal.Controls);
                }
            }
        }

        private void ClearItems(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstMeals.SelectedItems.Count > 0)
            {
                Meal meal = lstMeals.SelectedItems[0].Tag as Meal;
                if (meal.MealName == "BreakFast" || meal.MealName == "Lunch" || meal.MealName == "Dinner")
                {
                    MessageBox.Show("You cant update default meals!");
                    return;
                }
                else
                {
                    meal.MealName = txtMealName.Text;
                    mealRepository.Update(meal);
                    MessageBox.Show("Successful");
                    GetAllMeals();
                    ClearItems(gbxAddMeal.Controls);
                }
            }
            else
            {
                MessageBox.Show("Please select a product!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedMeals = lstMeals.SelectedItems[0].Tag as Meal;
            if (lstMeals.SelectedItems.Count > 0)
            {
                if (selectedMeals.MealName == "BreakFast" || selectedMeals.MealName == "Lunch" || selectedMeals.MealName == "Dinner")
                {
                    MessageBox.Show("You cant delete default meals!");
                    return;
                }
                else if (selectedMeals != null)
                {
                    mealRepository.Delete(selectedMeals);
                    MessageBox.Show("Successful");
                    GetAllMeals();
                    ClearItems(gbxAddMeal.Controls);
                }
            }
            else
            {
                MessageBox.Show("No Related Product Found");
            }
        }

        private void lstMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMeals.SelectedItems.Count > 0)
            {
                Meal meal = lstMeals.SelectedItems[0].Tag as Meal;
                txtMealName.Text = meal.MealName;
            }
        }
    }
}
