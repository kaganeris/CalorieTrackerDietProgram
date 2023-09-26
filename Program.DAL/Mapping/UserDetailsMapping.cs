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
    public class UserDetailsMapping : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Ignore(x => x.Age);
        }
    }
}
