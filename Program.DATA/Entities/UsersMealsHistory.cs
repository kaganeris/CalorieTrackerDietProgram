using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class UsersMealsHistory : BaseEntity
    {
        public int UserID { get; set; }
        public int MealID { get; set; }
        public int NutritionID { get; set; }
        public int NumberOfNutritions { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual Nutrition Nutrition { get; set; }
    }
}
