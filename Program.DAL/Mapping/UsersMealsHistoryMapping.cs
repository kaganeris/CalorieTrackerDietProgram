using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Mapping
{
    public class UsersMealsHistoryMapping : IEntityTypeConfiguration<UsersMealsHistory>
    {
        public void Configure(EntityTypeBuilder<UsersMealsHistory> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.AppUser).WithMany(x => x.UsersMealsHistorys).HasForeignKey(x => x.UserID);

            builder.HasOne(x => x.Meal).WithMany(x => x.UsersMealsHistorys).HasForeignKey(x => x.MealID);

            builder.HasOne(x => x.Nutrition).WithMany(x => x.UsersMealsHistorys).HasForeignKey(x => x.NutritionID);
        }
    }
}
