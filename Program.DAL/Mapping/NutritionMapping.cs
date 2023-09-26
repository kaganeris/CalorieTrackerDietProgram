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
    public class NutritionMapping : IEntityTypeConfiguration<Nutrition>
    {
        public void Configure(EntityTypeBuilder<Nutrition> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.Category).WithMany(x => x.Nutritions).HasForeignKey(x => x.CategoryID);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Nutritions).HasForeignKey(x => x.UserID).IsRequired(false);
        }
    }
}
