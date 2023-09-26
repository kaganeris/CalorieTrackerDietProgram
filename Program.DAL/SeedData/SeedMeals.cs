using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.SeedData
{
    public class SeedMeals : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData
                (
                    new Meal { ID = 1,MealName = "Breakfast"},
                    new Meal { ID = 2,MealName = "Lunch"},
                    new Meal { ID = 3,MealName = "Dinner"}
                );
        }
    }
}
