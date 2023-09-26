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
    public partial class NutritionControl : UserControl
    {
        HomeScreen homeScreen;
        public NutritionControl(HomeScreen hmscreen)
        {
            InitializeComponent();
            homeScreen = hmscreen;
        }
        public Image nutritionImage
        {
            get { return pbNutritionImage.Image; }
            set { pbNutritionImage.Image = value; }
        }
        public string nutritionName
        {
            get { return lblNutritionName.Text; }
            set { lblNutritionName.Text = value; }
        }
        public string nutritionMeasurement
        {
            get { return lblNutMeasurement.Text; }
            set { lblNutMeasurement.Text = value; }
        }
        public string nutritionCalorie
        {
            get { return lblNutCalorie.Text; }
            set { lblNutCalorie.Text = value; }
        }
        public string nutritionMeasurementType
        {
            get { return lblNutMeasurementType.Text; }
            set { lblNutMeasurementType.Text = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NutritionCartControl nutritionCartControl = new NutritionCartControl(homeScreen, this);
            nutritionCartControl.Name = this.Name + "Cart";
            nutritionCartControl.nutritionName = nutritionName;
            nutritionCartControl.nutritionImage = nutritionImage;
            nutritionCartControl.nutritionMeasurement = nutritionMeasurement;
            nutritionCartControl.nutritionCalorie = nutritionCalorie;
            nutritionCartControl.nutritionMeasurementType = nutritionMeasurementType;
            nutritionCartControl.Tag = this.Tag;
            homeScreen.flpNutritionCart.Controls.Add(nutritionCartControl);
            btnAdd.Enabled = false;
        }
    }
}
