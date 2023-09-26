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
    public partial class NutritionCartControl : UserControl
    {
        HomeScreen homeScreen;
        NutritionControl nutritionControl;
        public NutritionCartControl(HomeScreen hmScreen, NutritionControl nCtrl)
        {
            InitializeComponent();
            homeScreen = hmScreen;
            nutritionControl = nCtrl;
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
        int count, calorieCount, measurementCount;
        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                homeScreen.flpNutritionCart.Controls.Remove(this);
                nutritionControl.btnAdd.Enabled = true;
                homeScreen.UpdateTotalCalorie();
                return;
            }
            else
            {
                lblCount.Text = count.ToString();
                lblNutCalorie.Text = (calorieCount * count).ToString();
                lblNutMeasurement.Text = (measurementCount * count).ToString();
                homeScreen.UpdateTotalCalorie();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnMinus.Enabled = true;
            count++;
            lblCount.Text = count.ToString();
            lblNutCalorie.Text = (calorieCount * count).ToString();
            lblNutMeasurement.Text = (measurementCount * count).ToString();
            homeScreen.UpdateTotalCalorie();
        }

        private void NutritionCartControl_Load(object sender, EventArgs e)
        {
            count = 1;
            lblCount.Text = count.ToString();
            calorieCount = int.Parse(lblNutCalorie.Text);
            measurementCount = int.Parse(lblNutMeasurement.Text);
        }
    }
}
