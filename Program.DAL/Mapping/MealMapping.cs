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
    public class MealMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.MealName).IsRequired();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Meals).HasForeignKey(x => x.UserId).IsRequired(false);
        }
    }
}
