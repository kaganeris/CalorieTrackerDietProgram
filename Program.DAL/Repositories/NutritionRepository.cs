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
    public class NutritionRepository
    {
        ProjectContext db;
        public NutritionRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Nutrition ntr)
        {
            db.Nutritions.Add(ntr);
            db.SaveChanges();
        }
        public void Update(Nutrition ntr)
        {
            ntr.ModifiedDate = DateTime.Now;
            db.Nutritions.Update(ntr);
            db.SaveChanges();
        }
        public void Delete(Nutrition ntr)
        {
            ntr.DeletedDate = DateTime.Now;
            ntr.IsActive = false;
            db.Nutritions.Update(ntr);
            db.SaveChanges();
        }
        public List<Nutrition> GetNutrionsByCategoryName(string categoryName,int pageNumber,int userID)
        {
            return db.Nutritions.Include(x => x.Category).AsNoTracking().Where(x => x.Category.CategoryName == categoryName && x.IsActive == true&& (x.UserID == null || x.UserID == userID)).Skip((pageNumber - 1) * 9).Take(9).ToList();
        }
        public List<Nutrition> GetAllNutritions(int userID)
        {
            return db.Nutritions.Include(x => x.Category).AsNoTracking().Where(x => x.UserID == null || x.UserID == userID).ToList();
        }
        public List<Nutrition> GetAllNutrionsByPages(int pageNumber, int userID)
        {
            return db.Nutritions.Include(x => x.Category).AsNoTracking().Where(x => x.UserID == null || x.UserID == userID && x.IsActive == true).Skip((pageNumber - 1) * 9).Take(9).ToList();
        }
        public bool CheckEntries(string nutritionName)
        {
            var nutName = db.Nutritions.FirstOrDefault(x => x.Name == nutritionName);
            if (nutName == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Nutrition> GetSearchedNutritions(int userID,string nutritionName,int pageNumber)
        {
            return db.Nutritions.AsNoTracking().Where(x => x.Name.Contains(nutritionName) && x.IsActive == true && (x.UserID == null || x.UserID == userID)).Skip((pageNumber - 1) * 9).Take(9).ToList();
        }
        public Nutrition GetNutritionByID(int id)
        {
            return db.Nutritions.Where(x => x.ID == id).ToList().FirstOrDefault();
        }
    }
}
