using Microsoft.EntityFrameworkCore;
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Repositories
{
    public class UsersMealsHistoryRepository
    {
        ProjectContext db;
        public UsersMealsHistoryRepository()
        {
            db = new ProjectContext();
        }
        public void Add(UsersMealsHistory usersMealsHistory)
        {
            db.UsersMealsHistories.Add(usersMealsHistory);
            db.SaveChanges();
        }
        public void Update(UsersMealsHistory usersMealsHistory)
        {
            usersMealsHistory.ModifiedDate = DateTime.Now;
            db.UsersMealsHistories.Update(usersMealsHistory);
            db.SaveChanges();
        }
        public void Delete(UsersMealsHistory usersMealsHistory)
        {
            usersMealsHistory.DeletedDate = DateTime.Now;
            usersMealsHistory.IsActive = false;
            db.UsersMealsHistories.Update(usersMealsHistory);
            db.SaveChanges();
        }

        public bool IsMealAlreadyAdded(int mealID,DateTime date,int userID)
        {
            return db.UsersMealsHistories.Any(x => x.MealID == mealID && x.CreatedDate.Date == date.Date && x.IsActive == true && x.UserID == userID);
        }

        public double TodayTotalMealCalorie(int userID,string mealName)
        {
            double totalBreakfastCalorie = 0;
            foreach (var item in db.UsersMealsHistories.Include(x => x.Meal).Where(x => x.UserID == userID && x.Meal.MealName == mealName && x.CreatedDate.Date == DateTime.Now.Date && x.IsActive == true).ToList())
            {
                totalBreakfastCalorie += (item.NumberOfNutritions) * item.Nutrition.Calorie;
            }
            return totalBreakfastCalorie;
        }
        public List<DateTime> GetAllDatesOfUser(AppUser user)
        {
            return db.UsersMealsHistories
                .Where(x => x.UserID == user.ID)
                .GroupBy(x => new { x.CreatedDate.Date })
                .Select(x => x.Key.Date)
                .ToList();
        }
        public double TotalCalorieOfDay(AppUser user, DateTime date)
        {
            double totalCalorie = 0;
            foreach (Meal meal in GetAllMealsOfDay(date, user))
            {
                totalCalorie += GetMealCalorie(user, meal, date);
            }
            return totalCalorie;
        }
        public List<Meal> GetAllMealsOfDay(DateTime date, AppUser user)
        {
            return db.UsersMealsHistories
                .Include(x => x.Meal)
                .Where(x => x.UserID == user.ID && x.CreatedDate.Date == date.Date && x.IsActive == true)
                .Select(x => x.Meal)
                .Distinct()
                .ToList();
        }
        public double GetMealCalorie(AppUser user, Meal meal, DateTime date)
        {
            double calorie = 0;
            foreach (UsersMealsHistory item in db.UsersMealsHistories.Where(x => x.UserID == user.ID && x.CreatedDate.Date == date.Date && x.MealID == meal.ID && x.IsActive == true).ToList())
            {
                calorie += (item.NumberOfNutritions) * item.Nutrition.Calorie;
            }
            return calorie;
        }
        public List<UsersMealsHistory> GetUserMealHistoryOfMeal(int mealid, DateTime date, int userID)
        {
            return db.UsersMealsHistories
                .Where(x => x.MealID == mealid && x.CreatedDate.Date == date.Date && x.IsActive == true && x.UserID == userID)
                .ToList();
        }
        public List<UsersMealsHistory> GetUserMealHistoryOfMeal(int mealid)
        {
            return db.UsersMealsHistories
                .Where(x => x.MealID == mealid && x.IsActive == true)
                .ToList();
        }
        public List<Category> GetAllCategories()
        {
            return db.UsersMealsHistories
                .Join(db.Nutritions, umh => umh.NutritionID, n => n.ID, (umh, n) => new { n.Category, umh.NutritionID, n.CategoryID, umh.IsActive })
                .Where(x => x.IsActive == true)
                .Select(x => x.Category)
                .Distinct()
                .ToList();
        }
        public List<Meal> GetAllMeals(AppUser user)
        {
            return db.UsersMealsHistories
                .Include(x => x.Meal)
                .Where(x => x.IsActive == true && x.AppUser == user)
                .Select(x => x.Meal)
                .Distinct()
                .ToList();
        }
        public double ConsumptionOfCategoryByUser(AppUser user, Category category, int dayago)
        {
            var result = db.Nutritions
                .Join(db.UsersMealsHistories, n => n.ID, umh => umh.NutritionID, (n, umh) => new { n.CategoryID, n.ID, umh.IsActive, umh.NumberOfNutritions, umh.UserID, umh.CreatedDate })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(n => new { n.CategoryID, n.IsActive, n.UserID })
                .Select(x => new { x.Key.CategoryID, TotalConsumption = x.Sum(y => y.NumberOfNutritions), x.Key.IsActive, x.Key.UserID })
                .Where(x => x.IsActive == true && x.CategoryID == category.CategoryID && x.UserID == user.ID).FirstOrDefault();

            if (result == null) return 0;
            else return result.TotalConsumption;
        }
        public double TotalConsumptionOfCategory(int categoryid, int dayago)
        {
            var result = db.Nutritions
                .Join(db.UsersMealsHistories, n => n.ID, umh => umh.NutritionID, (n, umh) => new { n.CategoryID, n.ID, umh.IsActive, umh.NumberOfNutritions, umh.CreatedDate })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(n => new { n.CategoryID, n.IsActive })
                .Select(x => new { x.Key.CategoryID, TotalConsumption = x.Sum(x => x.NumberOfNutritions), x.Key.IsActive })
                .Where(x => x.IsActive == true && x.CategoryID == categoryid).FirstOrDefault();
            if (result == null) return 0;
            else return result.TotalConsumption;
        }
        public double TotalCalorieOfCategory(int categoryid, int dayago)
        {
            var result = db.Nutritions
                .Join(db.UsersMealsHistories, n => n.ID, umh => umh.NutritionID, (n, umh) => new { n.CategoryID, n.ID, umh.IsActive, umh.NumberOfNutritions, n.Calorie, umh.CreatedDate })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(n => new { n.CategoryID, n.IsActive, n.ID, n.Calorie })
                .Select(x => new { x.Key.CategoryID, TotalCalorie = x.Sum(x => x.NumberOfNutritions) * x.Key.Calorie, x.Key.IsActive })
                .Distinct()
                .GroupBy(n => new { n.CategoryID, n.IsActive })
                .Select(x => new { x.Key.CategoryID, SumOfCalories = x.Sum(y => y.TotalCalorie), x.Key.IsActive })
                .Where(x => x.IsActive == true && x.CategoryID == categoryid).FirstOrDefault();
            if (result == null) return 0;
            else return result.SumOfCalories;
        }
        public double TotalCalorieOfCategoryByUser(int categoryid, AppUser user, int dayago)
        {
            var result = db.Nutritions
                .Join(db.UsersMealsHistories, n => n.ID, umh => umh.NutritionID, (n, umh) => new { n.CategoryID, n.Name, umh.IsActive, umh.NumberOfNutritions, n.Calorie, umh.AppUser.ID, umh.CreatedDate })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-dayago))
                .GroupBy(n => new { n.CategoryID, n.IsActive, n.Name, n.Calorie, n.ID })
                .Select(x => new { x.Key.CategoryID, x.Key.ID, TotalCalorie = x.Sum(x => x.NumberOfNutritions) * x.Key.Calorie, x.Key.IsActive })
                .Distinct()
                .GroupBy(n => new { n.CategoryID, n.IsActive, n.ID })
                .Select(x => new { x.Key.CategoryID, SumOfCalories = x.Sum(y => y.TotalCalorie), x.Key.IsActive, x.Key.ID })
                .Where(x => x.IsActive == true && x.CategoryID == categoryid && x.ID == user.ID).FirstOrDefault();
            if (result == null) return 0;
            else return result.SumOfCalories;
        }
        public string GetMealConsumptionsOfAllUsers(Meal meal, int dayago)
        {
            var result = db.Meals
                .Join(db.UsersMealsHistories, m => m.ID, umh => umh.MealID, (m, umh) => new { umh.CreatedDate, umh.IsActive, umh.NumberOfNutritions, m.MealName })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-dayago) && x.MealName == meal.MealName && x.IsActive == true)
                .GroupBy(x => new { x.MealName, x.IsActive })
                .Select(x => new { TotalConsumption = x.Sum(y => y.NumberOfNutritions) })
                .FirstOrDefault();
            return result.TotalConsumption.ToString();
        }

        public string GetMealConsumptionsOfAllUsers(Meal meal, AppUser user, int compareDay)
        {
            var result = db.Meals
                .Join(db.UsersMealsHistories, m => m.ID, umh => umh.MealID, (m, umh) => new { umh.CreatedDate, umh.IsActive, umh.NumberOfNutritions, m.MealName, umh.UserID })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-compareDay)
                && x.MealName == meal.MealName && x.UserID == user.ID && x.IsActive == true)
                .GroupBy(x => new { x.MealName, x.IsActive, x.UserID })
                .Select(x => new { TotalConsumption = x.Sum(y => y.NumberOfNutritions) })
                .FirstOrDefault();
            return result.TotalConsumption.ToString();
        }

        public string GetMealCaloriesOfAllUsers(Meal meal, int compareDay)
        {
            return db.Meals
                .Join(db.UsersMealsHistories, m => m.ID, umh => umh.MealID, (m, umh) => new { umh.CreatedDate, umh.IsActive, umh.NumberOfNutritions, m.MealName, umh.NutritionID })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-compareDay) && x.MealName == meal.MealName && x.IsActive == true)
                .Join(db.Nutritions, m => m.NutritionID, n => n.ID, (m, n) => new { m.MealName, m.NumberOfNutritions, n.Calorie })
                .GroupBy(x => new { x.MealName, x.Calorie })
                .Select(x => new { x.Key.MealName, TotalConsumption = x.Sum(y => y.NumberOfNutritions) * x.Key.Calorie })
                .Distinct()
                .GroupBy(x => x.MealName)
                .Select(x => new { SumOfCalories = x.Sum(x => x.TotalConsumption) })
                .ToList().FirstOrDefault().SumOfCalories.ToString();
        }

        public string GetMealCaloriesOfAllUsers(Meal meal, AppUser user, int compareDay)
        {
            return db.Meals
                .Join(db.UsersMealsHistories, m => m.ID, umh => umh.MealID, (m, umh) => new { umh.CreatedDate, umh.IsActive, umh.NumberOfNutritions, m.MealName, umh.NutritionID, umh.UserID })
                .Where(x => x.CreatedDate > DateTime.Now.AddDays(-compareDay) && x.MealName == meal.MealName && x.IsActive == true && x.UserID == user.ID)
                .Join(db.Nutritions, m => m.NutritionID, n => n.ID, (m, n) => new { m.MealName, m.NumberOfNutritions, n.Calorie })
                .GroupBy(x => new { x.MealName, x.Calorie })
                .Select(x => new { x.Key.MealName, TotalConsumption = x.Sum(y => y.NumberOfNutritions) * x.Key.Calorie })
                .Distinct()
                .GroupBy(x => x.MealName)
                .Select(x => new { SumOfCalories = x.Sum(x => x.TotalConsumption) })
                .ToList().FirstOrDefault().SumOfCalories.ToString();
        }
        public int GetCountOfUsersSpecificMeal(Meal meal, AppUser user)
        {
            return db.UsersMealsHistories
                .Where(x => x.MealID == meal.ID && x.IsActive == true && x.UserID == user.ID)
                .GroupBy(x => x.CreatedDate.Date)
                .Select(x => x.Key.Date)
                .ToList().Count();
        }
        public string GetTotalCalorieOfSpecificMealOfUser(Meal meal, AppUser user)
        {
            double calorie = 0;
            foreach (UsersMealsHistory item in db.UsersMealsHistories.Where(x => x.UserID == user.ID && x.MealID == meal.ID && x.IsActive == true).ToList())
            {
                calorie += (item.NumberOfNutritions) * item.Nutrition.Calorie;
            }
            return calorie.ToString();
        }
    }
}
