using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Category
    {
        public Category()
        {
            Nutritions = new();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Nutrition> Nutritions { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
