using Castle.DynamicProxy.Generators;
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Repositories
{
    public class MealRepository
    {
        ProjectContext db;
        public MealRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Meal meal)
        {
            db.Meals.Add(meal);
            db.SaveChanges();
        }
        public void Update(Meal meal)
        {
            meal.ModifiedDate = DateTime.Now;
            db.Meals.Update(meal);
            db.SaveChanges();
        }
        public void Delete(Meal meal)
        {
            meal.DeletedDate = DateTime.Now;
            meal.IsActive = false;
            db.Meals.Update(meal);
            db.SaveChanges();
        }
        public List<Meal> GetMeals()
        {
            return db.Meals.ToList();
        }

        public List<string> GetMealsNames(int userID)
        {
            return db.Meals.Where(x => x.UserId == null || x.UserId == userID && x.IsActive == true).Select(x => x.MealName).ToList();
        }

        public int GetMealID(string text)
        {
            return db.Meals.Where(x => x.MealName == text).Select(x => x.ID).FirstOrDefault();
        }
        public bool CheckEntries(string mealName)
        {
            var nutName = db.Meals.FirstOrDefault(x => x.MealName == mealName);
            if (nutName == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
