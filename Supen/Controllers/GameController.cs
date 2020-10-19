using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Supen.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id, string hometeam, string awayteam, int homescore, int awayscore, int teamId)
        {
            using (var db = new SupenEntities())
            {
                var repos = new GameRepos();
                repos.addGames(id, hometeam, awayteam, homescore, awayscore, teamId);
            }
            return View();
        }
        public ActionResult fillCmb()
        {
            var db = new SupenEntities();
            var teamList = db.TeamSet.ToList();
            SelectList list = new SelectList(teamList, "Id", "TeamName");
            ViewBag.listofteams = list;
            return View();

        }
    }
}