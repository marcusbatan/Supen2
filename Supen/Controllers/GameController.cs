using Database;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Supen.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            var db = new SupenEntities();
            var teams = new Teams();
            ViewBag.Team = new SelectList(db.Teams, "TeamName", "TeamName", "SelectedValue");
            ViewBag.Team2 = new SelectList(db.Teams, "TeamName", "TeamName", "SelectedValue");
            return View();
        }
        [HttpPost]
        public ActionResult Index(Games game)
        {
            try
            {
                using (var db = new SupenEntities())
                {
                    var repos = new GameRepos();
                    repos.addGames(game.HomeTeam, game.AwayTeam, game.HomeScore, game.AwayScore);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return View();
        }
    }
}