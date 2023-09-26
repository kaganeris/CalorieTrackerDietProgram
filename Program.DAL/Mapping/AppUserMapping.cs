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
    public class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.UserDetails).WithOne(x => x.AppUser).HasForeignKey<UserDetails>(x => x.ID);

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
