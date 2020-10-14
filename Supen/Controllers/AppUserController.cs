using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supen.Controllers
{
    public class AppUserController : Controller
    {
        // GET: AppUser
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AppUser user)
        {
            using (var db = new SupenEntities())
            {
                var repos = new AppUserRepos();
                var addUser = repos.AddUser(user.FirstName, user.LastName, user.Age, user.Email, user.Password);
                ViewBag.mess = "Success!";
            }
            return View(user);
        }
    }
}