using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supen.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string teamName)
        {
            using (var db = new SupenEntities())
            {
                var repos = new TeamRepos();
                var rep = repos.CreateTeam(teamName);
                return View(rep);
            }
        }
    }
}