using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            UserType = UserType.User;
            UsersMealsHistorys = new();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SecurityQuestion { get; set; }
        public string Answer { get; set; }
        public string? Picture { get; set; }
        public UserType UserType { get; set; }
        public virtual UserDetails UserDetails { get; set; }
        public virtual List<UsersMealsHistory> UsersMealsHistorys { get; set; }
        public virtual List<Meal> Meals { get; set; }
        public virtual List<Nutrition> Nutritions { get; set; }

    }
}
