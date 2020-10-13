using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AppUserRepos
    {
        public bool AddUser(string FirstName, string LastName, int Age, string Email, string Password, byte[] Image)
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
                    Image = Image
                };
                return true;
            }
        }
    }
}
