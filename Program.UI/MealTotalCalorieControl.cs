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
    public partial class MealTotalCalorieControl : UserControl
    {
        public MealTotalCalorieControl()
        {
            InitializeComponent();
        }
        public string mealName
        {
            get { return lblMealName.Text; }
            set { lblMealName.Text = value; }
        }
        public string mealTotalCalorie
        {
            get { return lblMealCalorie.Text; }
            set { lblMealCalorie.Text = value; }
        }
    }
}
