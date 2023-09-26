using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Nutrition : BaseEntity
    {
        public Nutrition()
        {
            UsersMealsHistorys = new();
        }
        public int CategoryID { get; set; }
        public int? UserID { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public float Calorie { get; set; }
        public float Measurement { get; set; }
        public PortionType PortionType { get; set; }
        public virtual Category Category { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<UsersMealsHistory> UsersMealsHistorys { get; set; }
    }
}
