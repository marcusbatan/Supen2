using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AppUserRepos
    {
        public bool AddUser(string FirstName, string LastName, int Age, string Email, string Password)
        {
            using (var db = new SupenEntities())
            {
                var appUser = new AppUser
                {
                    AppUserId = Guid.NewGuid(),
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = Age,
                    Email = Email,
                    Password = Password,
                };
                db.AppUser.Add(appUser);
                db.SaveChanges();
                return true;
            }
        }
        public AppUser GetAppUser(Guid id)
        {
            using (var db = new SupenEntities())
            {
                var getUser = db.AppUser.Where(a => a.AppUserId == id).FirstOrDefault();
                return getUser;
            }
        }
        public List<AppUser> SearchUser(string search)
        {
            using (var db = new SupenEntities())
            {
                var searchuser = db.AppUser.Where(a => a.Email.Contains(search)).ToList();
                return searchuser;
            }
        }
        public AppUser GetMyProfile(Guid id)
        {
            using (var db = new SupenEntities())
            {
                var getId = db.AppUser.Where(a => a.AppUserId == id).FirstOrDefault();
                return getId;
            }
        }
        public void UpdateValues(string firstName, string lastName, int age, Guid id)
        {
            using (var db = new SupenEntities())
            {
                var user = db.AppUser.FirstOrDefault(a => a.AppUserId == id);
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Age = age;
                db.SaveChanges();
            }

        }
    }
}
