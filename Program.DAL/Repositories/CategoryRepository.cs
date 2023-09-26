using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Repositories
{
    public class CategoryRepository
    {
        ProjectContext db;
        public CategoryRepository()
        {
            db = new ProjectContext();
        }
        public List<Category> GetAllCategories()
        {
            return db.Categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            return db.Categories.Where(x => x.CategoryID == id).ToList().FirstOrDefault();
        }
    }
}
