using Program.DAL.Repositories;
using Program.DATA.Entities;
using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI
{
    public partial class AddNutritionScreen : Form
    {
        AppUser user;
        public AddNutritionScreen(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }
        NutritionRepository nutritionRepository;
        CategoryRepository categoryRepository;
        private void AddNutritionScreen_Load(object sender, EventArgs e)
        {
            nutritionRepository = new NutritionRepository();
            categoryRepository = new CategoryRepository();

            ButtonControls(true);

            GetAllNutrinions();

            foreach (PortionType item in Enum.GetValues(typeof(PortionType)))
            {
                cbPortionType.Items.Add(item);
            }

            foreach (Category item in categoryRepository.GetAllCategories())
            {
                cbCategory.Items.Add(item);
            }
        }
        private void GetAllNutrinions()
        {
            lstNutrinions.Items.Clear();
            var nutritions = nutritionRepository.GetAllNutritions(user.ID);

            foreach (var item in nutritions)
            {
                ListViewItem lv = new ListViewItem(item.ID.ToString());
                lv.SubItems.Add(item.UserID.ToString());
                lv.SubItems.Add(item.Name);
                lv.SubItems.Add(item.Calorie.ToString());
                lv.SubItems.Add(item.Measurement.ToString());
                lv.SubItems.Add(item.PortionType.ToString());
                lv.SubItems.Add(item.Category.CategoryName);
                lstNutrinions.Items.Add(lv);
                lv.Tag = item;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nutritionName = txtNutritionName.Text;

            if (txtNutritionName.Text == string.Empty)
            {
                MessageBox.Show("Nutrition name cannot be left blank!");
            }
            else
            {
                if (nutritionRepository.CheckEntries(nutritionName))
                {
                    MessageBox.Show("Has been recorded before!");
                }
                else
                {
                    Nutrition nutrition = new Nutrition();
                    nutrition.UserID = user.ID;
                    nutrition.Name = nutritionName;
                    nutrition.Calorie = float.Parse(txtCalorie.Text);
                    nutrition.CategoryID = ((Category)cbCategory.SelectedItem).CategoryID;
                    nutrition.PortionType = (PortionType)cbPortionType.SelectedItem;
                    nutrition.Measurement = float.Parse(txtMeasurement.Text);
                    string path="";
                    if (pbNutritionImage.Tag != null)
                    {
                        path = Guid.NewGuid() + pbNutritionImage.Tag.ToString();
                        pbNutritionImage.Image.Save(Application.StartupPath + "\\FoodPhotos\\" + path);
                    }
                    nutrition.Picture ="\\FoodPhotos\\" + path;

                    nutritionRepository.Add(nutrition);
                    MessageBox.Show("Successful");
                    GetAllNutrinions();
                    ClearItems(gbxAddNutrition.Controls);
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
                    comboBox.SelectedItem = -1;
                }
            }
        }

        private void pbNutritionImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Fotografi(png,jpg,gif)|*.png;*.jpg;*.gif";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pbNutritionImage.Image = Image.FromFile(ofd.FileName);

                pbNutritionImage.Tag = Path.GetExtension(ofd.FileName);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Nutrition nutrition = lstNutrinions.SelectedItems[0].Tag as Nutrition;
            if (lstNutrinions.SelectedItems.Count > 0)
            {
                if (nutrition.UserID == null)
                {
                    MessageBox.Show("You cant update default nutritions!");
                    return;
                }
                else
                {
                    nutrition.Name = txtNutritionName.Text;
                    nutrition.Calorie = float.Parse(txtCalorie.Text);
                    nutrition.Category = (Category)cbCategory.SelectedItem;
                    nutrition.PortionType = (PortionType)cbPortionType.SelectedItem;
                    nutrition.Measurement = float.Parse(txtMeasurement.Text);
                    nutritionRepository.Update(nutrition);
                    MessageBox.Show("Successful");
                    GetAllNutrinions();
                    ButtonControls(true);
                    ClearItems(gbxAddNutrition.Controls);
                }
            }
            else
            {
                MessageBox.Show("Please select a product!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedNutrition = lstNutrinions.SelectedItems[0].Tag as Nutrition;

            if (lstNutrinions.SelectedItems.Count > 0)
            {
                if (selectedNutrition.UserID == null)
                {
                    MessageBox.Show("You cant delete default nutritions!");
                    return;
                }
                else if (selectedNutrition != null)
                {
                    nutritionRepository.Delete(selectedNutrition);
                    MessageBox.Show("Successful");
                    GetAllNutrinions();
                    ButtonControls(true);
                    ClearItems(gbxAddNutrition.Controls);
                }
                else
                {
                    MessageBox.Show("No Related Product Found");
                }
            }
        }

        private void lstNutrinions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNutrinions.SelectedItems.Count > 0)
            {
                Nutrition nutrition = lstNutrinions.SelectedItems[0].Tag as Nutrition;
                txtNutritionName.Text = nutrition.Name;
                txtCalorie.Text = nutrition.Calorie.ToString();
                txtMeasurement.Text = nutrition.Measurement.ToString();
                cbCategory.SelectedItem = nutrition.Category.CategoryName;
                cbPortionType.SelectedItem = nutrition.PortionType;
                pbNutritionImage.Image = Image.FromFile(Application.StartupPath + nutrition.Picture);
                ButtonControls(false);
            }
        }
        public void ButtonControls(bool status)
        {
            btnAdd.Enabled = status;
            btnDelete.Enabled = !status;
            btnUpdate.Enabled = !status;
        }
    }
}
