using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            UsersMealsHistorys = new();
        }
        public string MealName { get; set; }
        public int? UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<UsersMealsHistory> UsersMealsHistorys { get; set; }
    }
}
