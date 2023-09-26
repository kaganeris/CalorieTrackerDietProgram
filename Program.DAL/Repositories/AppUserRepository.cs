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
    public class AppUserRepository
    {
        ProjectContext db;
        public AppUserRepository()
        {
            db = new ProjectContext();
        }
        public void Add(AppUser User)
        {
            db.AppUsers.Add(User);
            db.SaveChanges();
        }
        public void Update(AppUser User)
        {
            User.ModifiedDate = DateTime.Now;
            db.AppUsers.Update(User);
            db.SaveChanges();
        }
        public void Delete(AppUser User)
        {
            User.DeletedDate = DateTime.Now;
            User.IsActive = false;
            db.AppUsers.Update(User);
            db.SaveChanges();
        }
        public AppUser Control(string email, string password)
        {
            return db.AppUsers.Include(x => x.UserDetails).AsNoTracking().FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public bool RegisterControl(string email)
        {
            return db.AppUsers.AsNoTracking().Any(x => x.Email == email);
        }

        public AppUser CheckInfo(string email, string securityQuestion,string answer)
        {
            return db.AppUsers.FirstOrDefault(u => u.Email == email && u.SecurityQuestion == securityQuestion && u.Answer == answer);
        }

        public AppUser UserByUserId(int userId)
        {
            return db.AppUsers.FirstOrDefault(x => x.ID == userId);
        }
        public List<AppUser> GetAppUsers()
        {
            return db.AppUsers.Where(x => x.IsActive == true).ToList();
        }
    }
}
