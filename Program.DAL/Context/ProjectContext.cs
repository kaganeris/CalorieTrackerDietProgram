using Microsoft.EntityFrameworkCore;
using Program.DAL.Mapping;
using Program.DAL.SeedData;
using Program.DATA.Entities;
using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UsersMealsHistory> UsersMealsHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-QLKMCAN; Database=CalorieTrackerProgramDB; Uid=sa; Pwd=123;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new AppUserMapping().Configure(modelBuilder.Entity<AppUser>());

            new UserDetailsMapping().Configure(modelBuilder.Entity<UserDetails>());

            new MealMapping().Configure(modelBuilder.Entity<Meal>());

            new NutritionMapping().Configure(modelBuilder.Entity<Nutrition>());

            new UsersMealsHistoryMapping().Configure(modelBuilder.Entity<UsersMealsHistory>());

            modelBuilder.ApplyConfiguration(new SeedCategories());
            modelBuilder.ApplyConfiguration(new SeedNutritions());
            modelBuilder.ApplyConfiguration(new SeedMeals());
        }
    }
}
