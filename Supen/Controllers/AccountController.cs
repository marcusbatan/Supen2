using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Supen.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AppUser appuser)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SupenEntities())
                {
                    var obj = db.AppUser.Where(a => a.Email.Equals(appuser.Email) && a.Password.Equals(appuser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.AppUserId.ToString();
                        Session["Email"] = obj.Email.ToString();
                        return RedirectToAction("Home");
                    }
                }
            }
            return View(appuser);
        }

    }
}