//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;

    public partial class AppUser
    {
        public AppUser()
        {
            this.Blogg = new HashSet<Blogg>();
        }
        public AppUser(Guid id)
        {
            using (var db = new SupenEntities())
            {
                var repos = new AppUserRepos();
                var getUser = repos.GetAppUser(id);
                AppUserId = id;
            }
        }
        public System.Guid AppUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Blogg> Blogg { get; set; }
    }
}
