using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace Supen.Controllers
{
    public class SearchUserController : Controller
    {
        public ActionResult Index(string search)
        {
            using (var db = new SupenEntities())
            {
                var repos = new AppUserRepos();
                var searchedUser = repos.SearchUser(search);
                return View(searchedUser);
            }
        }
    }
}