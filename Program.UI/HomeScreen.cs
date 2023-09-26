using Castle.DynamicProxy.Generators;
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
    public partial class HomeScreen : Form
    {
        AppUser user;
        public HomeScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }

        public void UpdateTotalCalorie()
        {
            int totalCalorie = 0;
            foreach (Control control in flpNutritionCart.Controls)
            {
                totalCalorie += int.Parse(((NutritionCartControl)control).nutritionCalorie);
            }
            lblTotalCalorie.Text = totalCalorie.ToString();
        }
        NutritionRepository nutritionRepository;
        MealRepository mealRepository;
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            nutritionRepository = new NutritionRepository();
            mealRepository = new MealRepository();

            categoryName = "Vegetable";
            CategoryClickEvent();

            foreach (var item in mealRepository.GetMealsNames(user.ID))
            {
                cmbMeals.Items.Add(item);
            }
            btnPreviousPage.Enabled = false;
            lblPageNumber.Text = pageNumber.ToString();
        }

        public void NutritionsAddToPanel(List<Nutrition> nutritions)
        {
            flpNutritions.Controls.Clear();
            foreach (var item in nutritions)
            {
                NutritionControl nutritionControl = new NutritionControl(this);
                nutritionControl.Name = item.Name;
                nutritionControl.nutritionName = item.Name;
                nutritionControl.nutritionCalorie = item.Calorie.ToString();
                nutritionControl.nutritionMeasurementType = item.PortionType.ToString();
                nutritionControl.nutritionMeasurement = item.Measurement.ToString();
                nutritionControl.Tag = item;
                foreach (Control control in nutritionControl.Controls)
                {
                    if (control is PictureBox)
                        try
                        {
                            ((PictureBox)control).Image = Image.FromFile(Application.StartupPath + item.Picture);
                        }
                        catch (Exception)
                        {


                        }
                }
                flpNutritions.Controls.Add(nutritionControl);
            }
        }
        int pageNumber = 1;
        private void btnVegetable_Click(object sender, EventArgs e)
        {
            categoryName = "Vegetable";
            CategoryClickEvent();
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            categoryName = "Fruit";
            CategoryClickEvent();
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            categoryName = "Soft Drink";
            CategoryClickEvent();
        }

        private void btnAlcohol_Click(object sender, EventArgs e)
        {
            categoryName = "Alcohol";
            CategoryClickEvent();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            categoryName = "Snack";
            CategoryClickEvent();
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            categoryName = "Dessert";
            CategoryClickEvent();
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            categoryName = "Salad";
            CategoryClickEvent();
        }

        private void btnDairy_Click(object sender, EventArgs e)
        {
            categoryName = "Dairy";
            CategoryClickEvent();
        }

        private void btnFishAndSeadfood_Click(object sender, EventArgs e)
        {
            categoryName = "Fish and Seafood";
            CategoryClickEvent();
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            categoryName = "Fast Food";
            CategoryClickEvent();
        }

        private void btnMeatOrPoultry_Click(object sender, EventArgs e)
        {
            categoryName = "Meat or Poultry";
            CategoryClickEvent();
        }

        private void btnGrainBeanNuts_Click(object sender, EventArgs e)
        {
            categoryName = "Grain, Bean and Nuts";
            CategoryClickEvent();
        }
        private void btnOthers_Click(object sender, EventArgs e)
        {
            categoryName = "Others";
            CategoryClickEvent();
        }

        private void flpNutritionCart_ControlAdded(object sender, ControlEventArgs e)
        {
            UpdateTotalCalorie();
        }

        private void btnSaveMeal_Click(object sender, EventArgs e)
        {
            UsersMealsHistoryRepository usersMealsHistoryRepository = new UsersMealsHistoryRepository();
            string mealName = cmbMeals.Text;
            int mealID = mealRepository.GetMealID(mealName);

            if (usersMealsHistoryRepository.IsMealAlreadyAdded(mealID, DateTime.Now,user.ID))
            {
                MessageBox.Show("Today's selected meal is already added!");
                return;
            }

            if (cmbMeals.SelectedItem == null)
            {
                MessageBox.Show("Please choose a Meal!");
            }
            else
            {
                foreach (Control item in flpNutritionCart.Controls)
                {
                    UsersMealsHistory usersMealsHistory = new UsersMealsHistory();
                    usersMealsHistory.UserID = user.ID;
                    usersMealsHistory.MealID = mealID;
                    usersMealsHistory.NutritionID = ((Nutrition)item.Tag).ID;
                    usersMealsHistory.NumberOfNutritions = int.Parse(((NutritionCartControl)item).lblCount.Text);
                    usersMealsHistoryRepository.Add(usersMealsHistory);
                }
                MessageBox.Show("Meal is saved!");
                flpNutritionCart.Controls.Clear();
                categoryName = "Vegetable";
                CategoryClickEvent();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            pageNumber--;
            if (pageNumber == 1)
            {
                btnPreviousPage.Enabled = false;
            }
            lblPageNumber.Text = pageNumber.ToString();
            if (txtSearchNtr.Text.Length > 0)
            {
                SearchedNutritionLoad();
            }
            else
            {
                CategoryNameLoad();
            }
            btnNextPage.Enabled = true;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            pageNumber++;
            if (pageNumber > 1)
            {
                btnPreviousPage.Enabled = true;
            }
            lblPageNumber.Text = pageNumber.ToString();
            if (txtSearchNtr.Text.Length > 0)
            {
                SearchedNutritionLoad();
                List<Nutrition> nutritions = nutritionRepository.GetSearchedNutritions(user.ID, searchNtr, pageNumber);
                if (nutritions.Count < 9)
                    btnNextPage.Enabled = false;
                else
                    btnNextPage.Enabled = true;
            }
            else
            {
                CategoryNameLoad();
                List<Nutrition> nutritions = nutritionRepository.GetNutrionsByCategoryName(categoryName, pageNumber,user.ID);
                if (nutritions.Count < 9)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
            }

        }
        string categoryName;
        public void CategoryNameLoad()
        {
            NutritionsAddToPanel(nutritionRepository.GetNutrionsByCategoryName(categoryName, pageNumber,user.ID));
        }
        public void CategoryClickEvent()
        {
            pageNumber = 1;
            lblPageNumber.Text = pageNumber.ToString();
            txtSearchNtr.Text = "";
            List<Nutrition> nutritions = nutritionRepository.GetNutrionsByCategoryName(categoryName, pageNumber, user.ID);
            NutritionsAddToPanel(nutritions);
            if (nutritions.Count < 9)
            {
                btnNextPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
            }
        }
        string searchNtr;
        private void txtSearchNtr_TextChanged(object sender, EventArgs e)
        {
            searchNtr = txtSearchNtr.Text;
            SearchedNutritionLoad();
        }
        public void SearchedNutritionLoad()
        {
            NutritionsAddToPanel(nutritionRepository.GetSearchedNutritions(user.ID, searchNtr, pageNumber));
        }
    }
}
