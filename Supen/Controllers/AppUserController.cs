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
        bool ErrorMessage = false;
        // GET: AppUser
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AppUser user)
        {
            using (var db = new SupenEntities())
            {
                var repos = new AppUserRepos();
                var addUser = repos.AddUser(user.FirstName, user.LastName, user.Age, user.Email, user.Password);
                ViewBag.mess = "Success!";
            }
            return View(user);
        }
        public ActionResult Profile(Guid id)
        {
            var visitProfile = new Database.AppUser(id);
            if (ErrorMessage == true)
            {
                ViewBag.mess = "test";
            }
            ViewBag.profile = visitProfile;
            return View();
        }
        public ActionResult MyPage(Guid id)
        {
            var visitMyPage = new Database.AppUser(id);
            if (ErrorMessage == true)
            {
                ViewBag.mess = "test";
            }
            ViewBag.myPage = visitMyPage;
            return View();
        }
        public ActionResult UpdateValues()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateValues(string firstName, string lastName, int age)
        {
            using (var db = new SupenEntities())
            {
                var getId = db.AppUser.Where(a => a.Email == System.Web.HttpContext.Current.User.Identity.Name).FirstOrDefault().AppUserId;
                var repos = new AppUserRepos();
                repos.UpdateValues(firstName, lastName, age, getId);
                return View();
            }
        }
    }
}