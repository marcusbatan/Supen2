using Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public ActionResult listOfTeams()
        {
            using (var db = new SupenEntities())
            {
                var repos = new TeamRepos();
                var listOfTeams = repos.ListTeams();
                return View(listOfTeams);
            }
        }
        public ActionResult TeamPage(Guid id, string teamName)
        {
            var page = new Teams(id, teamName);
            ViewBag.TeamPage = page;
            ViewBag.Team = teamName;
            return View(page);
        }
    }
}